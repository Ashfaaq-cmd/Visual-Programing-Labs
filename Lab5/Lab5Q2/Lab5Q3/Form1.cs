namespace Lab5Q3
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
            double depth = Convert.ToDouble(txtInput.Text);
            double celcius = 10 * (depth + 20);
            double fahrenheit = 1.8 * celcius + 32;

            txtCelcius.Text = "Temperature in Celcius: " + celcius.ToString("F2");
            txtFarenheit.Text = "Temperature in Fahrenheit: " + fahrenheit.ToString("F2");
        }
    }
}
