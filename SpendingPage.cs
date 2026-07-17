using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileAppDesign
{
    public partial class SpendingPage : Form
    {
        public SpendingPage()
        {
            InitializeComponent();
            dgvExpensesHistory.DataSource = ExpenseManager.Expenses;
            lblWelcome.Text = "Good Day, " + AppData.Username + "!";

            FormatGrid();
        }
        private void FormatGrid()
        {
            // Forces columns to fill the empty space evenly
            dgvExpensesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Prevents the user from typing directly into the grid or adding blank rows
            dgvExpensesHistory.AllowUserToAddRows = false;
            dgvExpensesHistory.ReadOnly = true;

            // Ensures clicking a cell selects the whole row for easy deletion
            dgvExpensesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GoalPage goal = new GoalPage();
            goal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Ensure the user actually selected a row
            if (dgvExpensesHistory.SelectedRows.Count > 0)
            {
                // Grab the specific Expense object attached to the selected row
                var selectedRow = dgvExpensesHistory.SelectedRows[0];
                var expenseToDelete = (Expense)selectedRow.DataBoundItem;

                // REMOVED: AppData.CurrentBalance += expenseToDelete.Amount;
                // We no longer touch the AppData totals here.

                // Remove it from the list (the grid will update automatically)
                ExpenseManager.Expenses.Remove(expenseToDelete);
            }
            else
            {
                MessageBox.Show("Please select an expense to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Confirm with the user before wiping data
            DialogResult result = MessageBox.Show("Are you sure you want to delete all expense history?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // 1. Wipe the list
                ExpenseManager.Expenses.Clear();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }
    }
}