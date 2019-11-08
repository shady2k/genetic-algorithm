using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NCalc;

namespace ga
{
    public partial class Form1 : Form
    {
        ConcurrentBag<KeyValuePair<int, double>> plotData = new ConcurrentBag<KeyValuePair<int, double>>();

        public Form1()
        {
            InitializeComponent();
            cbExtremum.SelectedIndex = 0;
        }
        private double fitnessFunction(string function, double x)
        {
            double res = 0;

            try
            {
                Expression e = new Expression(function);
                e.Parameters["x"] = x;
                res = (double)e.Evaluate();
            } catch
            {
                return double.NaN;
            }
            return res;

            //return Math.Cos(x) / (1 + Math.Exp(-x));
        }
        private void lockControls(bool isEnabled)
        {
            if(isEnabled)
            {
                foreach (Control item in splitContainer2.Panel1.Controls)
                {
                    item.Enabled = false;
                }
                txtLog.Text = "Выполняется...";
            } else
            {
                foreach (Control item in splitContainer2.Panel1.Controls)
                {
                    item.Enabled = true;
                }
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            lockControls(true);

            string log;

            decimal maxGenerations = nudMaxGenerations.Value;
            decimal maxEqualGenerations = nudMaxEqualGenerations.Value;

            double minValue = decimal.ToDouble(nudMinValue.Value);
            double maxValue = decimal.ToDouble(nudMaxValue.Value);
            int maxPopulationSie = decimal.ToInt32(nudMaxPopulationSize.Value);
            double crossPossibility = decimal.ToDouble(nudCrossPossibility.Value);
            double mutationPossibility = decimal.ToDouble(nudMutationPossibility.Value);
            int initPopulationSie = decimal.ToInt32(nudInitPopulationSize.Value);
            string txtFunction = tbFunction.Text;
            bool isMaxExtremum = true;
            if (cbExtremum.SelectedIndex == 0)
            {
                isMaxExtremum = true;
            }
            else
            {
                isMaxExtremum = false;
            }

            plotData = new ConcurrentBag<KeyValuePair<int, double>>();
            Population population = null;
            try
            {
                population = new Population(minValue, maxValue, maxPopulationSie, crossPossibility,
                                           mutationPossibility, initPopulationSie, txtFunction, fitnessFunction, isMaxExtremum);
            } catch(Exception ex)
            {
                log = String.Format("Прошло поколений: {0}\r\n", 0);
                log += String.Format("Прошло времени: {0} секунд\r\n", 0);
                log += String.Format("Значение ЦФ: {0}\r\n", "-");
                log += String.Format("Возникла ошибка:{0}\r\n", ex.Message);
                log += String.Format("Стек трейс:\r\n{0}\r\n", ex.StackTrace);
                txtLog.Text = log;
                lockControls(false);
                return;
            }

            log = await Task.Run(() => Start(maxGenerations, maxEqualGenerations, population));
            txtLog.Text = log;
            Console.WriteLine("Exit task");

            lockControls(false);
        }

        private string Start(decimal maxGenerations, decimal maxEqualGenerations, Population population)
        {
            string log;
            double lastValue = 0;
            int equalCount = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                for (int i = 0; i < maxGenerations; i++)
                {
                    population.Cross();
                    population.Mutation();
                    population.TestChromosomes();
                    population.Selection();
                    var t = population.GetBestСhromosome()[0];
                    plotData.Add(new KeyValuePair<int, double>(population.generation, t.value));
                    Console.WriteLine("Generation = " + population.generation + ", value = " + t.value);
                    this.BeginInvoke(new MethodInvoker(updateChart));

                    if (i == 0)
                    {
                        lastValue = t.value;
                    }
                    else
                    {
                        if (lastValue.Equals(t.value))
                        {
                            equalCount++;
                        }
                        else
                        {
                            equalCount = 0;
                        }
                        lastValue = t.value;
                    }
                    if (equalCount > maxEqualGenerations)
                    {
                        Console.WriteLine("maxEqualGenerations break");
                        break;
                    }
                }
            } catch(Exception ex)
            {
                stopwatch.Stop();
                log = String.Format("Прошло поколений: {0}\r\n", population.generation);
                log += String.Format("Прошло времени: {0} секунд\r\n", (int)stopwatch.Elapsed.TotalSeconds);
                log += String.Format("Значение ЦФ: {0}\r\n", lastValue);
                log += String.Format("Возникла ошибка:{0}\r\n", ex.Message);
                log += String.Format("Стек трейс:\r\n{0}\r\n", ex.StackTrace);
            }

            stopwatch.Stop();
            log = String.Format("Прошло поколений: {0}\r\n", population.generation);
            log += String.Format("Прошло времени: {0} секунд\r\n", (int)stopwatch.Elapsed.TotalSeconds);
            log += String.Format("Значение ЦФ: {0}\r\n", lastValue);

            return log;
        }

        private void updateChart()
        {
            drawChart(plotData.ToList(), chart1);
        }

        private void drawChart(List<KeyValuePair<int, double>> plotData, Chart chart)
        {
            try
            {
                chart.Series.Clear();
                Series mySeriesOfPoint = new Series("Series1", plotData.Count());
                mySeriesOfPoint.ChartType = SeriesChartType.Line;
                mySeriesOfPoint.ChartArea = "ChartArea1";
                mySeriesOfPoint.BorderWidth = 3;

                ChartArea ca = chart.ChartAreas[0];
                ca.AxisX.IsLabelAutoFit = false;

                double? YAxisMin = null;
                double? YAxisMax = null;
                foreach (KeyValuePair<int, double> data in plotData)
                {
                    if (!YAxisMin.HasValue) YAxisMin = data.Value;
                    if (!YAxisMax.HasValue) YAxisMax = data.Value;

                    var point = mySeriesOfPoint.Points.AddXY(data.Key, data.Value);
                    if (data.Value < YAxisMin) YAxisMin = data.Value;
                    if (data.Value > YAxisMax) YAxisMax = data.Value;
                }
                chart.Series.Add(mySeriesOfPoint);

                if (!YAxisMin.HasValue) YAxisMin = 0;
                if (!YAxisMax.HasValue) YAxisMax = 0;
                if (YAxisMax.Value == YAxisMin.Value) YAxisMax += 1;
                ca.AxisY.Maximum = YAxisMax.Value;
                ca.AxisY.Minimum = YAxisMin.Value;
                ca.RecalculateAxesScale();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Возникла ошибка при построении графика ({0})", ex.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
