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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IndicationsTranfer
{
    public partial class GraphicsForm : Form
    {
        string filePath;
        (List<DateTime>, List<double>[]) points;
        bool[] indicators;

        public GraphicsForm(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            points = FileParser.Parse(filePath);
        }

        private void GraphicsBuild_Button_Click(object sender, EventArgs e)
        {
            DateTime dateFrom;
            DateTime dateTo;

            if (DateFrom.Text == "  ,  ,       :  :" || DateTo.Text == "  ,  ,       :  :")
            {
                dateFrom = this.points.Item1[0];
                dateTo = this.points.Item1[this.points.Item1.Count - 1];

                DateFrom.Text = $"{dateFrom.Day:D2},{dateFrom.Month:D2},{dateFrom.Year:D4} {dateFrom.Hour:D2}:{dateFrom.Minute:D2}:{dateFrom.Second:D2}";
                DateTo.Text = $"{dateTo.Day:D2},{dateTo.Month:D2},{dateTo.Year:D4} {dateTo.Hour:D2}:{dateTo.Minute:D2}:{dateTo.Second:D2}";
            }
            else
            {
                (dateFrom, dateTo) = CalcDate();
            }

            IndicatorsChart.Series.Clear();

            (List<DateTime>, List<double>[]) points = FileParser.Parse(filePath);

            for (int i = 0; i < 16; i++)
            {
                IndicatorsChart.Series.Add(i.ToString());
                IndicatorsChart.Series[i.ToString()].ChartType = SeriesChartType.Line;
            }

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < points.Item1.Count; j++)
                {
                    DateTime dateTime = points.Item1[j];

                    if (dateFrom <= dateTime && dateTime <= dateTo)
                    {
                        double temperatureValue = points.Item2[i][j];

                        IndicatorsChart.Series[i.ToString()].Points.AddXY(dateTime, temperatureValue);
                    }
                }
            }
        }

        public (DateTime, DateTime) CalcDate()
        {
            string[] dateFrom = DateFrom.Text.Split(" ")[0].Split(",");
            string[] dateTo = DateTo.Text.Split(" ")[0].Split(",");

            string[] timeFrom = DateFrom.Text.Split(" ")[1].Split(":");
            string[] timeTo = DateTo.Text.Split(" ")[1].Split(":");

            int yearFrom = Convert.ToInt32(dateFrom[2]);
            int monthFrom = Convert.ToInt32(dateFrom[1]);
            int dayFrom = Convert.ToInt32(dateFrom[0]);

            int hourFrom = Convert.ToInt32(timeFrom[0]);
            int minuteFrom = Convert.ToInt32(timeFrom[1]);
            int secondFrom = Convert.ToInt32(timeFrom[2]);


            int yearTo = Convert.ToInt32(dateFrom[2]);
            int monthTo = Convert.ToInt32(dateFrom[1]);
            int dayTo = Convert.ToInt32(dateFrom[0]);

            int hourTo = Convert.ToInt32(timeTo[0]);
            int minuteTo = Convert.ToInt32(timeTo[1]);
            int secondTo = Convert.ToInt32(timeTo[0]);

            DateTime from = new DateTime(yearFrom, monthFrom, dayFrom, hourFrom, minuteFrom, secondFrom);
            DateTime to = new DateTime(yearTo, monthTo, dayTo, hourTo, minuteTo, secondTo);

            return (from, to);
        }

        private void ResetDateRange_Button_Click(object sender, EventArgs e)
        {
            DateFrom.Text = "  ,  ,       :  :";
            DateTo.Text = "  ,  ,       :  :";
        }
    }
}
