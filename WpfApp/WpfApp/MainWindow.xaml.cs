using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
             
            if(ofd.ShowDialog() == true)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));

                txtDisplay.Text = sr.ReadToEnd();
                sr.Dispose();
            }
        }

        private void menuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = ".txt";
            sfd.DefaultExt = "txt";
            sfd.Filter = "Text File |*txt";

            if (sfd.ShowDialog() == true)
            {
                Stream fileStream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);

                sw.Write(txtDisplay.Text);

                sw.Close();
                fileStream.Close();
            }
        }

        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void fontTimes_Click(object sender, RoutedEventArgs e)
        {
            fontCourier.IsChecked = false;  
            fontArial.IsChecked = false;
            txtDisplay.FontFamily = new FontFamily("Times New Roman");
        }
        private void fontCourier_Click(object sender, RoutedEventArgs e)
        {
            fontTimes.IsChecked = false;
            fontArial.IsChecked = false;
            txtDisplay.FontFamily = new FontFamily("Courier");
        }
        private void fontArial_Click(object sender, RoutedEventArgs e)
        {
            fontTimes.IsChecked = false;
            fontCourier.IsChecked = false;
            txtDisplay.FontFamily = new FontFamily("Arial");
        }
    }
}