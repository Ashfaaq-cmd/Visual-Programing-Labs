namespace Lab5Q4
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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double hoursWorked = double.Parse(txtnumOfHours.Text);
            double hourlyRate = double.Parse(txtRate.Text);
            double grossPay = hoursWorked * hourlyRate;
            txtOutput.Text = "Gross Pay: $" + grossPay.ToString("0.00");
        }
    }
}
