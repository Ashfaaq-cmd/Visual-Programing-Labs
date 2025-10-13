namespace Lab7Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (lstCollection.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from the list.");
                return;
            }

            string selectedItem = lstCollection.SelectedItem.ToString();

            if (!int.TryParse(txtQty.Text, out int qty))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            int price = 0;

            switch (selectedItem)
            {
                case "Zinger":
                    price = 90;
                    break;
                case "Large Piece":
                    price = 50;
                    break;
                case "Strips":
                    price = 80;
                    break;
                case "Wedges":
                    price = 75;
                    break;
                default:
                    MessageBox.Show("Unknown item selected.");
                    return;
            }
            int total = qty * price;
            txtUnitPrice.Text = price.ToString();
            txtTot.Text = total.ToString();
        }



    }
    }
