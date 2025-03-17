namespace EX4
{
    public partial class FormEx4 : Form
    {
        public FormEx4()
        {
            InitializeComponent();
            btnShow.Click += BtnShow_Click;
            btnQuitter.Click += BtnQuitter_Click;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                txtOutput.Text = ConvertToHex(txtInput.Text);
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ConvertToHex(string input)
        {
            string hexOutput = "";
            foreach (char c in input)
            {
                hexOutput += ((int)c).ToString("X2") + " / ";
            }
            return hexOutput.Trim();
        }
    }
}
