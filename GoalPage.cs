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
    public partial class GoalPage : Form
    {
        public static string GoalName = "";
        public static double TargetAmount = 0;
        public static double SavedAmount = 0;
        public static System.DateTime TargetDate = System.DateTime.Today;
        public static string InspirationQuote = "";

        public GoalPage()
        {
            InitializeComponent();
            lblWelcome.Text = "Good Day, " + AppData.Username + "!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveGoal_Click(object sender, EventArgs e)
        {
            double target;

            if (txtGoal.Text == "")
            {
                MessageBox.Show("Enter a goal.");
                return;
            }

            if (!double.TryParse(txtTargetAmount.Text, out target) || target <= 0)
            {
                MessageBox.Show("Invalid target amount.");
                return;
            }

            // Assign values
            GoalPage.GoalName = txtGoal.Text;
            GoalPage.TargetAmount = target;

            // ARCHITECTURE FIX: A new goal always starts with 0 saved!
            GoalPage.SavedAmount = 0;
            GoalPage.TargetDate = dtpTargetDate.Value;
            GoalPage.InspirationQuote = txtinspiration.Text;

            // Reset progress bar to 0%
            circleProgressBar1.Value = 0;
            circleProgressBar1.Text = "0%";
            GoalPage.TargetDate = dtpTargetDate.Value;

            MessageBox.Show("Goal Saved!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SpendingPage spending = new SpendingPage();
            spending.Show();
            this.Close();
        }
    }
}
