namespace Lab5Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(txtx1.Text);
            double x2 = Convert.ToDouble(txtx2.Text);
            double y1 = Convert.ToDouble(txty1.Text);
            double y2 = Convert.ToDouble(txty2.Text);

            double slope = (y2 - y1) / (x2 - x1);
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            txtOutput1.Text = slope.ToString("F2");
            txtOutput2.Text = distance.ToString("F2");

        }
    }
}
