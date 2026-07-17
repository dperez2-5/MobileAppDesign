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

   



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
      

        private void button2_Click_2(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            GoalPage goal = new GoalPage();
            goal.Show();
            this.Hide();
        }
    }
}