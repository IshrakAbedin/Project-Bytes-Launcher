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
using System.Windows.Shapes;

namespace Project_Bytes_Launcher
{
    /// <summary>
    /// Shows the simple about screen
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlaySound();
            this.Close();
        }


        private void About_Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
