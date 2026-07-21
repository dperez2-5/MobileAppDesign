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
            AppData.Username = textusername.Text.Trim();
            
            // Load the specific data profile for this user
            PersistenceManager.LoadForUser(AppData.Username);

            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string lastUser = PersistenceManager.LoadLastUsername();
            if (!string.IsNullOrWhiteSpace(lastUser))
            {
                textusername.Text = lastUser;
            }
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
