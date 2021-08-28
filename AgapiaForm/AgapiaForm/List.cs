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
    public partial class List : UserControl
    {
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem("Cola", 0);
            lv1.SubItems.Add("2.50 Lei");

            ListViewItem lv2 = new ListViewItem("Pepsi", 0);
            lv2.SubItems.Add("3 Lei");

            ListViewItem lv3 = new ListViewItem("Leys", 0);
            lv3.SubItems.Add("4 Lei");

            lv_product.Items.Add(lv1);
            lv_product.Items.Add(lv2);
            lv_product.Items.Add(lv3);
        }
    }
}
