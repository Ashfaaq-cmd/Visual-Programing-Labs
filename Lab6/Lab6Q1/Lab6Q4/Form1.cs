namespace Lab6Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double grossPay;
            double hoursWorked = Convert.ToDouble(txtHours.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            if (hoursWorked <= 40) {
                 grossPay = hoursWorked * rate;

            }
            else
            {
                 grossPay = (40 * rate) + ((hoursWorked - 40) * rate * 1.5);
            }

                txtGrossPay.Text = grossPay.ToString("C");
        }
    }
}
