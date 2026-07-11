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
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            lblAllowance = new Label();
            txtBalance = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            txtAddAllowance = new TextBox();
            btnAddAllowance = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            circleProgressBar1 = new ReaLTaiizor.Controls.CircleProgressBar();
            label3 = new Label();
            groupBox5 = new GroupBox();
            txtTotalExpenses = new TextBox();
            label9 = new Label();
            dateTimePicker2 = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnAddExpense = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(27, 195);
            button2.Name = "button2";
            button2.Size = new Size(215, 35);
            button2.TabIndex = 1;
            button2.Text = "HOME";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(27, 436);
            button4.Name = "button4";
            button4.Size = new Size(215, 35);
            button4.TabIndex = 9;
            button4.Text = "USER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(27, 295);
            button6.Name = "button6";
            button6.Size = new Size(215, 35);
            button6.TabIndex = 10;
            button6.Text = "GOALS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(27, 244);
            button7.Name = "button7";
            button7.Size = new Size(215, 35);
            button7.TabIndex = 11;
            button7.Text = "SPENDING";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // lblAllowance
            // 
            lblAllowance.AutoSize = true;
            lblAllowance.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAllowance.Location = new Point(6, 19);
            lblAllowance.Name = "lblAllowance";
            lblAllowance.Size = new Size(157, 21);
            lblAllowance.TabIndex = 17;
            lblAllowance.Text = "Weekly Allowance";
            lblAllowance.Click += label2_Click;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(35, 53);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(97, 23);
            txtBalance.TabIndex = 18;
            txtBalance.Text = "0";
            txtBalance.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(139, 21);
            label10.TabIndex = 21;
            label10.Text = "Current Balance";
            label10.Click += label10_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(-3, -14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(297, 901);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(27, 164);
            label11.Name = "label11";
            label11.Size = new Size(87, 18);
            label11.TabIndex = 25;
            label11.Text = "Main Menu";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label12.Location = new Point(27, 393);
            label12.Name = "label12";
            label12.Size = new Size(66, 21);
            label12.TabIndex = 26;
            label12.Text = "Account";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(138, 77);
            label13.Name = "label13";
            label13.Size = new Size(104, 26);
            label13.TabIndex = 27;
            label13.Text = "PesoWise";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB Demi", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 55);
            label1.Name = "label1";
            label1.Size = new Size(853, 27);
            label1.TabIndex = 29;
            label1.Text = "Good Morning, User(i code ra nato ang unsa na user i butang kay mu display)";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(226, -174);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1201, 313);
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSteelBlue;
            groupBox2.Controls.Add(txtAddAllowance);
            groupBox2.Controls.Add(btnAddAllowance);
            groupBox2.Controls.Add(lblAllowance);
            groupBox2.Controls.Add(txtBalance);
            groupBox2.Location = new Point(332, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 105);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            // 
            // txtAddAllowance
            // 
            txtAddAllowance.Location = new Point(176, 19);
            txtAddAllowance.Name = "txtAddAllowance";
            txtAddAllowance.Size = new Size(118, 23);
            txtAddAllowance.TabIndex = 20;
            txtAddAllowance.TextChanged += textBox7_TextChanged;
            // 
            // btnAddAllowance
            // 
            btnAddAllowance.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAllowance.Location = new Point(143, 49);
            btnAddAllowance.Name = "btnAddAllowance";
            btnAddAllowance.Size = new Size(96, 33);
            btnAddAllowance.TabIndex = 19;
            btnAddAllowance.Text = "add allowance";
            btnAddAllowance.UseVisualStyleBackColor = true;
            btnAddAllowance.Click += button1_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightSteelBlue;
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(678, 174);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(320, 105);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightSteelBlue;
            groupBox4.Controls.Add(circleProgressBar1);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(891, 324);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(243, 173);
            groupBox4.TabIndex = 34;
            groupBox4.TabStop = false;
            // 
            // circleProgressBar1
            // 
            circleProgressBar1.Font = new Font("Segoe UI", 15F);
            circleProgressBar1.Location = new Point(68, -3);
            circleProgressBar1.Maximum = 100L;
            circleProgressBar1.MinimumSize = new Size(100, 100);
            circleProgressBar1.Name = "circleProgressBar1";
            circleProgressBar1.PercentColor = Color.White;
            circleProgressBar1.ProgressColor1 = Color.FromArgb(128, 128, 255);
            circleProgressBar1.ProgressColor2 = Color.RoyalBlue;
            circleProgressBar1.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            circleProgressBar1.Size = new Size(175, 175);
            circleProgressBar1.TabIndex = 42;
            circleProgressBar1.Text = "circleProgressBar1";
            circleProgressBar1.Value = 59L;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 7);
            label3.Name = "label3";
            label3.Size = new Size(58, 26);
            label3.TabIndex = 0;
            label3.Text = "Goal";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.LightSteelBlue;
            groupBox5.Controls.Add(txtTotalExpenses);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(1025, 174);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(320, 105);
            groupBox5.TabIndex = 35;
            groupBox5.TabStop = false;
            // 
            // txtTotalExpenses
            // 
            txtTotalExpenses.Location = new Point(61, 49);
            txtTotalExpenses.Name = "txtTotalExpenses";
            txtTotalExpenses.ReadOnly = true;
            txtTotalExpenses.Size = new Size(200, 23);
            txtTotalExpenses.TabIndex = 37;
            txtTotalExpenses.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 19);
            label9.Name = "label9";
            label9.Size = new Size(126, 21);
            label9.TabIndex = 36;
            label9.Text = "Total Expenses";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = Color.LightSteelBlue;
            dateTimePicker2.CalendarTitleBackColor = Color.LightSteelBlue;
            dateTimePicker2.CalendarTrailingForeColor = Color.LightSteelBlue;
            dateTimePicker2.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(98, 41);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 21);
            dateTimePicker2.TabIndex = 40;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(btnAddExpense);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(467, 324);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 311);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD NEW EXPENSE";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(129, 255);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(122, 24);
            txtAmount.TabIndex = 43;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(129, 175);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(122, 24);
            txtDescription.TabIndex = 42;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Food", "Transportation", "School Expense", "Bills (House)", "Others" });
            cmbCategory.Location = new Point(129, 104);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(122, 25);
            cmbCategory.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 112);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 3;
            label7.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 182);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 2;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 256);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 1;
            label5.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 45);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 0;
            label4.Text = "Date:";
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(129, 285);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(122, 23);
            btnAddExpense.TabIndex = 42;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1370, 749);
            Controls.Add(groupBox1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Name = "HomePage";
            Text = "0";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private PictureBox pictureBox1;
        private Button button4;
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
        private TextBox textBox2;
        private Label label10;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label1;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label3;
        private GroupBox groupBox5;
        private TextBox txtTotalExpenses;
        private Label label9;
        private DateTimePicker dateTimePicker2;
        private TextBox txtAmount;
        private ReaLTaiizor.Controls.CircleProgressBar circleProgressBar1;
        private TextBox txtAddAllowance;
        private Button btnAddExpense;
    }
}