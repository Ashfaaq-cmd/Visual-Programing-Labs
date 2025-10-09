namespace Lab6Q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           private void btnCalc_Click(object sender, EventArgs e)
        {
                double speed = Convert.ToDouble(txtSpeed.Text);

                
                 int fine = 1000;
                 int finePerKm = 50;
                 int speedLimit = 110;

           
                if (speed < 0 || speed > 300)
                {
                    txtOutput.Text = "Invalid Input: Speed must be between 0-300 km/h";
                    return;
                }

               
                if (speed <= speedLimit)
                {
                    txtOutput.Text = "Speed limit has not been exceeded";
                }
                else
                {
                    double overSpeed = speed - speedLimit;
                    double totFine = fine + (overSpeed * finePerKm);

                    // Display fine amount
                    txtOutput.Text = $"Fine Amount: Rs {totFine}";
                }
            }
         
        }
    }
