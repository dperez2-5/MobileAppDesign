using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppDesign
{
    public static class ExpenseManager
    {
        public static BindingList<Expense> Expenses { get; } = new BindingList<Expense>();

        public static void AddExpense(Expense expense)
        {
            Expenses.Add(expense);
        }

        public static void RemoveExpense(Expense expense)
        {
            Expenses.Remove(expense);
        }

        public static void ClearAll()
        {
            Expenses.Clear();
        }
    }
}
