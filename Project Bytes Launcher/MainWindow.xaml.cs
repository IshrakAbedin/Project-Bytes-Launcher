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
using System.Media;

namespace Project_Bytes_Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MediaPlayer MP;
        public static bool AudioOn = true;
        public static ImageBrush brushAudioOn = new ImageBrush(new BitmapImage(new Uri("Launcher Resources/AudioOnIconL.png", UriKind.Relative)));
        public static ImageBrush brushAudioOff = new ImageBrush(new BitmapImage(new Uri("Launcher Resources/AudioOffIconL.png", UriKind.Relative)));
        public MainWindow()
        {
            InitializeComponent();
            MP = new MediaPlayer();
            MP.Open(new Uri("Launcher Resources/BGM_Launcher.wav",UriKind.Relative));
            MP.Play();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlaySound();
            Launcher.Play();
            Launcher.Quit();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlaySound();
            MP.Stop();
            Launcher.Quit();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlaySound();
            Launcher.About();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlaySound();
            Launcher.Help();
        }

        private void AudioButton_Click(object sender, RoutedEventArgs e)
        {
            if (AudioOn)
            {
                Launcher.PlaySound();
                AudioOn = false;
                AudioButton.Background = brushAudioOff;
                MP.Stop();
            }
            else if (!AudioOn)
            {
                Launcher.PlaySound();
                AudioOn = true;
                AudioButton.Background = brushAudioOn;
                MP.Play();
            }
        }

        private void MoveButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow1.DragMove();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
