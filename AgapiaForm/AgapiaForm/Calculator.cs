using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgapiaForm
{
    public partial class Calculator : UserControl
    {
        string operational;
        double fNum;
        double sNum;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Numeric_Value(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";

            if(b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + ".";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = ""; 
        }

        private void Operational_Value(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            fNum = double.Parse(txtDisplay.Text);
            operational = b.Text;
            txtDisplay.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sNum = double.Parse(txtDisplay.Text);

            switch (operational)
            {
                case "+":
                    txtDisplay.Text = $"{fNum + sNum}";
                    break;

                case "-":
                    txtDisplay.Text = $"{fNum - sNum}";
                    break;

                case "*":
                    txtDisplay.Text = $"{fNum * sNum}";
                    break;

                case "/":
                    txtDisplay.Text = $"{fNum / sNum}";
                    break;
            }
        }
    }
}
