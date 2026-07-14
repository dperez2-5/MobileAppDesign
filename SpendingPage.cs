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
            if (dgvExpensesHistory.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            Expense selected = (Expense)dgvExpensesHistory.CurrentRow.DataBoundItem;

            DialogResult confirm = MessageBox.Show(
                "Delete this expense?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                ExpenseManager.RemoveExpense(selected);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
            "Clear all expenses?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                ExpenseManager.ClearAll();
            }
        }
    }
}
