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
        [DllImport("eicon.dll", EntryPoint = "GetIconOfFile",
            CharSet = CharSet.Unicode,
            CallingConvention = CallingConvention.StdCall)]
        private static extern Int32 GetIconOfFile(
            String path, uint desiredSize, ref IntPtr phIcon);

        public static Icon GetIconOfFile(
            string path, uint desiredSize)
        {
            Int32 hr = 0;
            IntPtr hIcon = IntPtr.Zero;
            hr = GetIconOfFile(path, desiredSize, ref hIcon);
            if (hr < 0)
            {
                throw new Win32Exception(hr);
            }
            return Icon.FromHandle(hIcon);
        }


    }
}
