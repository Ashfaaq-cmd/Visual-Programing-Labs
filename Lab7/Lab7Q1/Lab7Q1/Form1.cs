namespace Lab7Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int adultFare, childrenFare = 0;

            if (radMorning.Checked)
            {
                adultFare = 100;
                childrenFare = 60;
            }
            else if (radAfternoon.Checked)
            {
                adultFare = 125;
                childrenFare = 75;
            }
            else
            {
                adultFare = 150;
                childrenFare = 90;
            }
            int adultTotal = adultFare * int.Parse(txtAdult.Text);
            int childrenTotal = childrenFare * int.Parse(txtChildren.Text);
            int total = adultTotal + childrenTotal;
            txtTot.Text = total.ToString("C");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdult.Clear();
            txtChildren.Clear();
            txtTot.Clear();
            radMorning.Checked = true;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
