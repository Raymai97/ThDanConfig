using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace MaiSoft
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitIcon();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        private static Icon _exeIcon;
        private static Icon _exeIcon48;

        public static Icon ExeIcon
        {
            get { return _exeIcon; }
        }

        public static Icon ExeIcon48
        {
            get
            {
                return (_exeIcon48 != null) ? _exeIcon48 : _exeIcon;
            }
        }

        private static void InitIcon()
        {
            bool win7_above = (Environment.OSVersion.Version.Build >= 7600);
            string path = Application.ExecutablePath;
            // Get basic icon.
            try
            {
                _exeIcon = Icon.ExtractAssociatedIcon(path);
            }
            catch (Exception) { }
            // If eicon.dll is available, try get better icon.
            try
            {
                _exeIcon = ExtractIconDll.ExtractOne(path, 0,
                    (uint)(win7_above ? 32 : 16));
                _exeIcon48 = ExtractIconDll.ExtractOne(path, 0, 48);
            }
            catch (Exception) { }
        }
    }

}
