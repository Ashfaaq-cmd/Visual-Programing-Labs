namespace Lab5Q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txth1.Text);
            double r = double.Parse(txtr.Text);
            double h1 = double.Parse(txtheight1.Text);
            double r1 = double.Parse(txtr1.Text);
            double r2 = double.Parse(txtr2.Text);

      
            double pillarVolume = Math.PI * Math.Pow(r, 2) * h;
            double holeVolume1 = Math.PI * Math.Pow(r1, 2) * h1;
            double holeVolume2 = Math.PI * Math.Pow(r2, 2) * (h - h1);

            double concreteVolume = pillarVolume - (holeVolume1 + holeVolume2);

            txtConcreteVolume.Text = "The Concrete volume is " + concreteVolume.ToString("F2");
        }
    }
}
