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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(-8, 403);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 1;
            button2.Text = "HOME";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 44);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.Location = new Point(-2, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(358, 50);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(263, 403);
            button4.Name = "button4";
            button4.Size = new Size(93, 50);
            button4.TabIndex = 9;
            button4.Text = "USER";
            button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.MidnightBlue;
            button6.ForeColor = Color.Cornsilk;
            button6.Location = new Point(178, 403);
            button6.Name = "button6";
            button6.Size = new Size(93, 50);
            button6.TabIndex = 10;
            button6.Text = "GOALS";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.MidnightBlue;
            button7.ForeColor = Color.Cornsilk;
            button7.Location = new Point(90, 403);
            button7.Name = "button7";
            button7.Size = new Size(93, 50);
            button7.TabIndex = 11;
            button7.Text = "SPENDING";
            button7.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 12;
            label1.Text = "HOME";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Lucida Handwriting", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.MidnightBlue;
            richTextBox1.Location = new Point(12, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(110, 33);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "Hello, ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MidnightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(287, 198);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.MidnightBlue;
            progressBar1.Location = new Point(31, 323);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(287, 35);
            progressBar1.TabIndex = 15;
            // 
            // HomePage
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(348, 450);
            Controls.Add(progressBar1);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button6;
        private Button button7;
        private Label label1;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private ProgressBar progressBar1;
    }
}