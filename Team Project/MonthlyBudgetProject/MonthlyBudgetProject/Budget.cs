using System;

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
        private double price;

        public string Expenses
        {
            get { return expenses; }
            set { expenses = value; }
        }

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