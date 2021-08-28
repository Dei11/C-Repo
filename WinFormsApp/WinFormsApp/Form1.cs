using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Microsoft.Win32;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
   
        }

        //Save
        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = ".txt";
            sfd.DefaultExt = "txt";
            sfd.Filter = "Text File |*txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream fileStream = sfd.OpenFile())
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    sw.Write(txtDisplay.Text);

                    sw.Close();
                    fileStream.Close();
                }
            }
        }

        //Open
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                using (Stream fileStream = ofd.OpenFile())
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string content = sr.ReadToEnd();
                    txtDisplay.Text = content;
                }
            }
        }
    }
}