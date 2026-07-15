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
        // A BindingList automatically tells the DataGridView to redraw when an item is added/removed!
        public static BindingList<Expense> Expenses { get; set; } = new BindingList<Expense>();

        public static void AddExpense(Expense expense)
        {
            Expenses.Add(expense);
        }
    }
}