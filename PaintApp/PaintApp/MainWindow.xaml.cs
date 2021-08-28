using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
using System.Windows.Ink;
using Microsoft.Win32;

namespace PaintApp
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

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender;
            string radioPressed = radioButton.Content.ToString();

            if (radioPressed == "Draw")
            {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Ink;
            }
            else if (radioPressed == "Erase")
            {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
            }
            else if (radioPressed == "Select")
            {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Select;
            }
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            this.DrawingCanvas.Strokes.Clear(); 
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = ".bin";
            sfd.DefaultExt = "bin";

            if (sfd.ShowDialog() == true)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);

                this.DrawingCanvas.Strokes.Save(fs);

                fs.Close();
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == true)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);

                StrokeCollection sc = new StrokeCollection(fs);
                this.DrawingCanvas.Strokes = sc;

                fs.Close();
            }
        }

        #region Size
        private void onePx_Click(object sender, RoutedEventArgs e)
        {
            threePx.IsChecked = false;
            fivePx.IsChecked = false;
            eightPx.IsChecked = false;
            strokeAttr.Width = 1;
            strokeAttr.Height = 1;
        }

        private void threePx_Click(object sender, RoutedEventArgs e)
        {
            onePx.IsChecked = false;
            fivePx.IsChecked = false;
            eightPx.IsChecked = false;
            strokeAttr.Width = 3;
            strokeAttr.Height = 3;
        }

        private void fivePx_Click(object sender, RoutedEventArgs e)
        {
            onePx.IsChecked = false;
            threePx.IsChecked = false;
            eightPx.IsChecked = false;
            strokeAttr.Width = 5;
            strokeAttr.Height = 5;
        }

        private void eightPx_Click(object sender, RoutedEventArgs e)
        {
            onePx.IsChecked = false;
            threePx.IsChecked = false;
            fivePx.IsChecked = false;
            strokeAttr.Width = 8;
            strokeAttr.Height = 8;
        }

        #endregion

        #region Color
        private void blackColor_Click(object sender, RoutedEventArgs e)
        {
            redColor.IsChecked = false;
            greenColor.IsChecked = false;
            blueColor.IsChecked = false;
            this.DrawingCanvas.DefaultDrawingAttributes.Color = Colors.Black;

        }

        private void redColor_Click(object sender, RoutedEventArgs e)
        {
            blackColor.IsChecked = false;
            greenColor.IsChecked = false;
            blueColor.IsChecked = false;
            this.DrawingCanvas.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void greenColor_Click(object sender, RoutedEventArgs e)
        {
            blackColor.IsChecked = false;
            redColor.IsChecked = false;
            blueColor.IsChecked = false;
            this.DrawingCanvas.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void blueColor_Click(object sender, RoutedEventArgs e)
        {
            blackColor.IsChecked = false;
            redColor.IsChecked = false;
            greenColor.IsChecked = false;
            this.DrawingCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        #endregion
    }
}