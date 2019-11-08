using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga
{
    public class Population
    {
        private List<Сhromosome> population;
        public double minValue { get; private set; }
        public double maxValue { get; private set; }
        public int maxPopulationSize { get; private set; }
        public double crossPossibility { get; private set; }
        public double mutationPossibility { get; private set; }
        public int roundVal { get; private set; } = 3;
        private Func<string, double, double> fitnessFunction;
        public string txtFunction { get; private set; }
        public int initPopulationSize { get; private set; }
        public bool isMaxExtremum { get; private set; }
        public int generation { get; protected set;  }
        public Population(double minValue, double maxValue, int maxPopulationSize, double crossPossibility, double mutationPossibility, 
                          int initPopulationSize, string txtFunction, Func<string, double, double> fitnessFunction, bool isMaxExtremum)
        {
            population = new List<Сhromosome>();
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.crossPossibility = crossPossibility;
            this.mutationPossibility = mutationPossibility;
            this.fitnessFunction = fitnessFunction;
            this.initPopulationSize = initPopulationSize;
            this.maxPopulationSize = maxPopulationSize;
            this.txtFunction = txtFunction;
            this.generation = 1;
            this.isMaxExtremum = isMaxExtremum;
            Init(initPopulationSize);
        }
        public void Add(double val)
        {
            double roundedVal = Math.Round(val, roundVal);
            double fitnessValue = fitnessFunction(txtFunction, val);
            if (!Double.IsNaN(fitnessValue))
            {
                Сhromosome nc = new Сhromosome(roundedVal, fitnessValue);

                bool alreadyExists = population.Any(x => x.value.Equals(roundedVal));
                if (!alreadyExists)
                {
                    population.Add(new Сhromosome(roundedVal, fitnessValue));
                }
            }
        }
        public void Init(int populationSize)
        {
            if (populationSize < 2)
            {
                throw new Exception("Too small population!");
            }

            for (int i = 0; i < populationSize; i++)
            {
                double randomNumber = Util.NextDouble(minValue, maxValue);
                Add(randomNumber);
            }
        }
        public List<Сhromosome> GetBestСhromosome()
        {
            return (GetBestСhromosome(1));
        }
        public List<Сhromosome> GetBestСhromosome(int cnt)
        {
            List<Сhromosome> sorted = new List<Сhromosome>();
            if (isMaxExtremum)
            {
                sorted = population.Where(x => x.isDead == false).OrderByDescending(o => o.fitness).Take(cnt).ToList();
            } else
            {
                sorted = population.Where(x => x.isDead == false).OrderBy(o => o.fitness).Take(cnt).ToList();
            }
            return sorted;
        }
        public List<Сhromosome> GetRandomСhromosome()
        {
            return (GetRandomСhromosome(1));
        }
        public List<Сhromosome> GetRandomСhromosome(int cnt)
        {
            List<Сhromosome> rnd = new List<Сhromosome>();
            List<Сhromosome> sorted = population.Where(x => x.isDead == false).ToList();

            for (int i = 0; i < cnt; i++)
            {
                int rn = Util.Next(sorted.Count-1);
                rnd.Add(sorted[rn]);
            }
            return rnd;
        }
        public void Cross()
        {
            var populationSnapshot = population.ToList();
            foreach (var chromosome in populationSnapshot)
            {
                if (Util.NextDouble() <= crossPossibility)
                {
                    int rn = Util.Next(populationSnapshot.Count - 1);
                    Cross(chromosome, populationSnapshot[rn]);
                }
            }
        }
        private void Cross(Сhromosome x, Сhromosome y)
        {
            double xy = Cross(x.value, y.value);
            Add(xy);
        }
        public void TestChromosomes()
        {
            foreach (Сhromosome Сhromosome in population)
            {
                if (Сhromosome.value < minValue || Сhromosome.value > maxValue)
                {
                    Сhromosome.isDead = true;
                }
            }
        }
        public void Selection()
        {
            List<Сhromosome> sorted = new List<Сhromosome>();
            if (isMaxExtremum)
            {
                sorted = population.OrderBy(o => o.isDead).ThenByDescending(o => o.fitness).Take(maxPopulationSize).ToList();
            } else
            {
                sorted = population.OrderBy(o => o.isDead).ThenBy(o => o.fitness).Take(maxPopulationSize).ToList();
            }
            population = sorted;
            generation++;
        }
        static protected Int64 BitCross(Int64 x, Int64 y)
        {
            int Count = Util.Next(62) + 1;
            Int64 mask = ~0;

            mask = mask << (64 - Count);

            return (x & mask) | (y & ~mask);
        }
        static protected Int64 Cross(Int64 x, Int64 y)
        {
            Int64 res = BitCross(x, y);
            if (Util.Next() % 2 == 0)
            {
                if (x * res < 0)
                {
                    res = -res;
                }
            }
            else
            {
                if (y * res < 0)
                {
                    res = -res;
                }
            }

            return res;
        }
        static protected double Cross(double x, double y)
        {
            Int64 ix = BitConverter.DoubleToInt64Bits(x);
            Int64 iy = BitConverter.DoubleToInt64Bits(y);

            double res = BitConverter.Int64BitsToDouble(BitCross(ix, iy));

            if (Util.Next() % 2 == 0)
            {
                if (x * res < 0)
                {
                    res = -res;
                }
            }
            else
            {
                if (y * res < 0)
                {
                    res = -res;
                }
            }

            return res;
        }
        public void Mutation()
        {
            var populationSnapshot = population.ToList();
            foreach (var chromosome in populationSnapshot)
            {
                if (Util.NextDouble() <= mutationPossibility)
                {
                    int rn = Util.Next(populationSnapshot.Count - 1);
                    Mutation(populationSnapshot[rn]);
                }
            }
        }
        private void Mutation(Сhromosome x)
        {
            double z = Mutation(x.value);
            Add(z);
        }
        static protected double Mutation(double val)
        {
            UInt64 x = BitConverter.ToUInt64(BitConverter.GetBytes(val), 0);

            UInt64 mask = 1;
            mask <<= Util.Next(63);
            x ^= mask;

            double res = BitConverter.ToDouble(BitConverter.GetBytes(x), 0);

            return res;
        }
        static protected Int64 Mutation(Int64 val)
        {
            Int64 mask = 1;
            mask <<= Util.Next(63);

            return val ^ mask;
        }
    }
}
