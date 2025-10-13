namespace Lab7Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int sumInsured = Convert.ToInt32(txtSum.Text);
            decimal totalPremium = sumInsured * 0.05m;


            if (chkRiot.Checked)
                totalPremium += 2000;

            if (chkTheft.Checked)
                totalPremium += 4500;

            if (chkFire.Checked)
                totalPremium += 3750;

            // Display result
            txtPremium.Text = totalPremium.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

