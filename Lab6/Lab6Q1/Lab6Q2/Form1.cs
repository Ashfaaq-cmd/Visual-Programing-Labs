namespace Lab6Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String password = txtPassword.Text;
            if (name =="John" && password == "Smith" || name =="Paula" && password == "Jones")
            {
                txtMessage.Text = "Login Successful";
            }
            else {
                txtMessage.Text = "PLease try again";
            }
        }
    }
}
