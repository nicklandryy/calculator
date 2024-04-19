using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace calculator
{
    public partial class Form1 : Form
    {
        private double curr = 0;
        private double prev = 0;
        private char operation = ' ';
        public Form1()
        {
            InitializeComponent();
            
        }

        private void clickNumButton(object sender, EventArgs e)
        {            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button10.Parent = pictureBox1;

            button11.Parent = pictureBox1;

            button10.BackColor = Color.FromArgb(100, 0, 0, 0);
            button11.BackColor = Color.FromArgb(100, 0, 0, 0);


        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
