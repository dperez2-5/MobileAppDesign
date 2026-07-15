namespace MobileAppDesign
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            button2 = new Button();
            button6 = new Button();
            button7 = new Button();
            lblAllowance = new Label();
            txtBalance = new TextBox();
            txtCurrentBalance = new TextBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            lblWelcome = new Label();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            txtAddAllowance = new TextBox();
            pictureBox5 = new PictureBox();
            btnAddAllowance = new Button();
            groupBox3 = new GroupBox();
            pictureBox6 = new PictureBox();
            groupBox5 = new GroupBox();
            label9 = new Label();
            txtTotalExpenses = new TextBox();
            pictureBox7 = new PictureBox();
            dateTimePicker2 = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnAddExpense = new Button();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label14 = new Label();
            circleProgressBar1 = new ReaLTaiizor.Controls.CircleProgressBar();
            label3 = new Label();
            groupBox4 = new GroupBox();
            lblGoalName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(30, 194);
            button2.Name = "button2";
            button2.Size = new Size(215, 35);
            button2.TabIndex = 1;
            button2.Text = "🏠HOME";
            button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.CornflowerBlue;
            button6.Location = new Point(30, 296);
            button6.Name = "button6";
            button6.Size = new Size(215, 35);
            button6.TabIndex = 10;
            button6.Text = "🎯GOALS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.CornflowerBlue;
            button7.Location = new Point(30, 245);
            button7.Name = "button7";
            button7.Size = new Size(215, 35);
            button7.TabIndex = 11;
            button7.Text = "💳 SPENDING";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // lblAllowance
            // 
            lblAllowance.AutoSize = true;
            lblAllowance.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllowance.Location = new Point(137, 17);
            lblAllowance.Name = "lblAllowance";
            lblAllowance.Size = new Size(172, 25);
            lblAllowance.TabIndex = 17;
            lblAllowance.Text = "Weekly Allowance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(172, 40);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(130, 23);
            txtBalance.TabIndex = 18;
            txtBalance.Text = "0";
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Location = new Point(123, 49);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(183, 23);
            txtCurrentBalance.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(123, 18);
            label10.Name = "label10";
            label10.Size = new Size(145, 24);
            label10.TabIndex = 21;
            label10.Text = "Current Balance";
            label10.Click += label10_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(0, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10, 9, 10, 9);
            pictureBox2.Size = new Size(296, 900);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(104, 175);
            label11.Name = "label11";
            label11.Size = new Size(83, 19);
            label11.TabIndex = 25;
            label11.Text = "Main Menu";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.CornflowerBlue;
            label13.Location = new Point(69, 96);
            label13.Name = "label13";
            label13.Size = new Size(150, 41);
            label13.TabIndex = 27;
            label13.Text = "PesoWise";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(309, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 41);
            lblWelcome.TabIndex = 29;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.AliceBlue;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(229, -173);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1201, 313);
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSkyBlue;
            groupBox2.Controls.Add(txtAddAllowance);
            groupBox2.Controls.Add(txtBalance);
            groupBox2.Controls.Add(lblAllowance);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(btnAddAllowance);
            groupBox2.Location = new Point(332, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 105);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            // 
            // txtAddAllowance
            // 
            txtAddAllowance.Location = new Point(115, 75);
            txtAddAllowance.Name = "txtAddAllowance";
            txtAddAllowance.Size = new Size(105, 23);
            txtAddAllowance.TabIndex = 20;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 8);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 82);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // btnAddAllowance
            // 
            btnAddAllowance.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAllowance.Location = new Point(227, 75);
            btnAddAllowance.Name = "btnAddAllowance";
            btnAddAllowance.Size = new Size(75, 24);
            btnAddAllowance.TabIndex = 19;
            btnAddAllowance.Text = "add allowance";
            btnAddAllowance.UseVisualStyleBackColor = true;
            btnAddAllowance.Click += button1_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PowderBlue;
            groupBox3.Controls.Add(txtCurrentBalance);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(pictureBox6);
            groupBox3.Location = new Point(678, 174);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(320, 105);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 8);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(140, 97);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.SkyBlue;
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(txtTotalExpenses);
            groupBox5.Controls.Add(pictureBox7);
            groupBox5.Location = new Point(1025, 174);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(320, 105);
            groupBox5.TabIndex = 35;
            groupBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(142, 18);
            label9.Name = "label9";
            label9.Size = new Size(141, 24);
            label9.TabIndex = 36;
            label9.Text = "Total Expenses";
            // 
            // txtTotalExpenses
            // 
            txtTotalExpenses.Location = new Point(142, 54);
            txtTotalExpenses.Name = "txtTotalExpenses";
            txtTotalExpenses.ReadOnly = true;
            txtTotalExpenses.Size = new Size(172, 23);
            txtTotalExpenses.TabIndex = 37;
            txtTotalExpenses.Text = "0.00";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(-22, 8);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(204, 97);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 38;
            pictureBox7.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = Color.LightSteelBlue;
            dateTimePicker2.CalendarTitleBackColor = Color.LightSteelBlue;
            dateTimePicker2.CalendarTrailingForeColor = Color.LightSteelBlue;
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(91, 46);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(218, 21);
            dateTimePicker2.TabIndex = 40;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Lavender;
            groupBox1.Controls.Add(btnAddExpense);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(467, 324);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 317);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "📝 ADD NEW EXPENSE";
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(104, 255);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(122, 26);
            btnAddExpense.TabIndex = 42;
            btnAddExpense.Text = "➕Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(146, 209);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(122, 24);
            txtAmount.TabIndex = 43;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(146, 157);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(122, 24);
            txtDescription.TabIndex = 42;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Food", "Transportation", "School Expense", "Bills (House)", "Others" });
            cmbCategory.Location = new Point(146, 107);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(122, 26);
            cmbCategory.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 112);
            label7.Name = "label7";
            label7.Size = new Size(90, 18);
            label7.TabIndex = 3;
            label7.Text = "📖Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 163);
            label6.Name = "label6";
            label6.Size = new Size(105, 18);
            label6.TabIndex = 2;
            label6.Text = "✏️Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 215);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 1;
            label5.Text = "💰Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 46);
            label4.Name = "label4";
            label4.Size = new Size(61, 18);
            label4.TabIndex = 0;
            label4.Text = "🗓️Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(322, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(322, 16);
            label2.TabIndex = 44;
            label2.Text = "Let's make today a smart money day!";
            label2.Click += label2_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(92, 132);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(103, 15);
            label14.TabIndex = 45;
            label14.Text = "Allowance Tracker";
            // 
            // circleProgressBar1
            // 
            circleProgressBar1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            circleProgressBar1.Location = new Point(103, 54);
            circleProgressBar1.Maximum = 100L;
            circleProgressBar1.MinimumSize = new Size(100, 100);
            circleProgressBar1.Name = "circleProgressBar1";
            circleProgressBar1.PercentColor = Color.White;
            circleProgressBar1.ProgressColor1 = Color.MidnightBlue;
            circleProgressBar1.ProgressColor2 = Color.FromArgb(128, 255, 255);
            circleProgressBar1.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            circleProgressBar1.Size = new Size(263, 263);
            circleProgressBar1.TabIndex = 42;
            circleProgressBar1.Text = "circleProgressBar1";
            circleProgressBar1.Value = 80L;
            circleProgressBar1.Click += circleProgressBar1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 8);
            label3.Name = "label3";
            label3.Size = new Size(90, 29);
            label3.TabIndex = 0;
            label3.Text = "🎯Goal";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightCyan;
            groupBox4.Controls.Add(lblGoalName);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(circleProgressBar1);
            groupBox4.Location = new Point(878, 324);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(447, 317);
            groupBox4.TabIndex = 34;
            groupBox4.TabStop = false;
            // 
            // lblGoalName
            // 
            lblGoalName.AutoSize = true;
            lblGoalName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGoalName.Location = new Point(193, 12);
            lblGoalName.Name = "lblGoalName";
            lblGoalName.Size = new Size(124, 25);
            lblGoalName.TabIndex = 46;
            lblGoalName.Text = "lblGoalName";
            lblGoalName.Click += label1_Click;
            // 
            // HomePage
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1370, 749);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(lblWelcome);
            Controls.Add(groupBox1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "0";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button7;
        private Label lblAllowance;
        private TextBox txtBalance;
        private GroupBox groupBox1;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescription;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbCategory;
        private Label label8;
        private Button btnAddAllowance;
        private TextBox txtCurrentBalance;
        private Label label10;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label13;
        private Label lblWelcome;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private TextBox txtTotalExpenses;
        private Label label9;
        private DateTimePicker dateTimePicker2;
        private TextBox txtAmount;
        private TextBox txtAddAllowance;
        private Button btnAddExpense;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private TextBox textBox1;
        private Label label2;
        private Label label14;
        private ReaLTaiizor.Controls.CircleProgressBar circleProgressBar1;
        private Label label3;
        private GroupBox groupBox4;
        private Label lblGoalName;
    }
}