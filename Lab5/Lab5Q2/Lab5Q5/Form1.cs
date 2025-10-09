namespace Lab5Q5
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


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double distance = Convert.ToDouble(txtDistance.Text);
            double kmPerLitre = Convert.ToDouble(txtKmPerLitre.Text);
            double costPerLiter = Convert.ToDouble(txtAvgLitre.Text);

            double litresNeeded = distance / kmPerLitre;
            double totalCost = litresNeeded * costPerLiter;

            txtLitresNeeded.Text = litresNeeded.ToString("F2");
            txtTotalCost.Text = totalCost.ToString("C");

        }
    }
}
