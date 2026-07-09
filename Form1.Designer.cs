namespace MobileAppDesign
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textusername = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(184, 275);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 0;
            label1.Text = "username";
            label1.Click += label1_Click;
            // 
            // textusername
            // 
            textusername.BackColor = SystemColors.InactiveCaption;
            textusername.Location = new Point(102, 249);
            textusername.Multiline = true;
            textusername.Name = "textusername";
            textusername.Size = new Size(146, 23);
            textusername.TabIndex = 1;
            textusername.TextChanged += textusername_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(131, 310);
            button1.Name = "button1";
            button1.Size = new Size(89, 27);
            button1.TabIndex = 2;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(350, 450);
            Controls.Add(button1);
            Controls.Add(textusername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textusername;
        private Button button1;
    }
}
