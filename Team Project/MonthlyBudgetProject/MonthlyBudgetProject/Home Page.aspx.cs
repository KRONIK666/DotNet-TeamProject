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

        protected void calendar_SelectionChanged(object sender, EventArgs e)
        {
            if ((chooseExpense.SelectedIndex > 0) && (dateTxtBox.Text != ""))
            {
                submitBtn.Enabled = true;
            }
        }

        protected void chooseExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((chooseExpense.SelectedIndex > 0) && (dateTxtBox.Text != ""))
            {
                submitBtn.Enabled = true;
            }
            else if ((chooseExpense.SelectedIndex > 0) && (dateTxtBox.Text != ""))
            {
                submitBtn.Enabled = false;
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Budget expense = new Budget()
            {
                Date = DateTime.Parse(dateTxtBox.Text),
                Expenses = chooseExpense.SelectedValue,
                Price = double.Parse(priceTxtBox.Text)
            };

            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(expense);
            }
        }
    }
}