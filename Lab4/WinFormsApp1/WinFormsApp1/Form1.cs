using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            String name = txtame.Text;
            MessageBox.Show("Hello " + txtame.Text);
        }
    }
}
