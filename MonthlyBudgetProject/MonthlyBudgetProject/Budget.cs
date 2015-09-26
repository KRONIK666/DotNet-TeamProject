using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonthlyBudgetProject
{
    public class Budget
    {
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string expenses;
        public string Expenses
        {
            get { return expenses; }
            set { expenses = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.date, this.expenses, this.price);
        }
    }
}