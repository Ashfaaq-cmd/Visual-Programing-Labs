namespace Lab6Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            if (num1 > num2)
            {
                txtOutput.Text = $"{num1} is greater than {num2}";

            }
            else if (num1 < num2)
            {
                txtOutput.Text = $"{num1} is less than {num2}";
            }
            else
            {
                txtOutput.Text = $"{num1} is equal to {num2}";
            }
        }
    }
}
