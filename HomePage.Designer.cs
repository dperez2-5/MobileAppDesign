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
            pictureBox5 = new PictureBox();
            btnAddAllowance = new Button();
            groupBox3 = new GroupBox();
            pictureBox6 = new PictureBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            circleProgressBar1 = new ReaLTaiizor.Controls.CircleProgressBar();
            pictureBox8 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(39, 322);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(307, 58);
            button2.TabIndex = 1;
            button2.Text = "🏠 HOME";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(39, 727);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(307, 58);
            button4.TabIndex = 9;
            button4.Text = "USER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.CornflowerBlue;
            button6.Location = new Point(39, 492);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(307, 58);
            button6.TabIndex = 10;
            button6.Text = "🎯GOALS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.CornflowerBlue;
            button7.Location = new Point(39, 407);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(307, 58);
            button7.TabIndex = 11;
            button7.Text = "💳 SPENDING";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // lblAllowance
            // 
            lblAllowance.AutoSize = true;
            lblAllowance.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllowance.Location = new Point(196, 29);
            lblAllowance.Margin = new Padding(4, 0, 4, 0);
            lblAllowance.Name = "lblAllowance";
            lblAllowance.Size = new Size(256, 38);
            lblAllowance.TabIndex = 17;
            lblAllowance.Text = "Weekly Allowance";
            lblAllowance.Click += label2_Click;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(246, 66);
            txtBalance.Margin = new Padding(4, 5, 4, 5);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(184, 31);
            txtBalance.TabIndex = 18;
            txtBalance.Text = "0";
            txtBalance.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 82);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 31);
            textBox2.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(176, 43);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(210, 32);
            label10.TabIndex = 21;
            label10.Text = "Current Balance";
            label10.Click += label10_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(-4, -23);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(15);
            pictureBox2.Size = new Size(423, 1500);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(145, 289);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 28);
            label11.TabIndex = 25;
            label11.Text = "Main Menu";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(145, 694);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(90, 28);
            label12.TabIndex = 26;
            label12.Text = "Account";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.CornflowerBlue;
            label13.Location = new Point(94, 158);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(221, 60);
            label13.TabIndex = 27;
            label13.Text = "PesoWise";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 34);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(441, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1635, 60);
            label1.TabIndex = 29;
            label1.Text = "Good Morning, User(i code ra nato ang unsa na user i butang kay mu display)";
            label1.Click += label1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.AliceBlue;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(323, -290);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1715, 520);
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSkyBlue;
            groupBox2.Controls.Add(txtAddAllowance);
            groupBox2.Controls.Add(txtBalance);
            groupBox2.Controls.Add(lblAllowance);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(btnAddAllowance);
            groupBox2.Location = new Point(474, 290);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(457, 175);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            // 
            // txtAddAllowance
            // 
            txtAddAllowance.Location = new Point(124, 131);
            txtAddAllowance.Margin = new Padding(4, 5, 4, 5);
            txtAddAllowance.Name = "txtAddAllowance";
            txtAddAllowance.Size = new Size(193, 31);
            txtAddAllowance.TabIndex = 20;
            txtAddAllowance.TextChanged += textBox7_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(215, 137);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // btnAddAllowance
            // 
            btnAddAllowance.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAllowance.Location = new Point(319, 125);
            btnAddAllowance.Margin = new Padding(4, 5, 4, 5);
            btnAddAllowance.Name = "btnAddAllowance";
            btnAddAllowance.Size = new Size(130, 40);
            btnAddAllowance.TabIndex = 19;
            btnAddAllowance.Text = "add allowance";
            btnAddAllowance.UseVisualStyleBackColor = true;
            btnAddAllowance.Click += button1_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PowderBlue;
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(pictureBox6);
            groupBox3.Location = new Point(969, 290);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(457, 175);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 14);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(200, 161);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightCyan;
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(circleProgressBar1);
            groupBox4.Controls.Add(pictureBox8);
            groupBox4.Location = new Point(1273, 540);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(421, 312);
            groupBox4.TabIndex = 34;
            groupBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 13);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 39);
            label3.TabIndex = 0;
            label3.Text = "🎯Goal";
            // 
            // circleProgressBar1
            // 
            circleProgressBar1.Font = new Font("Segoe UI", 15F);
            circleProgressBar1.Location = new Point(115, 13);
            circleProgressBar1.Margin = new Padding(4, 5, 4, 5);
            circleProgressBar1.Maximum = 100L;
            circleProgressBar1.MinimumSize = new Size(143, 167);
            circleProgressBar1.Name = "circleProgressBar1";
            circleProgressBar1.PercentColor = Color.White;
            circleProgressBar1.ProgressColor1 = Color.FromArgb(128, 128, 255);
            circleProgressBar1.ProgressColor2 = Color.RoyalBlue;
            circleProgressBar1.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            circleProgressBar1.Size = new Size(301, 301);
            circleProgressBar1.TabIndex = 42;
            circleProgressBar1.Text = "circleProgressBar1";
            circleProgressBar1.Value = 59L;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(7, 55);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(115, 118);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 43;
            pictureBox8.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.SkyBlue;
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(txtTotalExpenses);
            groupBox5.Controls.Add(pictureBox7);
            groupBox5.Location = new Point(1464, 290);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(457, 175);
            groupBox5.TabIndex = 35;
            groupBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(203, 45);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(189, 32);
            label9.TabIndex = 36;
            label9.Text = "Total Expenses";
            // 
            // txtTotalExpenses
            // 
            txtTotalExpenses.Location = new Point(203, 82);
            txtTotalExpenses.Margin = new Padding(4, 5, 4, 5);
            txtTotalExpenses.Name = "txtTotalExpenses";
            txtTotalExpenses.ReadOnly = true;
            txtTotalExpenses.Size = new Size(244, 31);
            txtTotalExpenses.TabIndex = 37;
            txtTotalExpenses.Text = "0.00";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(-31, 14);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(292, 161);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 38;
            pictureBox7.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = Color.LightSteelBlue;
            dateTimePicker2.CalendarTitleBackColor = Color.LightSteelBlue;
            dateTimePicker2.CalendarTrailingForeColor = Color.LightSteelBlue;
            dateTimePicker2.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(148, 75);
            dateTimePicker2.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(284, 27);
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
            groupBox1.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(667, 540);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(450, 518);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "📝 ADD NEW EXPENSE";
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(139, 470);
            btnAddExpense.Margin = new Padding(4, 5, 4, 5);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(174, 38);
            btnAddExpense.TabIndex = 42;
            btnAddExpense.Text = "➕Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(209, 410);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(173, 32);
            txtAmount.TabIndex = 43;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(209, 297);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(173, 32);
            txtDescription.TabIndex = 42;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Food", "Transportation", "School Expense", "Bills (House)", "Others" });
            cmbCategory.Location = new Point(209, 179);
            cmbCategory.Margin = new Padding(4, 5, 4, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(173, 34);
            cmbCategory.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 187);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(131, 26);
            label7.TabIndex = 3;
            label7.Text = "📖Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 303);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 26);
            label6.TabIndex = 2;
            label6.Text = "✏️Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 416);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 26);
            label5.TabIndex = 1;
            label5.Text = "💰Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 76);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 26);
            label4.TabIndex = 0;
            label4.Text = "🗓️Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(460, 111);
            label2.Name = "label2";
            label2.Size = new Size(373, 30);
            label2.TabIndex = 44;
            label2.Text = "Let's make today a smart money day!";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(128, 218);
            label14.Name = "label14";
            label14.Size = new Size(151, 25);
            label14.TabIndex = 45;
            label14.Text = "Allowance Tracker";
            // 
            // HomePage
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1924, 1170);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HomePage";
            Text = "0";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
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
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private TextBox textBox1;
        private Label label2;
        private Label label14;
    }
}