using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace C__A_Project
{
    public partial class Greyhound_Race : Form
    {
        public Greyhound_Race()
        {
            InitializeComponent();
            restart.Enabled = false;
        }


        //NAME THE DOGS
        public void button1_Click(object sender, EventArgs e)
        {
            greyhoundLabel1.Text = textBox1.Text; textBox1.Text = "";

            if (greyhoundLabel1.Text == "")
            {
                greyhoundLabel1.Text = "Greyhound 1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            greyhoundLabel2.Text = textBox2.Text; textBox2.Text = "";

            if (greyhoundLabel2.Text == "")
            {
                greyhoundLabel2.Text = "Greyhound 2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            greyhoundLabel3.Text = textBox3.Text; textBox3.Text = "";

            if (greyhoundLabel3.Text == "")
            {
                greyhoundLabel3.Text = "Greyhound 3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            greyhoundLabel4.Text = textBox4.Text; textBox4.Text = "";

            if (greyhoundLabel4.Text == "")
            {
                greyhoundLabel4.Text = "Greyhound 4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            greyhoundLabel5.Text = textBox5.Text; textBox5.Text = "";

            if (greyhoundLabel5.Text == "")
            {
                greyhoundLabel5.Text = "Greyhound 5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            greyhoundLabel6.Text = textBox6.Text; textBox6.Text = "";

            if (greyhoundLabel6.Text == "")
            {
                greyhoundLabel6.Text = "Greyhound 6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            greyhoundLabel7.Text = textBox7.Text; textBox7.Text = "";

            if (greyhoundLabel7.Text == "")
            {
                greyhoundLabel7.Text = "Greyhound 7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            greyhoundLabel8.Text = textBox8.Text; textBox8.Text = "";

            if (greyhoundLabel8.Text == "")
            {
                greyhoundLabel8.Text = "Greyhound 8";
            }
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
                restart.Enabled = true;
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
                restart.Enabled = true;
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
                restart.Enabled = true;
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
                restart.Enabled = true;
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
                restart.Enabled = true;
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
                restart.Enabled = true;
            }

            //FIRST AND LAST
            ArrayList valueA6 = new ArrayList();
            valueA6.Add(greyhoundBar1.Value + " / " + greyhoundLabel1.Text);
            valueA6.Add(greyhoundBar2.Value + " / " + greyhoundLabel2.Text);
            valueA6.Add(greyhoundBar3.Value + " / " + greyhoundLabel3.Text);
            valueA6.Add(greyhoundBar4.Value + " / " + greyhoundLabel4.Text);
            valueA6.Add(greyhoundBar5.Value + " / " + greyhoundLabel5.Text);
            valueA6.Add(greyhoundBar6.Value + " / " + greyhoundLabel6.Text);

            ArrayList valueA8 = new ArrayList();
            valueA8.Add(greyhoundBar1.Value + " / " + greyhoundLabel1.Text);
            valueA8.Add(greyhoundBar2.Value + " / " + greyhoundLabel2.Text);
            valueA8.Add(greyhoundBar3.Value + " / " + greyhoundLabel3.Text);
            valueA8.Add(greyhoundBar4.Value + " / " + greyhoundLabel4.Text);
            valueA8.Add(greyhoundBar5.Value + " / " + greyhoundLabel5.Text);
            valueA8.Add(greyhoundBar6.Value + " / " + greyhoundLabel6.Text);
            valueA8.Add(greyhoundBar7.Value + " / " + greyhoundLabel7.Text);
            valueA8.Add(greyhoundBar8.Value + " / " + greyhoundLabel8.Text);

            valueA6.Sort();
            valueA8.Sort();


            if (start.Enabled == false)
            {
                if (racingDogsBoxs.Text == "6")
                {
                    foreach (var a in valueA6)
                    {
                        first.Text = a.ToString();
                    }

                    valueA6.Reverse();

                    foreach (var b in valueA6)
                    {
                        second.Text = b.ToString();
                    }
                }
                else if (racingDogsBoxs.Text == "8")
                {
                    foreach (var a in valueA8)
                    {
                        first.Text = a.ToString();
                    }

                    valueA8.Reverse();

                    foreach (var b in valueA8)
                    {
                        second.Text = b.ToString();
                    }
                }
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