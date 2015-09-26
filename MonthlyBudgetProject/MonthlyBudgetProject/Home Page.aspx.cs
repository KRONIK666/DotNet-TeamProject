using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonthlyBudgetProject
{
    public partial class Home_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void chooseExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((chooseExpense.SelectedIndex !=0) && (calendar.SelectedDate.Year > 1)) 
            {
                submitBtn.Enabled = true;
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.Write(Date.Text + " " + calendar.SelectedDate + "|");
                writer.Write(Expense.Text + " " + chooseExpense.SelectedIndex + "|");
                writer.WriteLine(Price.Text + " " + priceTxtBox.Text);
            }
        }

        protected void calendar_SelectionChanged(object sender, EventArgs e)
        {
            if ((chooseExpense.SelectedIndex != 0) && (calendar.SelectedDate.Year > 1))
            {
                submitBtn.Enabled = true;
            }
        }
    }
}