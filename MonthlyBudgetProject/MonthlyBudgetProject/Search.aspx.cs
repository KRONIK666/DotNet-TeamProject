using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonthlyBudgetProject
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void searchWeek_Click(object sender, EventArgs e)
        {
            Database.GetExpenses();
        }

        protected void searchMonth_Click(object sender, EventArgs e)
        {
            
        }

        protected void searchYear_Click(object sender, EventArgs e)
        {
            
        }
    }
}