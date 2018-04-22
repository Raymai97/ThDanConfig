using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace MaiSoft
{
    static class ExtractIconDll
    {
        // HRESULT (LPCTSTR, UINT, HICON *);
        [DllImport("eicon.dll", EntryPoint = "ExtractIconDll_ExtractOne",
            CharSet = CharSet.Unicode,
            CallingConvention = CallingConvention.StdCall)]
        private static extern Int32 ExtractOne(
            String path, int icoIndex, uint icoSize, ref IntPtr phIcon);

        public static Icon ExtractOne(
            string path, int icoIndex, uint icoSize)
        {
            Int32 hr = 0;
            IntPtr hIcon = IntPtr.Zero;
            hr = ExtractOne(path, icoIndex, icoSize, ref hIcon);
            if (hr < 0)
            {
                throw new Win32Exception(hr);
            }
            return Icon.FromHandle(hIcon);
        }
    }
}
