namespace Lab11Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnarea_Click(object sender, EventArgs e)
        {

            double width = Convert.ToDouble(txtwidth.Text);
            double length = Convert.ToDouble(txtlength.Text);
            
            double area = AreaOfRectangle( width , length);
            txtarea.Text = "Area is: " + area.ToString();

        }

        private double AreaOfRectangle(double width, double length)
        {
           return width * length;
        }

        private void btnperimeter_Click(object sender, EventArgs e)
        {
            double width = Convert.ToDouble(txtwidth.Text);
            double length = Convert.ToDouble(txtlength.Text);
            double perimeter = PerimeterOfRectangle(width, length);
            txtperimeter.Text = "Perimeter is: " + perimeter.ToString();
        }

        private double PerimeterOfRectangle(double width, double length)
        {
            return 2 * (width + length);
        }
    }
}
