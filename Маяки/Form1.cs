using System;
using System.Drawing;
using System.Windows.Forms;

namespace Маяки
{
    public partial class Form1 : Form
    {
        int m1 = 0, m2 = 0, m3 = 0, m1c = 0, m2c = 0, m3c = 0, time = 1;

        bool b1, b2, b3;

        public Form1()
        {
            InitializeComponent();
            lmc1.Text = "1";
            lmc2.Text = "1";
            lmc3.Text = "1";
        }

        private void button1_Click( object sender, EventArgs e )
        {

            b1 = false;
            b2 = false;
            b3 = false;
            m1 = 0;
            m2 = 0;
            m3 = 0;
            m1c = 0;
            m2c = 0;
            m3c = 0;
            time = 1;
            lmc1.Text = "0";
            lmc2.Text = "0";
            lmc3.Text = "0";

            timer1.Start();
        }
        private void timer1_Tick( object sender, EventArgs e )
        {

            if( m1 == 3 )
            {
                m1 = 0;
                b1 = true;
                m1c++;
                lmc1.Text = m1c.ToString();
                pictureBox1.BackColor = pictureBox1.BackColor == Color.Blue ? Color.Red : Color.Blue;
            }
            else m1++;

            if( m2 == 4 )
            {
                m2 = 0;
                b2 = true;
                m2c++;
                lmc2.Text = m2c.ToString();
                pictureBox2.BackColor = pictureBox2.BackColor == Color.Blue ? Color.Red : Color.Blue;
            }
            else m2++;

            if( m3 == 5 )
            {
                m3 = 0;
                b3 = true;
                m3c++;
                lmc3.Text = m3c.ToString();
                pictureBox3.BackColor = pictureBox3.BackColor == Color.Blue ? Color.Red : Color.Blue;
            }
            else m3++;

            ltimer.Text = "Время: " + time++;
            if( b1 && b2 && b3 && pictureBox1.BackColor == Color.Red && pictureBox2.BackColor == Color.Red && pictureBox3.BackColor == Color.Red ) timer1.Stop();  // красный


            b1 = false;
            b2 = false;
            b3 = false;
        }

        private void button2_Click( object sender, EventArgs e )
        {

            b1 = false;
            b2 = false;
            b3 = false;
            m1 = 0;
            m2 = 0;
            m3 = 0;
            m1c = 0;
            m2c = 0;
            m3c = 0;
            time = 1;
            lmc1.Text = "0";
            lmc2.Text = "0";
            lmc3.Text = "0";

            timer2.Start();
        }

        private void timer2_Tick( object sender, EventArgs e )
        {

            if( m1 == 3 )
            {
                m1 = 0;
                b1 = true;
                m1c++;
                lmc1.Text = m1c.ToString();
                pictureBox1.BackColor = pictureBox1.BackColor == Color.Blue ? Color.Red : Color.Blue;
            }
            else m1++;

            if( m2 == 4 )
            {
                m2 = 0;
                b2 = true;
                m2c++;
                lmc2.Text = m2c.ToString();
                pictureBox2.BackColor = pictureBox2.BackColor == Color.Blue ? Color.Red : Color.Blue;
            }
            else m2++;

            if( m3 == 5 )
            {
                m3 = 0;
                b3 = true;
                m3c++;
                lmc3.Text = m3c.ToString();
                pictureBox3.BackColor = pictureBox3.BackColor == Color.Blue ? Color.Red : Color.Blue;
            }
            else m3++;

            ltimer.Text = "Время: " + time++;
            if( b1 && b2 && b3 && pictureBox1.BackColor == Color.Blue && pictureBox2.BackColor == Color.Blue && pictureBox3.BackColor == Color.Blue ) timer2.Stop();  // синий

            b1 = false;
            b2 = false;
            b3 = false;
        }
    }
}
