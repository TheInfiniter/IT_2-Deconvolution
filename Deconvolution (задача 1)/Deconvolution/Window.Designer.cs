namespace Deconvolution
{
    partial class Deconvolution
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Button();
            this.amp1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disp3 = new System.Windows.Forms.TextBox();
            this.disp2 = new System.Windows.Forms.TextBox();
            this.disp1 = new System.Windows.Forms.TextBox();
            this.center3 = new System.Windows.Forms.TextBox();
            this.center2 = new System.Windows.Forms.TextBox();
            this.center1 = new System.Windows.Forms.TextBox();
            this.amp3 = new System.Windows.Forms.TextBox();
            this.amp2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ampH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dispH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.array = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StartStop_Animate = new System.Windows.Forms.Button();
            this.Animate_Timer = new System.Windows.Forms.Timer(this.components);
            this.lowBar = new System.Windows.Forms.StatusStrip();
            this.Iteration = new System.Windows.Forms.ToolStripStatusLabel();
            this.Functional = new System.Windows.Forms.ToolStripStatusLabel();
            this.SumSquare = new System.Windows.Forms.ToolStripStatusLabel();
            this.Reset = new System.Windows.Forms.Button();
            this.TimerIterateText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EpsilonText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NoiseText = new System.Windows.Forms.TextBox();
            this.SourceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ImpulseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ConvolChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImpulseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvolChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(272, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "График";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(767, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Импульсная характеристика";
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(847, 377);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(88, 56);
            this.Draw.TabIndex = 4;
            this.Draw.Text = "Графики";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // amp1
            // 
            this.amp1.Location = new System.Drawing.Point(119, 19);
            this.amp1.Name = "amp1";
            this.amp1.Size = new System.Drawing.Size(41, 22);
            this.amp1.TabIndex = 5;
            this.amp1.Text = "2,2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disp3);
            this.groupBox1.Controls.Add(this.disp2);
            this.groupBox1.Controls.Add(this.disp1);
            this.groupBox1.Controls.Add(this.center3);
            this.groupBox1.Controls.Add(this.center2);
            this.groupBox1.Controls.Add(this.center1);
            this.groupBox1.Controls.Add(this.amp3);
            this.groupBox1.Controls.Add(this.amp2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.amp1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(575, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 108);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры графика";
            // 
            // disp3
            // 
            this.disp3.Location = new System.Drawing.Point(213, 74);
            this.disp3.Name = "disp3";
            this.disp3.Size = new System.Drawing.Size(41, 22);
            this.disp3.TabIndex = 17;
            this.disp3.Text = "2,9";
            // 
            // disp2
            // 
            this.disp2.Location = new System.Drawing.Point(166, 74);
            this.disp2.Name = "disp2";
            this.disp2.Size = new System.Drawing.Size(41, 22);
            this.disp2.TabIndex = 16;
            this.disp2.Text = "3,2";
            // 
            // disp1
            // 
            this.disp1.Location = new System.Drawing.Point(119, 74);
            this.disp1.Name = "disp1";
            this.disp1.Size = new System.Drawing.Size(41, 22);
            this.disp1.TabIndex = 15;
            this.disp1.Text = "2,4";
            // 
            // center3
            // 
            this.center3.Location = new System.Drawing.Point(213, 47);
            this.center3.Name = "center3";
            this.center3.Size = new System.Drawing.Size(41, 22);
            this.center3.TabIndex = 14;
            this.center3.Text = "49";
            // 
            // center2
            // 
            this.center2.Location = new System.Drawing.Point(166, 47);
            this.center2.Name = "center2";
            this.center2.Size = new System.Drawing.Size(41, 22);
            this.center2.TabIndex = 13;
            this.center2.Text = "34";
            // 
            // center1
            // 
            this.center1.Location = new System.Drawing.Point(119, 47);
            this.center1.Name = "center1";
            this.center1.Size = new System.Drawing.Size(41, 22);
            this.center1.TabIndex = 12;
            this.center1.Text = "10";
            // 
            // amp3
            // 
            this.amp3.Location = new System.Drawing.Point(213, 19);
            this.amp3.Name = "amp3";
            this.amp3.Size = new System.Drawing.Size(41, 22);
            this.amp3.TabIndex = 11;
            this.amp3.Text = "2,6";
            // 
            // amp2
            // 
            this.amp2.Location = new System.Drawing.Point(166, 19);
            this.amp2.Name = "amp2";
            this.amp2.Size = new System.Drawing.Size(41, 22);
            this.amp2.TabIndex = 10;
            this.amp2.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дисперсия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Центр купола";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Амплитуда";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ampH);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dispH);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(575, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 90);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Имп. характеристика";
            // 
            // ampH
            // 
            this.ampH.Location = new System.Drawing.Point(119, 21);
            this.ampH.Name = "ampH";
            this.ampH.Size = new System.Drawing.Size(41, 22);
            this.ampH.TabIndex = 17;
            this.ampH.Text = "2";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Амплитуда";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dispH
            // 
            this.dispH.Location = new System.Drawing.Point(119, 49);
            this.dispH.Name = "dispH";
            this.dispH.Size = new System.Drawing.Size(41, 22);
            this.dispH.TabIndex = 15;
            this.dispH.Text = "7";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дисперсия";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(750, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Количество отсчетов";
            // 
            // array
            // 
            this.array.Location = new System.Drawing.Point(906, 480);
            this.array.Name = "array";
            this.array.Size = new System.Drawing.Size(41, 20);
            this.array.TabIndex = 8;
            this.array.Text = "60";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(260, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Свертка";
            // 
            // StartStop_Animate
            // 
            this.StartStop_Animate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartStop_Animate.Enabled = false;
            this.StartStop_Animate.Location = new System.Drawing.Point(941, 377);
            this.StartStop_Animate.Name = "StartStop_Animate";
            this.StartStop_Animate.Size = new System.Drawing.Size(94, 23);
            this.StartStop_Animate.TabIndex = 14;
            this.StartStop_Animate.Text = "начать";
            this.StartStop_Animate.UseVisualStyleBackColor = true;
            this.StartStop_Animate.Click += new System.EventHandler(this.StartStop_Animate_Click);
            // 
            // Animate_Timer
            // 
            this.Animate_Timer.Tick += new System.EventHandler(this.Animate_Timer_Tick);
            // 
            // lowBar
            // 
            this.lowBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lowBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Iteration,
            this.Functional,
            this.SumSquare});
            this.lowBar.Location = new System.Drawing.Point(0, 678);
            this.lowBar.Name = "lowBar";
            this.lowBar.Size = new System.Drawing.Size(1149, 22);
            this.lowBar.TabIndex = 15;
            this.lowBar.Text = "statusStrip1";
            // 
            // Iteration
            // 
            this.Iteration.Name = "Iteration";
            this.Iteration.Size = new System.Drawing.Size(0, 17);
            // 
            // Functional
            // 
            this.Functional.Name = "Functional";
            this.Functional.Size = new System.Drawing.Size(0, 17);
            // 
            // SumSquare
            // 
            this.SumSquare.Name = "SumSquare";
            this.SumSquare.Size = new System.Drawing.Size(0, 17);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(941, 410);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 23);
            this.Reset.TabIndex = 16;
            this.Reset.Text = "cброс";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // TimerIterateText
            // 
            this.TimerIterateText.Location = new System.Drawing.Point(906, 507);
            this.TimerIterateText.Name = "TimerIterateText";
            this.TimerIterateText.Size = new System.Drawing.Size(41, 20);
            this.TimerIterateText.TabIndex = 17;
            this.TimerIterateText.Text = "50";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(750, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Период анимации, мс";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(750, 533);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Точность (степень)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EpsilonText
            // 
            this.EpsilonText.Location = new System.Drawing.Point(906, 532);
            this.EpsilonText.Multiline = true;
            this.EpsilonText.Name = "EpsilonText";
            this.EpsilonText.Size = new System.Drawing.Size(41, 20);
            this.EpsilonText.TabIndex = 19;
            this.EpsilonText.Text = "-8";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(750, 560);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "Шум, %";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoiseText
            // 
            this.NoiseText.Location = new System.Drawing.Point(906, 559);
            this.NoiseText.Name = "NoiseText";
            this.NoiseText.Size = new System.Drawing.Size(41, 20);
            this.NoiseText.TabIndex = 21;
            this.NoiseText.Text = "0";
            // 
            // SourceChart
            // 
            chartArea1.AxisX.Interval = 6D;
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.SourceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SourceChart.Legends.Add(legend1);
            this.SourceChart.Location = new System.Drawing.Point(12, 77);
            this.SourceChart.Name = "SourceChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "Сигнал";
            series1.Name = "Source";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Новый";
            series2.Name = "Restored";
            this.SourceChart.Series.Add(series1);
            this.SourceChart.Series.Add(series2);
            this.SourceChart.Size = new System.Drawing.Size(557, 255);
            this.SourceChart.TabIndex = 23;
            this.SourceChart.Text = "Source_Graph";
            // 
            // ImpulseChart
            // 
            chartArea2.AxisX.Interval = 6D;
            chartArea2.Name = "ChartArea1";
            this.ImpulseChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ImpulseChart.Legends.Add(legend2);
            this.ImpulseChart.Location = new System.Drawing.Point(575, 77);
            this.ImpulseChart.Name = "ImpulseChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.LabelBorderWidth = 2;
            series3.Legend = "Legend1";
            series3.LegendText = "Импульс";
            series3.Name = "ImpulseGraph";
            this.ImpulseChart.Series.Add(series3);
            this.ImpulseChart.Size = new System.Drawing.Size(562, 255);
            this.ImpulseChart.TabIndex = 26;
            this.ImpulseChart.Text = "Source_Graph";
            // 
            // ConvolChart
            // 
            chartArea3.AxisX.Interval = 6D;
            chartArea3.Name = "ChartArea1";
            this.ConvolChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ConvolChart.Legends.Add(legend3);
            this.ConvolChart.Location = new System.Drawing.Point(12, 367);
            this.ConvolChart.Name = "ConvolChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.LabelBorderWidth = 2;
            series4.Legend = "Legend1";
            series4.LegendText = "Свертка";
            series4.Name = "Convolution";
            this.ConvolChart.Series.Add(series4);
            this.ConvolChart.Size = new System.Drawing.Size(557, 255);
            this.ConvolChart.TabIndex = 27;
            this.ConvolChart.Text = "Source_Graph";
            // 
            // Deconvolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1149, 700);
            this.Controls.Add(this.ConvolChart);
            this.Controls.Add(this.ImpulseChart);
            this.Controls.Add(this.SourceChart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NoiseText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EpsilonText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TimerIterateText);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.lowBar);
            this.Controls.Add(this.StartStop_Animate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.array);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deconvolution";
            this.Text = "Деконволюция";
            this.Load += new System.EventHandler(this.Deconvolution_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lowBar.ResumeLayout(false);
            this.lowBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImpulseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvolChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox amp1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox disp3;
        private System.Windows.Forms.TextBox disp2;
        private System.Windows.Forms.TextBox disp1;
        private System.Windows.Forms.TextBox center3;
        private System.Windows.Forms.TextBox center2;
        private System.Windows.Forms.TextBox center1;
        private System.Windows.Forms.TextBox amp3;
        private System.Windows.Forms.TextBox amp2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dispH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox array;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button StartStop_Animate;
        private System.Windows.Forms.Timer Animate_Timer;
        private System.Windows.Forms.StatusStrip lowBar;
        private System.Windows.Forms.ToolStripStatusLabel Iteration;
        private System.Windows.Forms.ToolStripStatusLabel Functional;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ToolStripStatusLabel SumSquare;
        private System.Windows.Forms.TextBox ampH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TimerIterateText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EpsilonText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NoiseText;
        private System.Windows.Forms.DataVisualization.Charting.Chart SourceChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ImpulseChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ConvolChart;
    }
}

