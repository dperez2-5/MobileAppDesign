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
            label5 = new Label();
            lblWelcome = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label14 = new Label();
            label11 = new Label();
            button7 = new Button();
            button6 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvExpensesHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dgvExpensesHistory
            // 
            dgvExpensesHistory.BackgroundColor = Color.FromArgb(47, 57, 67);
            dgvExpensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpensesHistory.GridColor = Color.FromArgb(47, 57, 67);
            dgvExpensesHistory.Location = new Point(333, 195);
            dgvExpensesHistory.Margin = new Padding(2, 2, 2, 2);
            dgvExpensesHistory.Name = "dgvExpensesHistory";
            dgvExpensesHistory.RowHeadersWidth = 62;
            dgvExpensesHistory.Size = new Size(979, 334);
            dgvExpensesHistory.TabIndex = 42;
            dgvExpensesHistory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(47, 57, 67);
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(346, 159);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(240, 29);
            label5.TabIndex = 60;
            label5.Text = "💵Spending History";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(59, 71, 83);
            lblWelcome.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(1023, 47);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(260, 36);
            lblWelcome.TabIndex = 69;
            lblWelcome.Text = "Good Day, User! ";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(59, 71, 83);
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(229, -173);
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
            label3.Location = new Point(1018, 100);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(322, 16);
            label3.TabIndex = 74;
            label3.Text = "Let's make today a smart money day!";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(59, 71, 83);
            label14.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(73, 132);
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
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(101, 167);
            label11.Name = "label11";
            label11.Size = new Size(97, 21);
            label11.TabIndex = 79;
            label11.Text = "Main Menu";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(113, 100, 81);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(30, 245);
            button7.Name = "button7";
            button7.Size = new Size(215, 35);
            button7.TabIndex = 77;
            button7.Text = "💳 SPENDING";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(59, 71, 83);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(113, 100, 81);
            button6.Location = new Point(30, 296);
            button6.Name = "button6";
            button6.Size = new Size(215, 35);
            button6.TabIndex = 76;
            button6.Text = "🎯GOALS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(59, 71, 83);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(113, 100, 81);
            button2.Location = new Point(30, 194);
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
            pictureBox2.Location = new Point(0, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10, 9, 10, 9);
            pictureBox2.Size = new Size(298, 900);
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(102, 47);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(96, 73);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 82;
            pictureBox4.TabStop = false;
            // 
            // SpendingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 57, 67);
            ClientSize = new Size(1347, 702);
            Controls.Add(pictureBox4);
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
            Controls.Add(dgvExpensesHistory);
            Name = "SpendingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SpendingPage";
            ((System.ComponentModel.ISupportInitialize)dgvExpensesHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvExpensesHistory;
        private Label label5;
        private Label lblWelcome;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label14;
        private Label label11;
        private Button button7;
        private Button button6;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}