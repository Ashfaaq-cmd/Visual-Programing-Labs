namespace Lab7Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSum.txtChanged += UpdatePremium;
            chkRiot.CheckedChanged += UpdatePremium;
            chkTheft.CheckedChanged += UpdatePremium;
            chkFire.CheckedChanged += UpdatePremium;
        }

        private void UpdatePremium(object sender, EventArgs e)
        {
            try
            {
                decimal sumInsured = decimal.Parse(txtSum.Text);
                decimal totalPremium = sumInsured * 0.05m;

                if (chkRiot.Checked) totalPremium += 2000;
                if (chkTheft.Checked) totalPremium += 4500;
                if (chkFire.Checked) totalPremium += 3750;

                txtPremium.Text = totalPremium.ToString();
            }
            catch
            {
                
                txtPremium.Text = "";
            }
        }
    }
}