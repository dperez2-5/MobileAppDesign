namespace MobileAppDesign
{
    partial class SpendingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpendingPage));
            dgvExpensesHistory = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            label5 = new Label();
            label14 = new Label();
            label13 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            button7 = new Button();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExpensesHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvExpensesHistory
            // 
            dgvExpensesHistory.BackgroundColor = Color.LightSteelBlue;
            dgvExpensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpensesHistory.Location = new Point(333, 195);
            dgvExpensesHistory.Margin = new Padding(2);
            dgvExpensesHistory.Name = "dgvExpensesHistory";
            dgvExpensesHistory.RowHeadersWidth = 62;
            dgvExpensesHistory.Size = new Size(979, 334);
            dgvExpensesHistory.TabIndex = 42;
            dgvExpensesHistory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1187, 590);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(125, 34);
            button1.TabIndex = 46;
            button1.Text = "Clear All";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1187, 544);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(125, 33);
            button3.TabIndex = 47;
            button3.Text = "Delete Selected";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.CornflowerBlue;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(346, 159);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(225, 30);
            label5.TabIndex = 60;
            label5.Text = "💵Spending History";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(87, 131);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(103, 15);
            label14.TabIndex = 72;
            label14.Text = "Allowance Tracker";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.CornflowerBlue;
            label13.Location = new Point(63, 95);
            label13.Name = "label13";
            label13.Size = new Size(150, 41);
            label13.TabIndex = 67;
            label13.Text = "PesoWise";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 21);
            label1.Name = "label1";
            label1.Size = new Size(1036, 41);
            label1.TabIndex = 69;
            label1.Text = "Good Day, User(i code ra nato ang unsa na user i butang kay mu display)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(99, 173);
            label11.Name = "label11";
            label11.Size = new Size(83, 19);
            label11.TabIndex = 65;
            label11.Text = "Main Menu";
            // 
            // button7
            // 
            button7.BackColor = Color.CornflowerBlue;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(25, 244);
            button7.Name = "button7";
            button7.Size = new Size(215, 35);
            button7.TabIndex = 63;
            button7.Text = "💳 SPENDING";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.CornflowerBlue;
            button6.Location = new Point(25, 295);
            button6.Name = "button6";
            button6.Size = new Size(215, 35);
            button6.TabIndex = 62;
            button6.Text = "🎯GOALS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(-5, -14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10, 9, 10, 9);
            pictureBox2.Size = new Size(296, 900);
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.AliceBlue;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(224, -174);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1201, 313);
            pictureBox3.TabIndex = 70;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.CornflowerBlue;
            button2.Location = new Point(25, 195);
            button2.Name = "button2";
            button2.Size = new Size(215, 35);
            button2.TabIndex = 73;
            button2.Text = "🏠HOME";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(319, 73);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(322, 16);
            label3.TabIndex = 74;
            label3.Text = "Let's make today a smart money day!";
            // 
            // SpendingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1370, 749);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dgvExpensesHistory);
            Name = "SpendingPage";
            Text = "SpendingPage";
            ((System.ComponentModel.ISupportInitialize)dgvExpensesHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvExpensesHistory;
        private Button button1;
        private Button button3;
        private Label label5;
        private Label label14;
        private Label label13;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label11;
        private Button button7;
        private Button button6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
        private Label label3;
    }
}