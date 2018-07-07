using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Project_Bytes_Launcher
{
    class Launcher
    {
        public static void Play()
        {
            Process.Start("Project_Bytes.exe");
        }

        public static void Quit()
        {
            Environment.Exit(0);
        }

        public static void About()
        {
            AboutWindow a1 = new AboutWindow();
            a1.Show();
        }

        public static void Help()
        {
            HelpWindow h1 = new HelpWindow();
            h1.Show();
        }
           
    }
}
