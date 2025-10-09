namespace Lab5Q1
{
    public partial class Demo1 : Form
    {
        public Demo1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double miles = double.Parse(txtBox.Text);
            double km = miles * 1.609;
            txtOutput.Text = km.ToString();


        }
    }
}
