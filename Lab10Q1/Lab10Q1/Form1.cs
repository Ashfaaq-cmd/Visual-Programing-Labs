namespace Lab10Q1
{
    public partial class Array_Ages : Form
    {
        public Array_Ages()
        {
            InitializeComponent();
        }

        private void Array_Ages_Load(object sender, EventArgs e)
        {
            int[] ages = {
                57, 61, 57, 57, 58, 57, 61, 54, 68, 51, 49, 64,
                50, 48, 65, 52, 56, 46, 54, 49, 51, 47, 55, 55,
                54, 42, 51, 56, 55, 51, 54, 51, 60, 62, 43, 55,
                56, 61, 52, 69, 64, 46, 54, 47, 70
            };
            for (int i = 0; i < ages.Length; i++)
            {
                lstAge.Items.Add(ages[i]);
            }
            int minAge = ages[0];
            int maxAge = ages[0];
            int sumAges = 0;
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < minAge)
                {
                    minAge = ages[i];
                }
                if (ages[i] > maxAge)
                {
                    maxAge = ages[i];
                }
                sumAges += ages[i];
            }
            double avgAge = (double)sumAges / ages.Length;

            txtMin.Text = minAge.ToString();
            txtMax.Text = maxAge.ToString();
            txtAvg.Text = avgAge.ToString("F2");
        }
    }
}
