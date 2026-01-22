namespace Lab11Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double grade = Convert.ToDouble(txtGrade.Text);
            char mark = Grade(grade);
            txtResult.Text = mark.ToString();
        }
        private static char Grade(double grade)
        {
            switch (grade)
            {
                case var m when (m >= 80):
                    return 'A';
                case var m when (m >= 60):
                    return 'B';
                case var m when (m >= 40):
                    return 'C';
                default:
                    return 'D';
            }
        }
    }
}