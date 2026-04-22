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
            chartArea1.Name = "ChartArea1";
            IndicatorsChart.ChartAreas.Add(chartArea1);
            IndicatorsChart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            IndicatorsChart.Legends.Add(legend1);
            IndicatorsChart.Location = new Point(0, 0);
            IndicatorsChart.Margin = new Padding(3, 2, 3, 2);
            IndicatorsChart.Name = "IndicatorsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            IndicatorsChart.Series.Add(series1);
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 56);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(45, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "№1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 79);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(45, 19);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "№2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 101);
            checkBox3.Margin = new Padding(3, 2, 3, 2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(45, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "№3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 124);
            checkBox4.Margin = new Padding(3, 2, 3, 2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(45, 19);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "№4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(12, 146);
            checkBox5.Margin = new Padding(3, 2, 3, 2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(45, 19);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "№5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(12, 169);
            checkBox6.Margin = new Padding(3, 2, 3, 2);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(45, 19);
            checkBox6.TabIndex = 7;
            checkBox6.Text = "№6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(12, 191);
            checkBox7.Margin = new Padding(3, 2, 3, 2);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(45, 19);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "№7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(12, 214);
            checkBox8.Margin = new Padding(3, 2, 3, 2);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(45, 19);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "№8";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(12, 238);
            checkBox9.Margin = new Padding(3, 2, 3, 2);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(45, 19);
            checkBox9.TabIndex = 7;
            checkBox9.Text = "№9";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(12, 328);
            checkBox10.Margin = new Padding(3, 2, 3, 2);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(51, 19);
            checkBox10.TabIndex = 7;
            checkBox10.Text = "№13";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(12, 260);
            checkBox11.Margin = new Padding(3, 2, 3, 2);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(51, 19);
            checkBox11.TabIndex = 7;
            checkBox11.Text = "№10";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(12, 350);
            checkBox12.Margin = new Padding(3, 2, 3, 2);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(51, 19);
            checkBox12.TabIndex = 7;
            checkBox12.Text = "№14";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(12, 283);
            checkBox13.Margin = new Padding(3, 2, 3, 2);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(51, 19);
            checkBox13.TabIndex = 7;
            checkBox13.Text = "№11";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(12, 373);
            checkBox14.Margin = new Padding(3, 2, 3, 2);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(51, 19);
            checkBox14.TabIndex = 7;
            checkBox14.Text = "№15";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(12, 305);
            checkBox15.Margin = new Padding(3, 2, 3, 2);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(51, 19);
            checkBox15.TabIndex = 7;
            checkBox15.Text = "№12";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(12, 395);
            checkBox16.Margin = new Padding(3, 2, 3, 2);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(51, 19);
            checkBox16.TabIndex = 7;
            checkBox16.Text = "№16";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // panelforDatchichk
            // 
            panelforDatchichk.Controls.Add(label1);
            panelforDatchichk.Controls.Add(checkBox1);
            panelforDatchichk.Controls.Add(checkBox16);
            panelforDatchichk.Controls.Add(checkBox5);
            panelforDatchichk.Controls.Add(checkBox8);
            panelforDatchichk.Controls.Add(checkBox9);
            panelforDatchichk.Controls.Add(checkBox15);
            panelforDatchichk.Controls.Add(checkBox2);
            panelforDatchichk.Controls.Add(checkBox4);
            panelforDatchichk.Controls.Add(checkBox10);
            panelforDatchichk.Controls.Add(checkBox14);
            panelforDatchichk.Controls.Add(checkBox11);
            panelforDatchichk.Controls.Add(checkBox7);
            panelforDatchichk.Controls.Add(checkBox6);
            panelforDatchichk.Controls.Add(checkBox13);
            panelforDatchichk.Controls.Add(checkBox12);
            panelforDatchichk.Controls.Add(checkBox3);
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
        private Panel panelforDatchichk;
        private Panel panelXZ;
        private Panel panel1;
        private Splitter splittertwo;
    }
}