﻿using System;
using System.Windows.Forms;

namespace Project_CS_Morgane_Cam
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyMovieApplication());
        }

    }

}
