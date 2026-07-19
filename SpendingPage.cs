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
            lblWelcome.Text = "Good Day, " + AppData.Username + "!";

            FormatGrid();

            // Set the data source after setting up the styling to ensure correct binding
            dgvExpensesHistory.DataSource = null;
            dgvExpensesHistory.DataSource = ExpenseManager.Expenses;
        }

        private void FormatGrid()
        {
            // Forces columns to auto-generate
            dgvExpensesHistory.AutoGenerateColumns = true;

            // Forces columns to fill the empty space evenly
            dgvExpensesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Prevents the user from typing directly into the grid or adding blank rows
            dgvExpensesHistory.AllowUserToAddRows = false;
            dgvExpensesHistory.ReadOnly = true;

            // Ensures clicking a cell selects the whole row
            dgvExpensesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Styling to match the dark theme and guarantee text visibility
            dgvExpensesHistory.EnableHeadersVisualStyles = false;
            
            // Header style (dark background, white text)
            dgvExpensesHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(59, 71, 83);
            dgvExpensesHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvExpensesHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Default cell style (dark background, white text)
            dgvExpensesHistory.DefaultCellStyle.BackColor = Color.FromArgb(47, 57, 67);
            dgvExpensesHistory.DefaultCellStyle.ForeColor = Color.White;
            dgvExpensesHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(113, 100, 81);
            dgvExpensesHistory.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvExpensesHistory.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Alternating row style
            dgvExpensesHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(53, 64, 75);
            dgvExpensesHistory.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvExpensesHistory.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(113, 100, 81);
            dgvExpensesHistory.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Clean up left headers
            dgvExpensesHistory.RowHeadersVisible = false;
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