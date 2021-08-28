using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AsyncAwait
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

        private async void btnCount_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(GetCount);
            task.Start();

            lblCount.Text = $"Loading";
            int count = await task;
            lblCount.Text = $"Characher {count}";
        }

        private int GetCount()
        {
            int count = 0;

            using (StreamReader sr = new StreamReader(@"C:\Users\40775\Desktop\DemoRepo\README.md"))
            {
                string length = sr.ReadToEnd();
                count = length.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
    }
}
