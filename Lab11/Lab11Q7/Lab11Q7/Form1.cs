namespace Lab11Q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double hoursWorked = Convert.ToDouble(txtHoursWorked.Text);
            double hourlyRate = Convert.ToDouble(txtRate.Text);

            double grossPay = CalcGrossPay(hoursWorked, hourlyRate);
            txtResult.Text = grossPay.ToString("C2");

        }
        private static double CalcGrossPay(double hoursWorked, double payRate)
        {
            if (hoursWorked <= 40)
            {
                return hoursWorked * payRate;
            }
            else
            {
                double overtimeHours = hoursWorked - 40;
                double overtimePay = overtimeHours * payRate * 1.5;
                double regularPay = 40 * payRate;
                return regularPay + overtimePay;
            }
        }
    }
}
