using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Count.Text = $"{Properties.Settings.Default.CountNum}";
        }
        private void plusTen_btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CountNum += 10;
            Count.Text = $"{Properties.Settings.Default.CountNum}";
            Properties.Settings.Default.Save();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CountNum = 0;
            Count.Text = $"{Properties.Settings.Default.CountNum}";
            Properties.Settings.Default.Save();
        }
    }
}