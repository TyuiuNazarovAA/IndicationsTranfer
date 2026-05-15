using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IndicationsTranfer
{
    public partial class GraphicsForm : Form
    {
        List<string> filePath;
        List<(List<DateTime>, List<double>[])> graphics;

        List<(List<DateTime>, List<double>[])> summerGraphics;
        List<(List<DateTime>, List<double>[])> winterGraphics;

        DateTime summerFrom;
        DateTime summerTo;
        DateTime winterFrom;
        DateTime winterTo;

        bool[] indicators;
        int globalYear;

        public GraphicsForm(List<string> filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            
            indicators = new bool[16];

            RefreshData();
        }

        private void RefreshData()
        {
            graphics = FileParser.Parse(filePath);

            globalYear = graphics.SelectMany(g => g.Item1).Max().Year;

            summerFrom = new DateTime(globalYear, 5, 1).AddMonths(1).AddDays(-1);
            summerTo = new DateTime(globalYear, 9, 1);

            winterFrom = new DateTime(globalYear - 1, 11, 1).AddMonths(1).AddDays(-1);
            winterTo = new DateTime(globalYear, 3, 1);

            summerGraphics = (from g in graphics
                                let d = g.Item1[0].AddYears(globalYear - g.Item1[0].Year)
                                where d >= summerFrom && d <= summerTo
                                select g).ToList();

            winterGraphics = (from g in graphics
                              let d = g.Item1[0].AddYears(g.Item1[0].Month <= 3 ? globalYear - g.Item1[0].Year + 1 : globalYear - g.Item1[0].Year)
                              where d >= winterFrom && d <= winterTo.AddYears(1)
                              select g).ToList();
        }

        private void GraphicsBuild_Button_Click(object sender, EventArgs e)
        {
            DateTime dateFrom;
            DateTime dateTo;

            if (IsWinterTime.Checked && winterGraphics.Count() == 0)
            {
                MessageBox.Show("Файлы с зимним периодом не были выбраны", "Отсутствие зимнего периода", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!IsWinterTime.Checked && summerGraphics.Count() == 0)
            {
                MessageBox.Show("Файлы с летним периодом не были выбраны", "Отсутствие летнего периода", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DateFrom.Text == "  ,     :  :" || DateTo.Text == "  ,     :  :")
            {

                (dateFrom, dateTo) = GetDateTimes();

                DateFrom.Text = $"{dateFrom.Day:D2},{dateFrom.Month:D2} {dateFrom.Hour:D2}:{dateFrom.Minute:D2}:{dateFrom.Second:D2}";

                DateTo.Text = $"{dateTo.Day:D2},{dateTo.Month:D2} {dateTo.Hour:D2}:{dateTo.Minute:D2}:{dateTo.Second:D2}";
            }
            else
            {
                (dateFrom, dateTo) = CalcDate();
            }

            IndicatorsChart.Series.Clear();

            RefreshData();

            if (IsWinterTime.Checked)
            {
                for (int p = 0; p < winterGraphics.Count; p++)
                {
                    var points = winterGraphics[p];

                    int currentYear = points.Item1[0].Year;

                    for (int i = 0; i < 16; i++)
                    {
                        if (indicators[i])
                        {
                            string graphName;

                            if (points.Item1[0].Month >= 11 && points.Item1[points.Item1.Count - 1].Month <= 3)
                                graphName = $"{currentYear}-{currentYear + 1} год Датчик №{i + 1} Файл №{p + 1}";
                            else
                                graphName = $"{currentYear} год Датчик №{i + 1} Файл №{p + 1}";

                            IndicatorsChart.Series.Add(graphName);
                            IndicatorsChart.Series[graphName].ChartType = SeriesChartType.Line;

                            for (int dateIndex = 0; dateIndex < points.Item1.Count; dateIndex++)
                            {
                                DateTime dateTime = points.Item1[dateIndex];

                                DateTime dateTimeEdited;
                                if (winterGraphics.Count > 1 && winterGraphics.SelectMany(points => points.Item1).Any(d => d.Month >= 11)
                                    && winterGraphics.SelectMany(points => points.Item1).Any(d => d.Month <= 3))
                                    dateTimeEdited = dateTime.AddYears(dateTime.Month <= 3 ? globalYear - dateTime.Year + 1 : globalYear - dateTime.Year);
                                else
                                    dateTimeEdited = dateTime.AddYears(globalYear - dateTime.Year);

                                if (dateTimeEdited >= dateFrom && dateTimeEdited <= dateTo)
                                {
                                    double temperatureValue = points.Item2[i][dateIndex];

                                    IndicatorsChart.Series[graphName].Points.AddXY(dateTimeEdited, temperatureValue);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int p = 0; p < summerGraphics.Count; p++)
                {
                    var points = summerGraphics[p];

                    int currentYear = points.Item1[0].Year;

                    for (int i = 0; i < 16; i++)
                    {
                        if (indicators[i])
                        {
                            string graphName = $"{currentYear} год Датчик №{i + 1} Файл №{p + 1}";

                            IndicatorsChart.Series.Add(graphName);
                            IndicatorsChart.Series[graphName].ChartType = SeriesChartType.Line;

                            for (int dateIndex = 0; dateIndex < points.Item1.Count; dateIndex++)
                            {
                                DateTime dateTime = points.Item1[dateIndex];

                                DateTime dateTimeEdited = dateTime.AddYears(globalYear - dateTime.Year);

                                if (dateTimeEdited >= dateFrom && dateTimeEdited <= dateTo)
                                {
                                    double temperatureValue = points.Item2[i][dateIndex];

                                    IndicatorsChart.Series[graphName].Points.AddXY(dateTimeEdited, temperatureValue);
                                }
                            }
                        }
                    }
                }
            }

             
        }
        public (DateTime, DateTime) GetDateTimes()
        {
            if (IsWinterTime.Checked)
            {
                DateTime from;
                DateTime to;

                if (winterGraphics.SelectMany(d => d.Item1).Where(dt => dt.Month >= 11).Count() != 0 &&
                    winterGraphics.SelectMany(d => d.Item1).Where(dt => dt.Month <= 3).Count() != 0)
                {
                    from = winterGraphics.SelectMany(d => d.Item1.Where(d => d.Month >= 11).Select(dt => dt.AddYears(globalYear - dt.Year))).Min();
                    to = winterGraphics.SelectMany(d => d.Item1.Where(d => d.Month <= 3).Select(dt => dt.AddYears(globalYear - dt.Year))).Max().AddYears(1);
                }
                else
                {
                    from = winterGraphics.SelectMany(d => d.Item1.Select(dt => dt.AddYears(globalYear - dt.Year))).Min();
                    to = winterGraphics.SelectMany(d => d.Item1.Select(dt => dt.AddYears(globalYear - dt.Year))).Max();
                }

                return (from, to);
            }
            else
            {
                DateTime from = summerGraphics.SelectMany(d => d.Item1).Min();
                DateTime to = summerGraphics.SelectMany(d => d.Item1).Max();

                return (from, to);
            }
        }
        private (DateTime, DateTime) GetMinAndMaxDates()
        {
            DateTime minDate = graphics.Select(file => file.Item1[0]).Min();
            DateTime maxDate = graphics.Select(file => file.Item1[file.Item1.Count - 1]).Max();

            return (minDate, maxDate);
        }
        public (DateTime, DateTime) CalcDate()
        {
            string[] dateFrom = DateFrom.Text.Split(" ")[0].Split(",");
            string[] dateTo = DateTo.Text.Split(" ")[0].Split(",");

            string[] timeFrom = DateFrom.Text.Split(" ")[1].Split(":");
            string[] timeTo = DateTo.Text.Split(" ")[1].Split(":");

            int monthFrom = Convert.ToInt32(dateFrom[1]);
            int dayFrom = Convert.ToInt32(dateFrom[0]);

            int hourFrom = Convert.ToInt32(timeFrom[0]);
            int minuteFrom = Convert.ToInt32(timeFrom[1]);
            int secondFrom = Convert.ToInt32(timeFrom[2]);


            int monthTo = Convert.ToInt32(dateTo[1]);
            int dayTo = Convert.ToInt32(dateTo[0]);

            int hourTo = Convert.ToInt32(timeTo[0]);
            int minuteTo = Convert.ToInt32(timeTo[1]);
            int secondTo = Convert.ToInt32(timeTo[0]);

            DateTime from;
            DateTime to;

            if (IsWinterTime.Checked && monthFrom > monthTo)
            {
                from = new DateTime(globalYear, monthFrom, dayFrom, hourFrom, minuteFrom, secondFrom);
                to = new DateTime(globalYear + 1, monthTo, dayTo, hourTo, minuteTo, secondTo);
            }
            else
            {
                from = new DateTime(globalYear, monthFrom, dayFrom, hourFrom, minuteFrom, secondFrom);
                to = new DateTime(globalYear, monthTo, dayTo, hourTo, minuteTo, secondTo);
            }

            return (from, to);
        }

        private void ResetDateRange_Button_Click(object sender, EventArgs e)
        {
            DateFrom.Text = "  ,     :  :";
            DateTo.Text = "  ,     :  :";
        }

        private void ind1_CheckedChanged(object sender, EventArgs e)
        {
            indicators[0] = ind1.Checked;
        }

        private void ind2_CheckedChanged(object sender, EventArgs e)
        {
            indicators[1] = ind2.Checked;
        }

        private void ind3_CheckedChanged(object sender, EventArgs e)
        {
            indicators[2] = ind3.Checked;
        }

        private void ind4_CheckedChanged(object sender, EventArgs e)
        {
            indicators[3] = ind4.Checked;
        }

        private void ind5_CheckedChanged(object sender, EventArgs e)
        {
            indicators[4] = ind5.Checked;
        }

        private void ind6_CheckedChanged(object sender, EventArgs e)
        {
            indicators[5] = ind6.Checked;
        }

        private void ind7_CheckedChanged(object sender, EventArgs e)
        {
            indicators[6] = ind7.Checked;
        }

        private void ind8_CheckedChanged(object sender, EventArgs e)
        {
            indicators[7] = ind8.Checked;
        }

        private void ind9_CheckedChanged(object sender, EventArgs e)
        {
            indicators[8] = ind9.Checked;
        }

        private void ind10_CheckedChanged(object sender, EventArgs e)
        {
            indicators[9] = ind10.Checked;
        }

        private void ind11_CheckedChanged(object sender, EventArgs e)
        {
            indicators[10] = ind11.Checked;
        }

        private void ind12_CheckedChanged(object sender, EventArgs e)
        {
            indicators[11] = ind12.Checked;
        }

        private void ind13_CheckedChanged(object sender, EventArgs e)
        {
            indicators[12] = ind13.Checked;
        }

        private void ind14_CheckedChanged(object sender, EventArgs e)
        {
            indicators[13] = ind14.Checked;
        }

        private void ind15_CheckedChanged(object sender, EventArgs e)
        {
            indicators[14] = ind15.Checked;
        }

        private void ind16_CheckedChanged(object sender, EventArgs e)
        {
            indicators[15] = ind16.Checked;
        }
    }
}
