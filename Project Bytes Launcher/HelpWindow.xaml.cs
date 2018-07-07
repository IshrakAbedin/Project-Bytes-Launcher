﻿using System;
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
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Controls_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage B1 = new BitmapImage();
            B1.BeginInit();
            B1.UriSource = new Uri("Img_Controls.png",UriKind.Relative);
            B1.EndInit();

            ImageBox_Help.Source = B1;
        }

        private void Button_HUD_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage B1 = new BitmapImage();
            B1.BeginInit();
            B1.UriSource = new Uri("Img_HUD.png", UriKind.Relative);
            B1.EndInit();

            ImageBox_Help.Source = B1;
        }
    }
}
