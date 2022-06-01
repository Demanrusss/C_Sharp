using System;
using System.Runtime.InteropServices;

namespace AnimationWindow
{
    internal class Win32Iface
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, 
            int width, int height, bool repaint);
    }
}
