namespace ga
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cbExtremum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFunction = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudInitPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudMutationPossibility = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCrossPossibility = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMaxPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMinValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMaxEqualGenerations = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMaxGenerations = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nudCheckFunctionValue = new System.Windows.Forms.NumericUpDown();
            this.cbCheckWithFunctionValue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutationPossibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossPossibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEqualGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckFunctionValue)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 746);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cbCheckWithFunctionValue);
            this.splitContainer2.Panel1.Controls.Add(this.nudCheckFunctionValue);
            this.splitContainer2.Panel1.Controls.Add(this.cbExtremum);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.tbFunction);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.nudInitPopulationSize);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.nudMutationPossibility);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.nudCrossPossibility);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.nudMaxPopulationSize);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.nudMaxValue);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.nudMinValue);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.nudMaxEqualGenerations);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.nudMaxGenerations);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.btStart);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtLog);
            this.splitContainer2.Size = new System.Drawing.Size(324, 746);
            this.splitContainer2.SplitterDistance = 508;
            this.splitContainer2.TabIndex = 22;
            // 
            // cbExtremum
            // 
            this.cbExtremum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExtremum.FormattingEnabled = true;
            this.cbExtremum.Items.AddRange(new object[] {
            "Максимум",
            "Минимум"});
            this.cbExtremum.Location = new System.Drawing.Point(13, 389);
            this.cbExtremum.Name = "cbExtremum";
            this.cbExtremum.Size = new System.Drawing.Size(144, 21);
            this.cbExtremum.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Экстремум:";
            // 
            // tbFunction
            // 
            this.tbFunction.Location = new System.Drawing.Point(13, 350);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.Size = new System.Drawing.Size(287, 20);
            this.tbFunction.TabIndex = 41;
            this.tbFunction.Text = "Cos(x) / (1 + Exp(-x))";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Функция:";
            // 
            // nudInitPopulationSize
            // 
            this.nudInitPopulationSize.Location = new System.Drawing.Point(13, 233);
            this.nudInitPopulationSize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudInitPopulationSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudInitPopulationSize.Name = "nudInitPopulationSize";
            this.nudInitPopulationSize.Size = new System.Drawing.Size(120, 20);
            this.nudInitPopulationSize.TabIndex = 38;
            this.nudInitPopulationSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Начальный размер популяции:";
            // 
            // nudMutationPossibility
            // 
            this.nudMutationPossibility.DecimalPlaces = 2;
            this.nudMutationPossibility.Location = new System.Drawing.Point(13, 311);
            this.nudMutationPossibility.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMutationPossibility.Name = "nudMutationPossibility";
            this.nudMutationPossibility.Size = new System.Drawing.Size(120, 20);
            this.nudMutationPossibility.TabIndex = 36;
            this.nudMutationPossibility.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Вероятность мутации:";
            // 
            // nudCrossPossibility
            // 
            this.nudCrossPossibility.DecimalPlaces = 2;
            this.nudCrossPossibility.Location = new System.Drawing.Point(13, 272);
            this.nudCrossPossibility.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCrossPossibility.Name = "nudCrossPossibility";
            this.nudCrossPossibility.Size = new System.Drawing.Size(120, 20);
            this.nudCrossPossibility.TabIndex = 34;
            this.nudCrossPossibility.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Вероятность скрещивания:";
            // 
            // nudMaxPopulationSize
            // 
            this.nudMaxPopulationSize.Location = new System.Drawing.Point(13, 190);
            this.nudMaxPopulationSize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMaxPopulationSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMaxPopulationSize.Name = "nudMaxPopulationSize";
            this.nudMaxPopulationSize.Size = new System.Drawing.Size(120, 20);
            this.nudMaxPopulationSize.TabIndex = 32;
            this.nudMaxPopulationSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Максимальный размер популяции:";
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.DecimalPlaces = 2;
            this.nudMaxValue.Location = new System.Drawing.Point(13, 149);
            this.nudMaxValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMaxValue.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(120, 20);
            this.nudMaxValue.TabIndex = 30;
            this.nudMaxValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Интервал изменений хромосом, максимум:";
            // 
            // nudMinValue
            // 
            this.nudMinValue.DecimalPlaces = 2;
            this.nudMinValue.Location = new System.Drawing.Point(13, 110);
            this.nudMinValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMinValue.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudMinValue.Name = "nudMinValue";
            this.nudMinValue.Size = new System.Drawing.Size(120, 20);
            this.nudMinValue.TabIndex = 28;
            this.nudMinValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Интервал изменений хромосом, минимум:";
            // 
            // nudMaxEqualGenerations
            // 
            this.nudMaxEqualGenerations.Location = new System.Drawing.Point(13, 65);
            this.nudMaxEqualGenerations.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMaxEqualGenerations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxEqualGenerations.Name = "nudMaxEqualGenerations";
            this.nudMaxEqualGenerations.Size = new System.Drawing.Size(120, 20);
            this.nudMaxEqualGenerations.TabIndex = 26;
            this.nudMaxEqualGenerations.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Макс. кол-во поколений при постоянном значении ЦФ:";
            // 
            // nudMaxGenerations
            // 
            this.nudMaxGenerations.Location = new System.Drawing.Point(13, 26);
            this.nudMaxGenerations.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMaxGenerations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxGenerations.Name = "nudMaxGenerations";
            this.nudMaxGenerations.Size = new System.Drawing.Size(120, 20);
            this.nudMaxGenerations.TabIndex = 24;
            this.nudMaxGenerations.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Максимальное количество поколений:";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(13, 474);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 22;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(324, 234);
            this.txtLog.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(793, 746);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // nudCheckFunctionValue
            // 
            this.nudCheckFunctionValue.DecimalPlaces = 3;
            this.nudCheckFunctionValue.Location = new System.Drawing.Point(13, 439);
            this.nudCheckFunctionValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCheckFunctionValue.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudCheckFunctionValue.Name = "nudCheckFunctionValue";
            this.nudCheckFunctionValue.Size = new System.Drawing.Size(120, 20);
            this.nudCheckFunctionValue.TabIndex = 46;
            this.nudCheckFunctionValue.Value = new decimal(new int[] {
            6285,
            0,
            0,
            196608});
            this.nudCheckFunctionValue.ValueChanged += new System.EventHandler(this.nudFunctionValue_ValueChanged);
            this.nudCheckFunctionValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nudCheckFunctionValue_MouseClick);
            // 
            // cbCheckWithFunctionValue
            // 
            this.cbCheckWithFunctionValue.AutoSize = true;
            this.cbCheckWithFunctionValue.Location = new System.Drawing.Point(13, 416);
            this.cbCheckWithFunctionValue.Name = "cbCheckWithFunctionValue";
            this.cbCheckWithFunctionValue.Size = new System.Drawing.Size(212, 17);
            this.cbCheckWithFunctionValue.TabIndex = 47;
            this.cbCheckWithFunctionValue.Text = "Сверять с известным значение ЦФ:";
            this.cbCheckWithFunctionValue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 746);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Нахождение глобального экстремума";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudInitPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutationPossibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossPossibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEqualGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckFunctionValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cbExtremum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFunction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudInitPopulationSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudMutationPossibility;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCrossPossibility;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMaxPopulationSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMaxEqualGenerations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMaxGenerations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox cbCheckWithFunctionValue;
        private System.Windows.Forms.NumericUpDown nudCheckFunctionValue;
    }
}

