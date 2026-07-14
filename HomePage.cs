using Microsoft.VisualBasic.ApplicationServices;
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
 
    public partial class HomePage : Form
    {
        private string username;
        double totalAllowance = 0;
        double totalExpenses = 0;
        double currentBalance = 0;
        private string? user;

        public HomePage()
        {
            InitializeComponent();

            username = user;

            lblWelcome.Text = "Good Day, " + user + "!";
            // Categories
            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Transportation");
            cmbCategory.Items.Add("School Expense");
            cmbCategory.Items.Add("Bills (House)");
            cmbCategory.Items.Add("Others");

            // Initial Values
            txtBalance.Text = "0.00";
            txtCurrentBalance.Text = "0.00";
            txtTotalExpenses.Text = "0.00";

            // Display only
            txtBalance.ReadOnly = true;
            txtCurrentBalance.ReadOnly = true;
            txtTotalExpenses.ReadOnly = true;

            // Input textbox
            txtAddAllowance.Clear();
            UpdateGoalProgress();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            UserControl userControl = new UserControl();
            userControl.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SpendingPage spendingPage = new SpendingPage();
            spendingPage.Show();
            this.Hide();
        }


        private void label10_Click(object sender, EventArgs e)
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

            UpdateGoalProgress();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double amount;

            if (!double.TryParse(txtAddAllowance.Text, out amount))
            {
                MessageBox.Show("Please enter numerical value.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Allowance must be greater than zero.");
                return;
            }

            // Update values
            totalAllowance += amount;
            currentBalance += amount;

            // Display
            txtBalance.Text = totalAllowance.ToString("0.00");
            txtCurrentBalance.Text = currentBalance.ToString("0.00");

            // Reset
            txtAddAllowance.Clear();
            txtAddAllowance.Focus();

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            double amount;

            if (!double.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.");
                return;
            }

            if (amount > currentBalance)
            {
                MessageBox.Show("Insufficient balance.");
                return;
            }

            // Update totals
            totalExpenses += amount;
            currentBalance -= amount;

            // Display
            txtTotalExpenses.Text = totalExpenses.ToString("0.00");
            txtCurrentBalance.Text = currentBalance.ToString("0.00");

            // Reset fields
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
            txtAmount.Clear();

            txtDescription.Focus();
        }

        private void circleProgressBar1_Click(object sender, EventArgs e)
        {
            if (GoalPage.TargetAmount == 0)
            {
                circleProgressBar1.Value = 0;
                circleProgressBar1.Text = "0%";
                return;
            }

            int percent = (int)((GoalPage.SavedAmount / GoalPage.TargetAmount) * 100);

            if (percent > 100)
                percent = 100;

            circleProgressBar1.Value = percent;
            circleProgressBar1.Text = percent + "%";
        }
        private void UpdateGoalProgress()
        {
            if (GoalPage.TargetAmount <= 0)
            {
                circleProgressBar1.Value = 0;
                circleProgressBar1.Text = "0%";
                return;
            }

            int percent = (int)((GoalPage.SavedAmount / GoalPage.TargetAmount) * 100);

            if (percent > 100)
                percent = 100;

            if (percent < 0)
                percent = 0;

            circleProgressBar1.Value = percent;
            circleProgressBar1.Text = percent + "%";
        }
    }
}
