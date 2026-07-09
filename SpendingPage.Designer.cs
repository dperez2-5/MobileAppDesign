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
            label2 = new Label();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Location = new Point(-5, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 44);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(-5, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 6;
            label1.Text = "SPENDING";
            label1.Click += label1_Click;
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
            // button7
            // 
            button7.BackColor = Color.LightSteelBlue;
            button7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(93, 421);
            button7.Name = "button7";
            button7.Size = new Size(93, 35);
            button7.TabIndex = 16;
            button7.Text = "SPENDING";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSteelBlue;
            button6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(177, 421);
            button6.Name = "button6";
            button6.Size = new Size(93, 35);
            button6.TabIndex = 15;
            button6.Text = "GOALS";
            button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSteelBlue;
            button4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(267, 421);
            button4.Name = "button4";
            button4.Size = new Size(93, 35);
            button4.TabIndex = 14;
            button4.Text = "USER";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(-5, 421);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 12;
            button2.Text = "HOME";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(130, 16);
            label3.TabIndex = 17;
            label3.Text = "EXPENSE HISTORY";
            label3.Click += label3_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(329, 263);
            dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(49, 372);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 19;
            button1.Text = "Delete Selected";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(192, 372);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 20;
            button3.Text = "Clear All";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSteelBlue;
            textBox1.Location = new Point(241, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(149, 48);
            label4.Name = "label4";
            label4.Size = new Size(86, 13);
            label4.TabIndex = 22;
            label4.Text = "Total Expense";
            label4.Click += label4_Click_1;
            // 
            // SpendingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 450);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SpendingPage";
            Text = "SpendingPage";
            Load += SpendingPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button button2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private TextBox textBox1;
        private Label label4;
    }
}