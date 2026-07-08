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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            btnSpending = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 44);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 6;
            label1.Text = "SPENDING";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MidnightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(15, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(329, 194);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Transportation", "School Expenses", "Bills(House)", "Others" });
            comboBox1.Location = new Point(102, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(123, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 59);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 9;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MidnightBlue;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 66);
            label3.Name = "label3";
            label3.Size = new Size(35, 13);
            label3.TabIndex = 10;
            label3.Text = "Price";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MidnightBlue;
            label4.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 27);
            label4.Name = "label4";
            label4.Size = new Size(59, 13);
            label4.TabIndex = 11;
            label4.Text = "Category";
            label4.Click += label4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(102, 56);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(123, 23);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MidnightBlue;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(37, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 150);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MidnightBlue;
            label5.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(26, 101);
            label5.Name = "label5";
            label5.Size = new Size(70, 13);
            label5.TabIndex = 14;
            label5.Text = "Description";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(125, 120);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSpending
            // 
            btnSpending.BackColor = Color.MidnightBlue;
            btnSpending.ForeColor = Color.Cornsilk;
            btnSpending.Location = new Point(96, 405);
            btnSpending.Name = "btnSpending";
            btnSpending.Size = new Size(93, 50);
            btnSpending.TabIndex = 19;
            btnSpending.Text = "SPENDING";
            btnSpending.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.MidnightBlue;
            button6.ForeColor = Color.Cornsilk;
            button6.Location = new Point(184, 405);
            button6.Name = "button6";
            button6.Size = new Size(93, 50);
            button6.TabIndex = 18;
            button6.Text = "GOALS";
            button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(269, 405);
            button4.Name = "button4";
            button4.Size = new Size(93, 50);
            button4.TabIndex = 17;
            button4.Text = "USER";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(-2, 405);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 15;
            button2.Text = "HOME";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.Location = new Point(4, 405);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(358, 50);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // SpendingPage
            // 
            AcceptButton = btnSpending;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 450);
            Controls.Add(btnSpending);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SpendingPage";
            Text = "SpendingPage";
            Load += SpendingPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private Button btnSpending;
        private Button button6;
        private Button button4;
        private Button button2;
        private PictureBox pictureBox2;
    }
}