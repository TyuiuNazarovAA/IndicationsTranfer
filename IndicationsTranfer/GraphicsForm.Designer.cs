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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            IndicatorsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            GraphicsBuild_Button = new Button();
            label2 = new Label();
            label3 = new Label();
            DateFrom = new MaskedTextBox();
            DateTo = new MaskedTextBox();
            ResetDateRange_Button = new Button();
            ind1 = new CheckBox();
            ind2 = new CheckBox();
            ind3 = new CheckBox();
            ind4 = new CheckBox();
            ind5 = new CheckBox();
            ind6 = new CheckBox();
            ind7 = new CheckBox();
            ind8 = new CheckBox();
            ind9 = new CheckBox();
            ind13 = new CheckBox();
            ind10 = new CheckBox();
            ind14 = new CheckBox();
            ind11 = new CheckBox();
            ind15 = new CheckBox();
            ind12 = new CheckBox();
            ind16 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)IndicatorsChart).BeginInit();
            SuspendLayout();
            // 
            // IndicatorsChart
            // 
            chartArea1.Name = "ChartArea1";
            IndicatorsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            IndicatorsChart.Legends.Add(legend1);
            IndicatorsChart.Location = new Point(12, 165);
            IndicatorsChart.Name = "IndicatorsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            IndicatorsChart.Series.Add(series1);
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
            GraphicsBuild_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // ind1
            // 
            ind1.AutoSize = true;
            ind1.Location = new Point(1012, 39);
            ind1.Name = "ind1";
            ind1.Size = new Size(56, 24);
            ind1.TabIndex = 7;
            ind1.Text = "№1";
            ind1.UseVisualStyleBackColor = true;
            ind1.CheckedChanged += ind1_CheckedChanged;
            // 
            // ind2
            // 
            ind2.AutoSize = true;
            ind2.Location = new Point(1012, 69);
            ind2.Name = "ind2";
            ind2.Size = new Size(56, 24);
            ind2.TabIndex = 7;
            ind2.Text = "№2";
            ind2.UseVisualStyleBackColor = true;
            ind2.CheckedChanged += ind2_CheckedChanged;
            // 
            // ind3
            // 
            ind3.AutoSize = true;
            ind3.Location = new Point(1012, 99);
            ind3.Name = "ind3";
            ind3.Size = new Size(56, 24);
            ind3.TabIndex = 7;
            ind3.Text = "№3";
            ind3.UseVisualStyleBackColor = true;
            ind3.CheckedChanged += ind3_CheckedChanged;
            // 
            // ind4
            // 
            ind4.AutoSize = true;
            ind4.Location = new Point(1012, 129);
            ind4.Name = "ind4";
            ind4.Size = new Size(56, 24);
            ind4.TabIndex = 7;
            ind4.Text = "№4";
            ind4.UseVisualStyleBackColor = true;
            ind4.CheckedChanged += ind4_CheckedChanged;
            // 
            // ind5
            // 
            ind5.AutoSize = true;
            ind5.Location = new Point(1012, 159);
            ind5.Name = "ind5";
            ind5.Size = new Size(56, 24);
            ind5.TabIndex = 7;
            ind5.Text = "№5";
            ind5.UseVisualStyleBackColor = true;
            ind5.CheckedChanged += ind5_CheckedChanged;
            // 
            // ind6
            // 
            ind6.AutoSize = true;
            ind6.Location = new Point(1012, 189);
            ind6.Name = "ind6";
            ind6.Size = new Size(56, 24);
            ind6.TabIndex = 7;
            ind6.Text = "№6";
            ind6.UseVisualStyleBackColor = true;
            ind6.CheckedChanged += ind6_CheckedChanged;
            // 
            // ind7
            // 
            ind7.AutoSize = true;
            ind7.Location = new Point(1012, 219);
            ind7.Name = "ind7";
            ind7.Size = new Size(56, 24);
            ind7.TabIndex = 7;
            ind7.Text = "№7";
            ind7.UseVisualStyleBackColor = true;
            ind7.CheckedChanged += ind7_CheckedChanged;
            // 
            // ind8
            // 
            ind8.AutoSize = true;
            ind8.Location = new Point(1012, 249);
            ind8.Name = "ind8";
            ind8.Size = new Size(56, 24);
            ind8.TabIndex = 7;
            ind8.Text = "№8";
            ind8.UseVisualStyleBackColor = true;
            ind8.CheckedChanged += ind8_CheckedChanged;
            // 
            // ind9
            // 
            ind9.AutoSize = true;
            ind9.Location = new Point(1012, 281);
            ind9.Name = "ind9";
            ind9.Size = new Size(56, 24);
            ind9.TabIndex = 7;
            ind9.Text = "№9";
            ind9.UseVisualStyleBackColor = true;
            ind9.CheckedChanged += ind9_CheckedChanged;
            // 
            // ind13
            // 
            ind13.AutoSize = true;
            ind13.Location = new Point(1012, 401);
            ind13.Name = "ind13";
            ind13.Size = new Size(64, 24);
            ind13.TabIndex = 7;
            ind13.Text = "№13";
            ind13.UseVisualStyleBackColor = true;
            ind13.CheckedChanged += ind13_CheckedChanged;
            // 
            // ind10
            // 
            ind10.AutoSize = true;
            ind10.Location = new Point(1012, 311);
            ind10.Name = "ind10";
            ind10.Size = new Size(64, 24);
            ind10.TabIndex = 7;
            ind10.Text = "№10";
            ind10.UseVisualStyleBackColor = true;
            ind10.CheckedChanged += ind10_CheckedChanged;
            // 
            // ind14
            // 
            ind14.AutoSize = true;
            ind14.Location = new Point(1012, 431);
            ind14.Name = "ind14";
            ind14.Size = new Size(64, 24);
            ind14.TabIndex = 7;
            ind14.Text = "№14";
            ind14.UseVisualStyleBackColor = true;
            ind14.CheckedChanged += ind14_CheckedChanged;
            // 
            // ind11
            // 
            ind11.AutoSize = true;
            ind11.Location = new Point(1012, 341);
            ind11.Name = "ind11";
            ind11.Size = new Size(64, 24);
            ind11.TabIndex = 7;
            ind11.Text = "№11";
            ind11.UseVisualStyleBackColor = true;
            ind11.CheckedChanged += ind11_CheckedChanged;
            // 
            // ind15
            // 
            ind15.AutoSize = true;
            ind15.Location = new Point(1012, 461);
            ind15.Name = "ind15";
            ind15.Size = new Size(64, 24);
            ind15.TabIndex = 7;
            ind15.Text = "№15";
            ind15.UseVisualStyleBackColor = true;
            ind15.CheckedChanged += ind15_CheckedChanged;
            // 
            // ind12
            // 
            ind12.AutoSize = true;
            ind12.Location = new Point(1012, 371);
            ind12.Name = "ind12";
            ind12.Size = new Size(64, 24);
            ind12.TabIndex = 7;
            ind12.Text = "№12";
            ind12.UseVisualStyleBackColor = true;
            ind12.CheckedChanged += ind12_CheckedChanged;
            // 
            // ind16
            // 
            ind16.AutoSize = true;
            ind16.Location = new Point(1012, 491);
            ind16.Name = "ind16";
            ind16.Size = new Size(64, 24);
            ind16.TabIndex = 7;
            ind16.Text = "№16";
            ind16.UseVisualStyleBackColor = true;
            ind16.CheckedChanged += ind16_CheckedChanged;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 543);
            Controls.Add(ind16);
            Controls.Add(ind8);
            Controls.Add(ind12);
            Controls.Add(ind4);
            Controls.Add(ind15);
            Controls.Add(ind7);
            Controls.Add(ind11);
            Controls.Add(ind3);
            Controls.Add(ind14);
            Controls.Add(ind6);
            Controls.Add(ind10);
            Controls.Add(ind13);
            Controls.Add(ind2);
            Controls.Add(ind9);
            Controls.Add(ind5);
            Controls.Add(ind1);
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
        private CheckBox ind1;
        private CheckBox ind2;
        private CheckBox ind3;
        private CheckBox ind4;
        private CheckBox ind5;
        private CheckBox ind6;
        private CheckBox ind7;
        private CheckBox ind8;
        private CheckBox ind9;
        private CheckBox ind13;
        private CheckBox ind10;
        private CheckBox ind14;
        private CheckBox ind11;
        private CheckBox ind15;
        private CheckBox ind12;
        private CheckBox ind16;
    }
}