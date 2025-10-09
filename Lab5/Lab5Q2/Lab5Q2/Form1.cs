namespace Lab5Q2
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
            double radius = double.Parse(txtInput.Text);
            double area = Math.PI * radius * radius;
            txtOutput.Text = $"The area is: " + area.ToString("F2");
        }
    }
}
