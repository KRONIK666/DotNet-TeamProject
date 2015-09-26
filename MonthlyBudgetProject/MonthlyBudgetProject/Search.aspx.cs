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
            List<Database> expenses = Helpers.GetBooks();

            booksRepeater.DataSource = expenses;
            booksRepeater.DataBind();
        }

        protected void searchWeek_Click(object sender, EventArgs e)
        {
            string locale = "";
            DateTimeStyles styles = DateTimeStyles.AllowInnerWhite | DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite;
            DateTime inputDate;
            DateTime localDate = DateTime.Now;
            DateTimeOffset localDateOffset = DateTimeOffset.Now;
            int integerOffset;
            bool result = false;
        }

        protected void searchMonth_Click(object sender, EventArgs e)
        {
            string locale = "";
            DateTimeStyles styles = DateTimeStyles.AllowInnerWhite | DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite;
            DateTime inputDate;
            DateTime localDate = DateTime.Now;
            DateTimeOffset localDateOffset = DateTimeOffset.Now;
            int integerOffset;
            bool result = false;
        }

        protected void searchYear_Click(object sender, EventArgs e)
        {
            string locale = "";
            DateTimeStyles styles = DateTimeStyles.AllowInnerWhite | DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite;
            DateTime inputDate;
            DateTime localDate = DateTime.Now;
            DateTimeOffset localDateOffset = DateTimeOffset.Now;
            int integerOffset;
            bool result = false;
        }
    }
}