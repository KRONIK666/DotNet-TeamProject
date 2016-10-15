using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                    string[] expense = line.Split('|');

                    if (DateTime.Now.AddDays(-7) <= DateTime.Parse(expense[0]))
                    {
                        weeklySumCalculated += double.Parse(expense[2]);
                    }
                } while (line != null);
            }

            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(weeklySumCalculated);
            }
        }

        protected void searchMonth_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"], true))
            {
                string line = reader.ReadLine();
                do
                {
                    string[] expense = line.Split('|');

                    if (DateTime.Now.AddDays(-30) <= DateTime.Parse(expense[0]))
                    {
                        monthlySumCalculated += double.Parse(expense[2]);
                    }
                } while (line != null);
            }

            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(monthlySumCalculated);
            }
        }

        protected void searchYear_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"], true))
            {
                string line = reader.ReadLine();
                do
                {
                    string[] expense = line.Split('|');

                    if (DateTime.Now.AddDays(-365) <= DateTime.Parse(expense[0]))
                    {
                        annualSumCalculated += double.Parse(expense[2]);
                    }
                } while (line != null);
            }

            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(annualSumCalculated);
            }
        }
    }
}