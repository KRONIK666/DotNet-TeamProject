using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace MonthlyBudgetProject
{
    public class Database : Budget
    {
        public static List<Database> GetExpenses()
        {
            List<Database> expenses = new List<Database>();
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"], true))
            {
                string line = reader.ReadLine();
                do
                {
                    string[] archive = line.Split('|');
                    expenses.Add(new Database()
                    {
                        Date = archive[0],
                        Expenses = archive[1],
                        Price = double.Parse(archive[2])
                    });
                    line = reader.ReadLine();
                } while (line != null);
            }
            return expenses;
        }
    }
}