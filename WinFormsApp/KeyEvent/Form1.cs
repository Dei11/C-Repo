using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                pictureBox1.Left += 10;
            }
            else if (e.KeyCode == Keys.A)
            {
                pictureBox1.Left -= 10;
            }
            else if (e.KeyCode == Keys.W)
            {
                pictureBox1.Top -= 10;
            }
            else if (e.KeyCode == Keys.S)
            {
                pictureBox1.Top += 10;
            }
        }
    }
}
