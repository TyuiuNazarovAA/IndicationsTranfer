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
            panelforDatchichk = new Panel();
            panelXZ = new Panel();
            splittertwo = new Splitter();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)IndicatorsChart).BeginInit();
            panelforDatchichk.SuspendLayout();
            panelXZ.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // IndicatorsChart
            // 
            chartArea2.Name = "ChartArea1";
            IndicatorsChart.ChartAreas.Add(chartArea2);
            IndicatorsChart.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            IndicatorsChart.Legends.Add(legend2);
            IndicatorsChart.Location = new Point(0, 0);
            IndicatorsChart.Margin = new Padding(3, 2, 3, 2);
            IndicatorsChart.Name = "IndicatorsChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            IndicatorsChart.Series.Add(series2);
            IndicatorsChart.Size = new Size(1112, 488);
            IndicatorsChart.TabIndex = 0;
            IndicatorsChart.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Датчики";
            // 
            // GraphicsBuild_Button
            // 
            GraphicsBuild_Button.Anchor = AnchorStyles.Right;
            GraphicsBuild_Button.Location = new Point(1017, 11);
            GraphicsBuild_Button.Margin = new Padding(3, 2, 3, 2);
            GraphicsBuild_Button.Name = "GraphicsBuild_Button";
            GraphicsBuild_Button.Size = new Size(168, 43);
            GraphicsBuild_Button.TabIndex = 2;
            GraphicsBuild_Button.Text = "Построить график";
            GraphicsBuild_Button.UseVisualStyleBackColor = true;
            GraphicsBuild_Button.Click += GraphicsBuild_Button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 5;
            label2.Text = "От";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 72);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 5;
            label3.Text = "до";
            // 
            // DateFrom
            // 
            DateFrom.Location = new Point(59, 70);
            DateFrom.Margin = new Padding(3, 2, 3, 2);
            DateFrom.Mask = "00.00.0000 00:00:00";
            DateFrom.Name = "DateFrom";
            DateFrom.Size = new Size(162, 23);
            DateFrom.TabIndex = 6;
            // 
            // DateTo
            // 
            DateTo.Location = new Point(264, 70);
            DateTo.Margin = new Padding(3, 2, 3, 2);
            DateTo.Mask = "00.00.0000 00:00:00";
            DateTo.Name = "DateTo";
            DateTo.Size = new Size(152, 23);
            DateTo.TabIndex = 6;
            // 
            // ResetDateRange_Button
            // 
            ResetDateRange_Button.Location = new Point(436, 66);
            ResetDateRange_Button.Margin = new Padding(3, 2, 3, 2);
            ResetDateRange_Button.Name = "ResetDateRange_Button";
            ResetDateRange_Button.Size = new Size(161, 29);
            ResetDateRange_Button.TabIndex = 2;
            ResetDateRange_Button.Text = "Сбросить ограничения";
            ResetDateRange_Button.UseVisualStyleBackColor = true;
            ResetDateRange_Button.Click += ResetDateRange_Button_Click;
            // 
            // ind1
            // 
            ind1.AutoSize = true;
            ind1.Location = new Point(12, 56);
            ind1.Margin = new Padding(3, 2, 3, 2);
            ind1.Name = "ind1";
            ind1.Size = new Size(45, 19);
            ind1.TabIndex = 7;
            ind1.Text = "№1";
            ind1.UseVisualStyleBackColor = true;
            // 
            // ind2
            // 
            ind2.AutoSize = true;
            ind2.Location = new Point(12, 79);
            ind2.Margin = new Padding(3, 2, 3, 2);
            ind2.Name = "ind2";
            ind2.Size = new Size(45, 19);
            ind2.TabIndex = 7;
            ind2.Text = "№2";
            ind2.UseVisualStyleBackColor = true;
            // 
            // ind3
            // 
            ind3.AutoSize = true;
            ind3.Location = new Point(12, 101);
            ind3.Margin = new Padding(3, 2, 3, 2);
            ind3.Name = "ind3";
            ind3.Size = new Size(45, 19);
            ind3.TabIndex = 7;
            ind3.Text = "№3";
            ind3.UseVisualStyleBackColor = true;
            // 
            // ind4
            // 
            ind4.AutoSize = true;
            ind4.Location = new Point(12, 124);
            ind4.Margin = new Padding(3, 2, 3, 2);
            ind4.Name = "ind4";
            ind4.Size = new Size(45, 19);
            ind4.TabIndex = 7;
            ind4.Text = "№4";
            ind4.UseVisualStyleBackColor = true;
            // 
            // ind5
            // 
            ind5.AutoSize = true;
            ind5.Location = new Point(12, 146);
            ind5.Margin = new Padding(3, 2, 3, 2);
            ind5.Name = "ind5";
            ind5.Size = new Size(45, 19);
            ind5.TabIndex = 7;
            ind5.Text = "№5";
            ind5.UseVisualStyleBackColor = true;
            // 
            // ind6
            // 
            ind6.AutoSize = true;
            ind6.Location = new Point(12, 169);
            ind6.Margin = new Padding(3, 2, 3, 2);
            ind6.Name = "ind6";
            ind6.Size = new Size(45, 19);
            ind6.TabIndex = 7;
            ind6.Text = "№6";
            ind6.UseVisualStyleBackColor = true;
            // 
            // ind7
            // 
            ind7.AutoSize = true;
            ind7.Location = new Point(12, 191);
            ind7.Margin = new Padding(3, 2, 3, 2);
            ind7.Name = "ind7";
            ind7.Size = new Size(45, 19);
            ind7.TabIndex = 7;
            ind7.Text = "№7";
            ind7.UseVisualStyleBackColor = true;
            // 
            // ind8
            // 
            ind8.AutoSize = true;
            ind8.Location = new Point(12, 214);
            ind8.Margin = new Padding(3, 2, 3, 2);
            ind8.Name = "ind8";
            ind8.Size = new Size(45, 19);
            ind8.TabIndex = 7;
            ind8.Text = "№8";
            ind8.UseVisualStyleBackColor = true;
            // 
            // ind9
            // 
            ind9.AutoSize = true;
            ind9.Location = new Point(12, 238);
            ind9.Margin = new Padding(3, 2, 3, 2);
            ind9.Name = "ind9";
            ind9.Size = new Size(45, 19);
            ind9.TabIndex = 7;
            ind9.Text = "№9";
            ind9.UseVisualStyleBackColor = true;
            // 
            // ind13
            // 
            ind13.AutoSize = true;
            ind13.Location = new Point(12, 328);
            ind13.Margin = new Padding(3, 2, 3, 2);
            ind13.Name = "ind13";
            ind13.Size = new Size(51, 19);
            ind13.TabIndex = 7;
            ind13.Text = "№13";
            ind13.UseVisualStyleBackColor = true;
            // 
            // ind10
            // 
            ind10.AutoSize = true;
            ind10.Location = new Point(12, 260);
            ind10.Margin = new Padding(3, 2, 3, 2);
            ind10.Name = "ind10";
            ind10.Size = new Size(51, 19);
            ind10.TabIndex = 7;
            ind10.Text = "№10";
            ind10.UseVisualStyleBackColor = true;
            // 
            // ind14
            // 
            ind14.AutoSize = true;
            ind14.Location = new Point(12, 350);
            ind14.Margin = new Padding(3, 2, 3, 2);
            ind14.Name = "ind14";
            ind14.Size = new Size(51, 19);
            ind14.TabIndex = 7;
            ind14.Text = "№14";
            ind14.UseVisualStyleBackColor = true;
            // 
            // ind11
            // 
            ind11.AutoSize = true;
            ind11.Location = new Point(12, 283);
            ind11.Margin = new Padding(3, 2, 3, 2);
            ind11.Name = "ind11";
            ind11.Size = new Size(51, 19);
            ind11.TabIndex = 7;
            ind11.Text = "№11";
            ind11.UseVisualStyleBackColor = true;
            // 
            // ind15
            // 
            ind15.AutoSize = true;
            ind15.Location = new Point(12, 373);
            ind15.Margin = new Padding(3, 2, 3, 2);
            ind15.Name = "ind15";
            ind15.Size = new Size(51, 19);
            ind15.TabIndex = 7;
            ind15.Text = "№15";
            ind15.UseVisualStyleBackColor = true;
            // 
            // ind12
            // 
            ind12.AutoSize = true;
            ind12.Location = new Point(12, 305);
            ind12.Margin = new Padding(3, 2, 3, 2);
            ind12.Name = "ind12";
            ind12.Size = new Size(51, 19);
            ind12.TabIndex = 7;
            ind12.Text = "№12";
            ind12.UseVisualStyleBackColor = true;
            // 
            // ind16
            // 
            ind16.AutoSize = true;
            ind16.Location = new Point(12, 395);
            ind16.Margin = new Padding(3, 2, 3, 2);
            ind16.Name = "ind16";
            ind16.Size = new Size(51, 19);
            ind16.TabIndex = 7;
            ind16.Text = "№16";
            ind16.UseVisualStyleBackColor = true;
            // 
            // panelforDatchichk
            // 
            panelforDatchichk.Controls.Add(label1);
            panelforDatchichk.Controls.Add(ind1);
            panelforDatchichk.Controls.Add(ind16);
            panelforDatchichk.Controls.Add(ind5);
            panelforDatchichk.Controls.Add(ind8);
            panelforDatchichk.Controls.Add(ind9);
            panelforDatchichk.Controls.Add(ind12);
            panelforDatchichk.Controls.Add(ind2);
            panelforDatchichk.Controls.Add(ind4);
            panelforDatchichk.Controls.Add(ind13);
            panelforDatchichk.Controls.Add(ind15);
            panelforDatchichk.Controls.Add(ind10);
            panelforDatchichk.Controls.Add(ind7);
            panelforDatchichk.Controls.Add(ind6);
            panelforDatchichk.Controls.Add(ind11);
            panelforDatchichk.Controls.Add(ind14);
            panelforDatchichk.Controls.Add(ind3);
            panelforDatchichk.Dock = DockStyle.Right;
            panelforDatchichk.Location = new Point(1112, 0);
            panelforDatchichk.Name = "panelforDatchichk";
            panelforDatchichk.Size = new Size(85, 488);
            panelforDatchichk.TabIndex = 8;
            // 
            // panelXZ
            // 
            panelXZ.Controls.Add(splittertwo);
            panelXZ.Controls.Add(GraphicsBuild_Button);
            panelXZ.Controls.Add(ResetDateRange_Button);
            panelXZ.Controls.Add(label2);
            panelXZ.Controls.Add(label3);
            panelXZ.Controls.Add(DateTo);
            panelXZ.Controls.Add(DateFrom);
            panelXZ.Dock = DockStyle.Top;
            panelXZ.Location = new Point(0, 0);
            panelXZ.Name = "panelXZ";
            panelXZ.Size = new Size(1197, 107);
            panelXZ.TabIndex = 9;
            // 
            // splittertwo
            // 
            splittertwo.Dock = DockStyle.Bottom;
            splittertwo.Location = new Point(0, 104);
            splittertwo.Name = "splittertwo";
            splittertwo.Size = new Size(1197, 3);
            splittertwo.TabIndex = 7;
            splittertwo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(IndicatorsChart);
            panel1.Controls.Add(panelforDatchichk);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 488);
            panel1.TabIndex = 10;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 595);
            Controls.Add(panel1);
            Controls.Add(panelXZ);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1213, 634);
            Name = "GraphicsForm";
            Text = "GraphicsForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)IndicatorsChart).EndInit();
            panelforDatchichk.ResumeLayout(false);
            panelforDatchichk.PerformLayout();
            panelXZ.ResumeLayout(false);
            panelXZ.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel panelforDatchichk;
        private Panel panelXZ;
        private Panel panel1;
        private Splitter splittertwo;
    }
}