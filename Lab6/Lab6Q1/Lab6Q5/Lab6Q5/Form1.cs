namespace Lab6Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
        double grade = Convert.ToDouble(txtStudMarks.Text);
            if (grade >= 80)
            txtOutput.Text = "A";
        else if (grade >= 60)
            txtOutput.Text = "B";
        else if (grade >= 40)
            txtOutput.Text = "C";
        else
            txtOutput.Text = "D";

        }
    }
}
