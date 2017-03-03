using System;
using System.Configuration;
using System.IO;

namespace MonthlyBudgetProject
{
    public partial class Search : System.Web.UI.Page
    {
        private double weeklySumCalculated = 0;
        private double monthlySumCalculated = 0;
        private double annualSumCalculated = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchWeek_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"], true))
            {
                string line = reader.ReadLine();

                do
                {
                    string[] sum = line.Split('|');

                    if (line == "25.10.2016 г.|Vacation|200")
                    {
                        weeklySumCalculated = (double.Parse(sum[2]) + double.Parse(sum[5]) + double.Parse(sum[11]) + double.Parse(sum[23]));

                        using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
                        {
                            writer.WriteLine(weeklySumCalculated);
                        }
                    }
                } while (line != null);
            }
        }

        protected void searchMonth_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"], true))
            {
                string line = reader.ReadLine();

                do
                {
                    string[] sum = line.Split('|');

                    if (line == "25.10.2016 г.|Vacation|200")
                    {
                        monthlySumCalculated = (double.Parse(sum[2]) + double.Parse(sum[5]) + double.Parse(sum[8]) + double.Parse(sum[11]) + double.Parse(sum[14]) + double.Parse(sum[17]) + double.Parse(sum[20])
                             + double.Parse(sum[23]) + double.Parse(sum[26]) + double.Parse(sum[29]));

                        using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
                        {
                            writer.WriteLine(monthlySumCalculated);
                        }
                    }
                } while (line != null);
            }
        }

        protected void searchYear_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"], true))
            {
                string line = reader.ReadLine();

                do
                {
                    string[] sum = line.Split('|');

                    if (line == "25.10.2016 г.|Vacation|200")
                    {
                        annualSumCalculated = (double.Parse(sum[2]) + double.Parse(sum[5]) + double.Parse(sum[8]) + double.Parse(sum[11]) + double.Parse(sum[14]) + double.Parse(sum[17]) + double.Parse(sum[20])
                             + double.Parse(sum[23]) + double.Parse(sum[26]) + double.Parse(sum[29]));

                        using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
                        {
                            writer.WriteLine(annualSumCalculated);
                        }
                    }
                } while (line != null);
            }
        }
    }
}