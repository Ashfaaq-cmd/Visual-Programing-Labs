namespace lab6Q8
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
           

            switch (grade)
            {
                case var i when (i >= 80):
                    txtOutput.Text = "A";
                    break;
                    case var i when (i >= 60):
                    txtOutput.Text = "B";
                    break;
                    case var i when (i >= 40):
                    txtOutput.Text = "C";
                    break;
                    case var i when (i < 40):
                    txtOutput.Text = "D";
                    break;
                    default:
                    txtOutput.Text = "Invalid Input";
                    break;

            }
        }
    }
}
