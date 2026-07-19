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

        public HomePage()
        {
            InitializeComponent();



            lblWelcome1.Text = "Good Day, " + AppData.Username + "!";
            // Categories
            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Transportation");
            cmbCategory.Items.Add("School Expense");
            cmbCategory.Items.Add("Bills (House)");
            cmbCategory.Items.Add("Others");

            // Initial Values
            txtBalance.Text = AppData.TotalAllowance.ToString("0.00");
            txtCurrentBalance.Text = AppData.CurrentBalance.ToString("0.00");
            txtTotalExpenses.Text = AppData.TotalExpenses.ToString("0.00");

            // Display only
            txtBalance.ReadOnly = true;
            txtCurrentBalance.ReadOnly = true;
            txtTotalExpenses.ReadOnly = true;

            if (string.IsNullOrWhiteSpace(GoalPage.GoalName))
            {
                lblGoalName.Text = "No active goal";
                txtinspiration.Text = "";
            }
            else
            {
                lblGoalName.Text = GoalPage.GoalName;
                if (!string.IsNullOrWhiteSpace(GoalPage.InspirationQuote))
                {
                    // Adding quotation marks around the text for styling!
                    txtinspiration.Text = "\"" + GoalPage.InspirationQuote + "\"";
                }
                else
                {
                    txtinspiration.Text = ""; // Leave it blank if they didn't type a quote
                }

            }

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
            AppData.TotalAllowance += amount;
            AppData.CurrentBalance += amount;

            // Save state permanently
            PersistenceManager.Save();

            // Display
            txtBalance.Text = AppData.TotalAllowance.ToString("0.00");
            txtCurrentBalance.Text = AppData.CurrentBalance.ToString("0.00");

            // Reset
            txtAddAllowance.Clear();
            txtAddAllowance.Focus();

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            double expenseAmount = 0;
            double savingsAmount = 0;

            // Check what the user actually typed in
            bool isLoggingExpense = double.TryParse(txtAmount.Text, out expenseAmount) && expenseAmount > 0;
            bool isLoggingSavings = double.TryParse(txtSavings.Text, out savingsAmount) && savingsAmount > 0;

            if (!isLoggingExpense && !isLoggingSavings)
            {
                MessageBox.Show("Please enter an expense amount or a savings amount.");
                return;
            }

            // Check if they have enough money to do both
            if ((expenseAmount + savingsAmount) > AppData.CurrentBalance)
            {
                MessageBox.Show("Insufficient balance! You don't have enough to cover this.");
                return;
            }

            // --- 1. PROCESS EXPENSE ---
            if (isLoggingExpense)
            {
                if (cmbCategory.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please select a category and description for your expense.");
                    return;
                }

                AppData.TotalExpenses += expenseAmount;
                AppData.CurrentBalance -= expenseAmount;

                ExpenseManager.AddExpense(new Expense
                {
                    Date = DateTime.Now,
                    Category = cmbCategory.Text,
                    Description = txtDescription.Text,
                    Amount = expenseAmount
                });
            }

            // --- 2. PROCESS SAVINGS ---
            if (isLoggingSavings)
            {
                // Make sure they actually set a goal first!
                if (GoalPage.TargetAmount <= 0)
                {
                    MessageBox.Show("Please set up a Goal on the Goals page before saving money.");
                    return;
                }

                // Deduct from wallet, add to goal
                AppData.CurrentBalance -= savingsAmount;
                GoalPage.SavedAmount += savingsAmount;

                // Update the circular progress bar
                UpdateGoalProgress();
                MessageBox.Show($"Successfully saved {savingsAmount:0.00} towards your goal!");
            }

            // --- 3. UPDATE UI AND RESET ---
            txtTotalExpenses.Text = AppData.TotalExpenses.ToString("0.00");
            txtCurrentBalance.Text = AppData.CurrentBalance.ToString("0.00");

            // Save state permanently
            PersistenceManager.Save();

            // Clear fields
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
            txtAmount.Clear();
            txtSavings.Clear(); // Don't forget to clear the new savings box!
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
            // 1. If no goal is set, zero everything out
            if (GoalPage.TargetAmount <= 0)
            {
                circleProgressBar1.Value = 0;
                circleProgressBar1.Text = "0%";
                lblgoalprogress.Text = "₱0.00 / ₱0.00";

                // Default text for the duration label
                lblDuration.Text = "No active goal";
                return;
            }

            // 2. Calculate and update the circular progress bar
            int percent = (int)((GoalPage.SavedAmount / GoalPage.TargetAmount) * 100);

            if (percent > 100) percent = 100;
            if (percent < 0) percent = 0;

            circleProgressBar1.Value = percent;
            circleProgressBar1.Text = percent + "%";

            // 3. Format and display the absolute text progress
            lblgoalprogress.Text = $"₱{GoalPage.SavedAmount:N2} / ₱{GoalPage.TargetAmount:N0}";

            // ----------------------------------------------------
            // 4. CALCULATE AND DISPLAY DURATION
            // ----------------------------------------------------

            // Subtract current time from the target date to get the remaining time
            TimeSpan timeRemaining = GoalPage.TargetDate - DateTime.Now;

            // Check if the deadline has already passed
            if (timeRemaining.TotalSeconds <= 0)
            {
                lblDuration.Text = "Deadline reached!";
            }
            else
            {
                // Extract the whole days and remaining hours
                int days = timeRemaining.Days;
                int hours = timeRemaining.Hours;

                if (days > 0)
                {
                    lblDuration.Text = $"{days} Days, {hours} Hrs left";
                }
                else
                {
                    // If less than 24 hours are left, just show the hours
                    lblDuration.Text = $"{hours} Hrs left";
                }
            }
        }

        
    }
}
