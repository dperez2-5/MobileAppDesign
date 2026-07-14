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

        public GoalPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveGoal_Click(object sender, EventArgs e)
        {
            double target;
            double saved;

            if (txtGoal.Text == "")
            {
                MessageBox.Show("Enter a goal.");
                return;
            }

            if (!double.TryParse(txtTargetAmount.Text, out target))
            {
                MessageBox.Show("Invalid target amount.");
                return;
            }

            if (!double.TryParse(txtSavedAmount.Text, out saved))
            {
                MessageBox.Show("Invalid saved amount.");
                return;
            }

            GoalPage.GoalName = txtGoal.Text;

            GoalPage.TargetAmount = target;

            GoalPage.SavedAmount = saved;

            GoalPage.TargetDate = dtpTargetDate.Value;

            int percent = (int)((saved / target) * 100);

            if (percent > 100)
                percent = 100;

            circleProgressBar1.Value = percent;

            circleProgressBar1.Text = percent + "%";

            MessageBox.Show("Goal Saved!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpendingPage spending = new SpendingPage();
            spending.Show();
            this.Close();
        }
    }
}
