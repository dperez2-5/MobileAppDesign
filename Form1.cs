namespace MobileAppDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textusername.Text))
            {
                MessageBox.Show("Please enter your username first.", "Missing Username",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                textusername.Focus();
                return;
            }
            AppData.Username = textusername.Text;
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
