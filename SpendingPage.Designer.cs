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
            dgvExpensesHistory = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            label5 = new Label();
            lblWelcome = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            label11 = new Label();
            button7 = new Button();
            button6 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvExpensesHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvExpensesHistory
            // 
            dgvExpensesHistory.BackgroundColor = Color.FromArgb(47, 57, 67);
            dgvExpensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpensesHistory.GridColor = Color.FromArgb(47, 57, 67);
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
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1187, 594);
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
            button3.BackColor = Color.FromArgb(59, 71, 83);
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
            label5.BackColor = Color.FromArgb(47, 57, 67);
            label5.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(346, 159);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(211, 28);
            label5.TabIndex = 60;
            label5.Text = "💵Spending History";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(59, 71, 83);
            lblWelcome.Font = new Font("Goudy Old Style", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(1082, 29);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(230, 34);
            lblWelcome.TabIndex = 69;
            lblWelcome.Text = "Good Day, User! ";
            lblWelcome.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(59, 71, 83);
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(224, -174);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1201, 313);
            pictureBox3.TabIndex = 70;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(59, 71, 83);
            label3.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(990, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(322, 16);
            label3.TabIndex = 74;
            label3.Text = "Let's make today a smart money day!";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(86, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 78);
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(59, 71, 83);
            label14.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(86, 142);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(148, 18);
            label14.TabIndex = 80;
            label14.Text = "Allowance Tracker";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(59, 71, 83);
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label11.ForeColor = Color.White;
            label11.Location = new Point(98, 180);
            label11.Name = "label11";
            label11.Size = new Size(145, 16);
            label11.TabIndex = 79;
            label11.Text = "Main Menu";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(113, 100, 81);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(41, 252);
            button7.Name = "button7";
            button7.Size = new Size(215, 35);
            button7.TabIndex = 77;
            button7.Text = "💳 SPENDING";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(59, 71, 83);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(113, 100, 81);
            button6.Location = new Point(41, 308);
            button6.Name = "button6";
            button6.Size = new Size(215, 35);
            button6.TabIndex = 76;
            button6.Text = "🎯GOALS";
            button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(59, 71, 83);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(113, 100, 81);
            button2.Location = new Point(41, 199);
            button2.Name = "button2";
            button2.Size = new Size(215, 35);
            button2.TabIndex = 75;
            button2.Text = "🏠HOME";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(59, 71, 83);
            pictureBox2.Location = new Point(3, -63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10, 9, 10, 9);
            pictureBox2.Size = new Size(298, 900);
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // SpendingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 57, 67);
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(lblWelcome);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dgvExpensesHistory);
            Name = "SpendingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SpendingPage";
            ((System.ComponentModel.ISupportInitialize)dgvExpensesHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvExpensesHistory;
        private Button button1;
        private Button button3;
        private Label label5;
        private Label lblWelcome;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label14;
        private Label label11;
        private Button button7;
        private Button button6;
        private Button button2;
        private PictureBox pictureBox2;
    }
}