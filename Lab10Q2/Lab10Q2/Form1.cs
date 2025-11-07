namespace Lab10Q2
{
    public partial class Form1 : Form
    {
        List<int> ids = new List<int>();
        List<string> names = new List<string>();
        List<string> courses = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourse.Clear();
            txtID.Clear();
            txtName.Clear();
            txtID.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string course = txtCourse.Text;

            ids.Add(id);
            names.Add(name);
            courses.Add(course);

            lstData.Items.Add(id);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = lstData.SelectedIndex;
            if (i >= 0)
            {
                ids[i] = int.Parse(txtID.Text);
                names[i] = txtName.Text;
                courses[i] = txtCourse.Text;
                lstData.Items[i] = ids[i];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstData.SelectedIndex;
            if (i >= 0)
            {
                ids.RemoveAt(i);
                names.RemoveAt(i);
                courses.RemoveAt(i);
                lstData.Items.RemoveAt(i);
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstData.SelectedIndex;
            if (i >= 0)
            {
                txtID.Text = ids[i].ToString();
                txtName.Text = names[i];
                txtCourse.Text = courses[i];
            }
        }
    }
}