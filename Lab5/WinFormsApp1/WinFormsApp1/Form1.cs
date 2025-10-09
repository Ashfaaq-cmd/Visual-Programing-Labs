namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            double mark = Convert.ToDouble(txtInput.Text);

            if (mark >= 80)
            {
                txtGrade.Text = "A";
            }
            else if (mark >= 60 )
            {
                txtGrade.Text = "B";
            }
            else if (mark >= 40)
            {
                txtGrade.Text = "C";
            }
            else
            {
                txtGrade.Text = "D";
            }

        }
    }
}
