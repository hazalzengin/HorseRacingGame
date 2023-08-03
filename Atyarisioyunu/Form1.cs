using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atyarisioyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int h1;
        int h2;
        int h3;
        Random rd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            h1 = pictureBox1.Left;
            h2 = pictureBox2.Left;
            h3 = pictureBox3.Left;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            int h1g = pictureBox1.Width;
            int h2g = pictureBox2.Width;
            int h3g = pictureBox3.Width;

            int finish = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rd.Next(5,15);
            pictureBox2.Left = pictureBox2.Left + rd.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rd.Next(5, 15);

            if(pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "First Horse goes first";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "The second horse took the lead with an attack";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "Third Horse took a new attack";
            }

            if (h1g+pictureBox1.Left>= finish)
            {
                timer1.Enabled = false;
                MessageBox.Show("FİRST HORSE WIN!!!");

            }
            if (h2g + pictureBox2.Left >= finish)
            {
                timer1.Enabled = false;
                MessageBox.Show("SECOND HORSE WIN!!!");
            }
            if (h3g + pictureBox3.Left >= finish)
            {
                timer1.Enabled = false;
                MessageBox.Show("THIRD HORSE WIN!!!");
            }
        }
    }
}
