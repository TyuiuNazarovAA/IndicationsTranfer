using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndicationsTranfer
{
    public static class FileParser
    {
        public static (List<DateTime>, List<double>[]) Parse(string path)
        {
            int oldHours = 0;

            List<double>[] data = new List<double>[16];

            List<DateTime> dateTimes = new List<DateTime>();

            for (int i = 0; i < 16; i++)
            {
                data[i] = new List<double>();
            }

            int year = 0;
            int month = 0;
            int day = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line = "";
                int i = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i == 3)
                    {
                        string dateOnly = line.Substring(41, 10);
                        day = Convert.ToInt32(dateOnly.Split(".")[0]);
                        month = Convert.ToInt32(dateOnly.Split(".")[1]);
                        year = Convert.ToInt32(dateOnly.Split(".")[2]);
                    }
                    if (i >= 8)
                    {
                        DateTime dateTime = new DateTime();
                        string time = line.Split("\t")[0];

                        int hours = Convert.ToInt32(time.Split(":")[0]);
                        int minutes = Convert.ToInt32(time.Split(":")[1]);
                        int seconds = Convert.ToInt32(time.Split(":")[2]);

                        if (hours == 0 && oldHours == 23)
                            day++;

                        dateTimes.Add(new DateTime(year, month, day, hours, minutes, seconds));

                        oldHours = hours;

                        for (int j = 0; j < 16; j++)
                        {
                            string stringNumber = line.Substring(9).Split("\t").Where(i => i != "").ToArray()[j + 1];
                            data[j].Add(Convert.ToDouble(stringNumber));
                        }
                    }
                    i++;
                }
            }

            return (dateTimes, data);
        }
    }
}
