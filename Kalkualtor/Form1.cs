using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkualtor
{
    public partial class KalkulatorbyTomasz : Form
    {
        private float wynik;
        private float[] number;
        private int next=2;
        private int r = 0;
        private float firstnumber;
        private float secondnumber;
        private int action = 1;
        private bool pushcomma=true;
        private bool power = false;
        //legends: actions
        //action (1) dodawanie
        //action (2) mnożenie
        //action (3) odejmowanie
        //action (4) dzielenie
        //action (5) x²
        public KalkulatorbyTomasz()
        {
            InitializeComponent();
        }

        public void PowersCalcutalions()
        {
            if ((r == 0) && (power=true))
            {
                float[] number = new float[next];
                float conver = float.Parse(textBox1.Text);
                number[r] = conver*conver;
                firstnumber = conver;
                r++;
            }
            else
            {
                float[] number = new float[next];
                float conver = float.Parse(textBox1.Text);
                number[r] = conver*conver;
                secondnumber = conver;
            }
        }

        public void Calculations()
        {
            if (r == 0)
            {
                float[] number = new float[next];
                float conver = float.Parse(textBox1.Text);
                number[r] = conver;
                firstnumber = conver;
                r++;
            }
            else
            {
                float[] number = new float[next];
                float conver = float.Parse(textBox1.Text);
                number[r] = conver;
                secondnumber = conver;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //buttontexBox
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //button0
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //buttonCE
            pushcomma = true;
            firstnumber = 0;
            secondnumber = 0;
            r = 0;
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1
            if (textBox1.Text=="0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button3
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button4
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //button5
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //button6
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //button7
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //button8
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //button9
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //button=
            if (firstnumber%secondnumber==0)
            {
                pushcomma = true;
            }
            else
            {
                pushcomma = false;
            }
            Calculations();
            textBox1.Text = "0";
            if (action == 1)
            {
                wynik = firstnumber + secondnumber;
                string myString = Convert.ToString(wynik);
                textBox1.Text = myString;
            }
            else if (action==2)
            {
                wynik = firstnumber * secondnumber;
                string myString = Convert.ToString(wynik);
                textBox1.Text = myString;

            }
            else if (action==3)
            {
                wynik = firstnumber - secondnumber;
                string myString = Convert.ToString(wynik);
                textBox1.Text = myString;
            }
            else if (action == 4)
            {
                wynik = firstnumber / secondnumber;
                string myString = Convert.ToString(wynik);
                textBox1.Text = myString;
            }
            r = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //button+
            pushcomma = true;
            action = 1;
            Calculations();
            textBox1.Text = "0";
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //help
            Pomoc pomoc = new Pomoc();
            pomoc.Show();
            Form form = new Form();
            form.Hide();
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void wyszukiwarkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wyszukiwarka wyszukiwarka = new Wyszukiwarka();
            wyszukiwarka.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //button*
            pushcomma = true;
            action = 2;
            Calculations();
            textBox1.Text = "0";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //button,
            if(pushcomma==true)
            {
                textBox1.Text += ",";
                pushcomma = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //button-
            pushcomma = true;
            action = 3;
            Calculations();
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //button[/]action4
            pushcomma = true;
            action = 4;
            Calculations();
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //buttonx²
            pushcomma = true;
            power = true;
            action = 5;
            PowersCalcutalions();
            textBox1.Text = "0";
        }

        private void circleandCrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CircleandCross circleandCross = new CircleandCross();
            circleandCross.Show();
        }
    }
}
