using System.Security.Cryptography.X509Certificates;

namespace C__A_Project
{
    public partial class Greyhound_Race : Form
    {
        public Greyhound_Race()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();

        }


        //NAME THE DOGS
        public void button1_Click(object sender, EventArgs e)
        {
            greyhoundLabel1.Text = textBox1.Text; textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            greyhoundLabel2.Text = textBox2.Text; textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            greyhoundLabel3.Text = textBox3.Text; textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            greyhoundLabel4.Text = textBox4.Text; textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            greyhoundLabel5.Text = textBox5.Text; textBox5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            greyhoundLabel6.Text = textBox6.Text; textBox6.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            greyhoundLabel7.Text = textBox7.Text; textBox7.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            greyhoundLabel8.Text = textBox8.Text; textBox8.Text = "";
        }






        //WHEN START RACE
        public void start_Click(object sender, EventArgs e)
        {
            if (raceStyleBoxs.Text == "Sprint Race" && racingDogsBoxs.Text == "6")
            {
                //Sprint Race And 6 Dogs
                for (int i = 0; i < 6; i++)
                {
                    Random randomNumber = new Random();
                    greyhoundBar1.Value += randomNumber.Next(0, 10); value1.Text = greyhoundBar1.Value.ToString();
                    greyhoundBar2.Value += randomNumber.Next(0, 10); value2.Text = greyhoundBar2.Value.ToString();
                    greyhoundBar3.Value += randomNumber.Next(0, 10); value3.Text = greyhoundBar3.Value.ToString();
                    greyhoundBar4.Value += randomNumber.Next(0, 10); value4.Text = greyhoundBar4.Value.ToString();
                    greyhoundBar5.Value += randomNumber.Next(0, 10); value5.Text = greyhoundBar5.Value.ToString();
                    greyhoundBar6.Value += randomNumber.Next(0, 10); value6.Text = greyhoundBar6.Value.ToString();
                }
                start.Enabled = false;
            }
            else if (raceStyleBoxs.Text == "Sprint Race" && racingDogsBoxs.Text == "8")
            {
                //Sprint Race And 8 Dogs
                for (int i = 0; i < 6; i++)
                {
                    Random randomNumber = new Random();
                    greyhoundBar1.Value += randomNumber.Next(0, 10); value1.Text = greyhoundBar1.Value.ToString();
                    greyhoundBar2.Value += randomNumber.Next(0, 10); value2.Text = greyhoundBar2.Value.ToString();
                    greyhoundBar3.Value += randomNumber.Next(0, 10); value3.Text = greyhoundBar3.Value.ToString();
                    greyhoundBar4.Value += randomNumber.Next(0, 10); value4.Text = greyhoundBar4.Value.ToString();
                    greyhoundBar5.Value += randomNumber.Next(0, 10); value5.Text = greyhoundBar5.Value.ToString();
                    greyhoundBar6.Value += randomNumber.Next(0, 10); value6.Text = greyhoundBar6.Value.ToString();
                    greyhoundBar7.Value += randomNumber.Next(0, 10); value7.Text = greyhoundBar7.Value.ToString();
                    greyhoundBar8.Value += randomNumber.Next(0, 10); value8.Text = greyhoundBar8.Value.ToString();
                }
                start.Enabled = false;
            }
            else if (raceStyleBoxs.Text == "Middle Distance Race" && racingDogsBoxs.Text == "6")
            {
                //Middle Distance Race And 6 Dogs
                for (int i = 0; i < 10; i++)
                {
                    Random randomNumber = new Random();
                    greyhoundBar1.Value += randomNumber.Next(0, 10); value1.Text = greyhoundBar1.Value.ToString();
                    greyhoundBar2.Value += randomNumber.Next(0, 10); value2.Text = greyhoundBar2.Value.ToString();
                    greyhoundBar3.Value += randomNumber.Next(0, 10); value3.Text = greyhoundBar3.Value.ToString();
                    greyhoundBar4.Value += randomNumber.Next(0, 10); value4.Text = greyhoundBar4.Value.ToString();
                    greyhoundBar5.Value += randomNumber.Next(0, 10); value5.Text = greyhoundBar5.Value.ToString();
                    greyhoundBar6.Value += randomNumber.Next(0, 10); value6.Text = greyhoundBar6.Value.ToString();
                }
                start.Enabled = false;
            }
            else if (raceStyleBoxs.Text == "Middle Distance Race" && racingDogsBoxs.Text == "8")
            {
                //Middle Distance Race And 8 Dogs
                for (int i = 0; i < 10; i++)
                {
                    Random randomNumber = new Random();
                    greyhoundBar1.Value += randomNumber.Next(0, 10); value1.Text = greyhoundBar1.Value.ToString();
                    greyhoundBar2.Value += randomNumber.Next(0, 10); value2.Text = greyhoundBar2.Value.ToString();
                    greyhoundBar3.Value += randomNumber.Next(0, 10); value3.Text = greyhoundBar3.Value.ToString();
                    greyhoundBar4.Value += randomNumber.Next(0, 10); value4.Text = greyhoundBar4.Value.ToString();
                    greyhoundBar5.Value += randomNumber.Next(0, 10); value5.Text = greyhoundBar5.Value.ToString();
                    greyhoundBar6.Value += randomNumber.Next(0, 10); value6.Text = greyhoundBar6.Value.ToString();
                    greyhoundBar7.Value += randomNumber.Next(0, 10); value7.Text = greyhoundBar7.Value.ToString();
                    greyhoundBar8.Value += randomNumber.Next(0, 10); value8.Text = greyhoundBar8.Value.ToString();
                }
                start.Enabled = false;
            }
            else if (raceStyleBoxs.Text == "Marathon" && racingDogsBoxs.Text == "6")
            {
                //Marathon Race And 6 Dogs
                for (int i = 0; i < 12; i++)
                {
                    Random randomNumber = new Random();
                    greyhoundBar1.Value += randomNumber.Next(0, 10); value1.Text = greyhoundBar1.Value.ToString();
                    greyhoundBar2.Value += randomNumber.Next(0, 10); value2.Text = greyhoundBar2.Value.ToString();
                    greyhoundBar3.Value += randomNumber.Next(0, 10); value3.Text = greyhoundBar3.Value.ToString();
                    greyhoundBar4.Value += randomNumber.Next(0, 10); value4.Text = greyhoundBar4.Value.ToString();
                    greyhoundBar5.Value += randomNumber.Next(0, 10); value5.Text = greyhoundBar5.Value.ToString();
                    greyhoundBar6.Value += randomNumber.Next(0, 10); value6.Text = greyhoundBar6.Value.ToString();
                }
                start.Enabled = false;
            }
            else if (raceStyleBoxs.Text == "Marathon" && racingDogsBoxs.Text == "8")
            {
                //Marathon Race And 8 Dogs
                for (int i = 0; i < 12; i++)
                {
                    Random randomNumber = new Random();
                    greyhoundBar1.Value += randomNumber.Next(0, 10); value1.Text = greyhoundBar1.Value.ToString();
                    greyhoundBar2.Value += randomNumber.Next(0, 10); value2.Text = greyhoundBar2.Value.ToString();
                    greyhoundBar3.Value += randomNumber.Next(0, 10); value3.Text = greyhoundBar3.Value.ToString();
                    greyhoundBar4.Value += randomNumber.Next(0, 10); value4.Text = greyhoundBar4.Value.ToString();
                    greyhoundBar5.Value += randomNumber.Next(0, 10); value5.Text = greyhoundBar5.Value.ToString();
                    greyhoundBar6.Value += randomNumber.Next(0, 10); value6.Text = greyhoundBar6.Value.ToString();
                    greyhoundBar7.Value += randomNumber.Next(0, 10); value7.Text = greyhoundBar7.Value.ToString();
                    greyhoundBar8.Value += randomNumber.Next(0, 10); value8.Text = greyhoundBar8.Value.ToString();
                }
                start.Enabled = false;
            }
            
        }






        //WHEN RESTART RACE AGAIN
        private void restart_Click(object sender, EventArgs e)
        {
            greyhoundBar1.Value = 0; value1.Text = greyhoundBar1.Value.ToString();
            greyhoundBar2.Value = 0; value2.Text = greyhoundBar2.Value.ToString();
            greyhoundBar3.Value = 0; value3.Text = greyhoundBar3.Value.ToString();
            greyhoundBar4.Value = 0; value4.Text = greyhoundBar4.Value.ToString();
            greyhoundBar5.Value = 0; value5.Text = greyhoundBar5.Value.ToString();
            greyhoundBar6.Value = 0; value6.Text = greyhoundBar6.Value.ToString();
            greyhoundBar7.Value = 0; value7.Text = greyhoundBar7.Value.ToString();
            greyhoundBar8.Value = 0; value8.Text = greyhoundBar8.Value.ToString();

            start_Click(sender, e);
        }
    }
}