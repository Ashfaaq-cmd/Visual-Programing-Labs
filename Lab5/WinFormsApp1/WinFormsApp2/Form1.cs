namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            if (radChild.Checked)
            {
                txtFee.Text = "0";

            }
            else if (radMinor.Checked)
            {
                txtFee.Text = "5";
            }
            else if (radAdult.Checked)
            {
                txtFee.Text = "10";
            }
            else
            {
                txtFee.Text = "7.5";
            }
           
        }
    }
}
