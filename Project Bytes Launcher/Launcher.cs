﻿using System;
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
            About a1 = new About();
            a1.Show();
        }
    }
}
