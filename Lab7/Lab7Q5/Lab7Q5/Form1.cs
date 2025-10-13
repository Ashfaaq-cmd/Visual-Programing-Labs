namespace Lab7Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radChocolate.CheckedChanged += updatePrice;
            radVanilla.CheckedChanged += updatePrice;
            radStrawberry.CheckedChanged += updatePrice;

           
            radSmall.CheckedChanged += updatePrice;
            radLarge.CheckedChanged += updatePrice;

           
            chkChocoChips.CheckedChanged += updatePrice;
            chkCookieCandy.CheckedChanged += updatePrice;
            chkNuts.CheckedChanged += updatePrice;
            chkFreshFruits.CheckedChanged += updatePrice;
        }

     private void updatePrice(object sender, EventArgs e)
        {
            int price = 0;
            if (radChocolate.Checked)
            {
                if (radSmall.Checked) price = 60;
                else if (radLarge.Checked) price = 75;

            }
            else if (radVanilla.Checked)
            {
                if (radSmall.Checked) price = 45;
                else if (radLarge.Checked) price = 65;
            }
            else if (radStrawberry.Checked)
            {
                if (radSmall.Checked) price = 50;
                else if (radLarge.Checked) price = 60;
            }
            int toppingPrice = 0;
            if (chkChocoChips.Checked) toppingPrice += 25;
            if (chkCookieCandy.Checked) toppingPrice += 20;
            if (chkNuts.Checked) toppingPrice += 15;
            if (chkFreshFruits.Checked) toppingPrice += 35;

            int totalPrice = price + toppingPrice;
            txtPrice.Text = ("Rs " + totalPrice.ToString());

        }
    }
}
