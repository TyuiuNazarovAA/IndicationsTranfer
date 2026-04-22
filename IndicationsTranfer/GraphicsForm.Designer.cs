namespace IndicationsTranfer
{
    partial class GraphicsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            IndicatorsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            GraphicsBuild_Button = new Button();
            label2 = new Label();
            label3 = new Label();
            DateFrom = new MaskedTextBox();
            DateTo = new MaskedTextBox();
            ResetDateRange_Button = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)IndicatorsChart).BeginInit();
            SuspendLayout();
            // 
            // IndicatorsChart
            // 
            chartArea2.Name = "ChartArea1";
            IndicatorsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            IndicatorsChart.Legends.Add(legend2);
            IndicatorsChart.Location = new Point(12, 165);
            IndicatorsChart.Name = "IndicatorsChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            IndicatorsChart.Series.Add(series2);
            IndicatorsChart.Size = new Size(979, 366);
            IndicatorsChart.TabIndex = 0;
            IndicatorsChart.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1012, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Датчики";
            // 
            // GraphicsBuild_Button
            // 
            GraphicsBuild_Button.Location = new Point(771, 39);
            GraphicsBuild_Button.Name = "GraphicsBuild_Button";
            GraphicsBuild_Button.Size = new Size(192, 57);
            GraphicsBuild_Button.TabIndex = 2;
            GraphicsBuild_Button.Text = "Построить график";
            GraphicsBuild_Button.UseVisualStyleBackColor = true;
            GraphicsBuild_Button.Click += GraphicsBuild_Button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 107);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 5;
            label2.Text = "От";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 107);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 5;
            label3.Text = "до";
            // 
            // DateFrom
            // 
            DateFrom.Location = new Point(69, 104);
            DateFrom.Mask = "00.00.0000 00:00:00";
            DateFrom.Name = "DateFrom";
            DateFrom.Size = new Size(185, 27);
            DateFrom.TabIndex = 6;
            // 
            // DateTo
            // 
            DateTo.Location = new Point(303, 104);
            DateTo.Mask = "00.00.0000 00:00:00";
            DateTo.Name = "DateTo";
            DateTo.Size = new Size(173, 27);
            DateTo.TabIndex = 6;
            // 
            // ResetDateRange_Button
            // 
            ResetDateRange_Button.Location = new Point(499, 98);
            ResetDateRange_Button.Name = "ResetDateRange_Button";
            ResetDateRange_Button.Size = new Size(184, 39);
            ResetDateRange_Button.TabIndex = 2;
            ResetDateRange_Button.Text = "Сбросить ограничения";
            ResetDateRange_Button.UseVisualStyleBackColor = true;
            ResetDateRange_Button.Click += ResetDateRange_Button_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1012, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "№1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(1012, 69);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 24);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "№2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(1012, 99);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(56, 24);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "№3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(1012, 129);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(56, 24);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "№4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(1012, 159);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(56, 24);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "№5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(1012, 189);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(56, 24);
            checkBox6.TabIndex = 7;
            checkBox6.Text = "№6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(1012, 219);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(56, 24);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "№7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(1012, 249);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(56, 24);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "№8";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(1012, 281);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(56, 24);
            checkBox9.TabIndex = 7;
            checkBox9.Text = "№9";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(1012, 401);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(64, 24);
            checkBox10.TabIndex = 7;
            checkBox10.Text = "№13";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(1012, 311);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(64, 24);
            checkBox11.TabIndex = 7;
            checkBox11.Text = "№10";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(1012, 431);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(64, 24);
            checkBox12.TabIndex = 7;
            checkBox12.Text = "№14";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(1012, 341);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(64, 24);
            checkBox13.TabIndex = 7;
            checkBox13.Text = "№11";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(1012, 461);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(64, 24);
            checkBox14.TabIndex = 7;
            checkBox14.Text = "№15";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(1012, 371);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(64, 24);
            checkBox15.TabIndex = 7;
            checkBox15.Text = "№12";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(1012, 491);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(64, 24);
            checkBox16.TabIndex = 7;
            checkBox16.Text = "№16";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 543);
            Controls.Add(checkBox16);
            Controls.Add(checkBox8);
            Controls.Add(checkBox15);
            Controls.Add(checkBox4);
            Controls.Add(checkBox14);
            Controls.Add(checkBox7);
            Controls.Add(checkBox13);
            Controls.Add(checkBox3);
            Controls.Add(checkBox12);
            Controls.Add(checkBox6);
            Controls.Add(checkBox11);
            Controls.Add(checkBox10);
            Controls.Add(checkBox2);
            Controls.Add(checkBox9);
            Controls.Add(checkBox5);
            Controls.Add(checkBox1);
            Controls.Add(IndicatorsChart);
            Controls.Add(DateTo);
            Controls.Add(DateFrom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ResetDateRange_Button);
            Controls.Add(GraphicsBuild_Button);
            Controls.Add(label1);
            Name = "GraphicsForm";
            Text = "GraphicsForm";
            ((System.ComponentModel.ISupportInitialize)IndicatorsChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart IndicatorsChart;
        private Label label1;
        private Button GraphicsBuild_Button;
        private Label label2;
        private Label label3;
        private MaskedTextBox DateFrom;
        private MaskedTextBox DateTo;
        private Button ResetDateRange_Button;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
    }
}