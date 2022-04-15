using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using AyanixAutoCick.Models;
using static Constants;

public class SysUI
{
    // ------------------------------------------------------------------------------------------------------------------------------------------
    // SCREEN COLOR HANDLER
    // ------------------------------------------------------------------------------------------------------------------------------------------
    [DllImport("gdi32.dll")]
    static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

    [DllImport("user32.dll")]
    static extern IntPtr GetDC(IntPtr hwnd);

    [DllImport("user32.dll")]
    static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

    public static Color GetPixelColor(int x, int y)
    {
        IntPtr hdc = GetDC(IntPtr.Zero);
        uint pixel = GetPixel(hdc, x, y);
        ReleaseDC(IntPtr.Zero, hdc);
        Color color = Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
        return color;
    }

    public static bool MatchColor(Color a, Color b, int tolerance)
    {
        int sum = 0;
        int diff;

        diff = a.R - b.R;
        sum += (1 + diff * diff) * a.A / 256;

        diff = a.G - b.G;
        sum += (1 + diff * diff) * a.A / 256;

        diff = a.B - b.B;
        sum += (1 + diff * diff) * a.A / 256;

        diff = a.A - b.A;
        sum += diff * diff;

        return (sum <= tolerance * tolerance * 4);
    }


    // ------------------------------------------------------------------------------------------------------------------------------------------
    // WINDOW HANDLER
    // ------------------------------------------------------------------------------------------------------------------------------------------
    [DllImport("user32.dll")]
    static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll")]
    static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll", SetLastError = true)]
    static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    [DllImport("user32.dll", SetLastError = true)]
    static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);


    public static WindowInfo GetActiveWindow()
    {
        WindowInfo WnInfo = new WindowInfo();

        const int nChars = 256;
        StringBuilder Buff = new StringBuilder(nChars);

        IntPtr handle = GetForegroundWindow();

        WnInfo.Title = GetWindowText(handle, Buff, nChars) > 0 ? Buff.ToString() : "";
        
        RECT rect = new RECT();
        GetWindowRect(handle, out rect);

        WnInfo.Top = rect.Top;
        WnInfo.Left = rect.Left;
        WnInfo.Height = rect.Bottom - rect.Top;
        WnInfo.Width = rect.Right - rect.Left;

        return WnInfo;
    }

    public static bool FindWin(string processName)
    {
        Process[] p = Process.GetProcessesByName(processName);
        return p.Length > 0 ? true : false;
    }

    public static void FucosWin(string processName)
    {
        Process[] p = Process.GetProcessesByName(processName);

        // Activate the first application we find with this name
        if (p.Length > 0)
        {
            SetForegroundWindow(p[0].MainWindowHandle);
        }
    }

    public static void ResizeWin(string processName, int iX, int iY, int cx, int cy)
    {
        Process[] p = Process.GetProcessesByName(processName);
       
        if (p.Length > 0)
        {
            SetWindowPos(p[0].MainWindowHandle, IntPtr.Zero, iX, iY, cx, cy, 0x0004);          
        }
    }

    public static void PrintWin(string processName, string sPath)
    {
        Process[] p = Process.GetProcessesByName(processName);
       
        if (p.Length > 0)
        {
            RECT rc = new RECT();
            GetWindowRect(p[0].MainWindowHandle, out rc);

            rc.Height = rc.Bottom - rc.Top;
            rc.Width = rc.Right - rc.Left;

            var bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format32bppArgb);
            Graphics Gpx = Graphics.FromImage(bmp);
            Gpx.CopyFromScreen(rc.Left, rc.Top, 0, 0, new Size(rc.Width, rc.Height), CopyPixelOperation.SourceCopy);
            Gpx.Dispose(); 

            bmp.Save(sPath, ImageFormat.Png);
        }       
    }



    // ------------------------------------------------------------------------------------------------------------------------------------------
    // CLICK HANDLER
    // ------------------------------------------------------------------------------------------------------------------------------------------

    [return: MarshalAs(UnmanagedType.Bool)]
    [DllImport("user32.dll")]
    static extern bool PostMessage(IntPtr WindowHandle, int Msg, IntPtr wParam, IntPtr lParam);


    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

 
    public static void LeftClick(int pX,int pY)
    {
        Cursor.Position = new Point(pX, pY);
        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)pX, (uint)pY, 0, 0);
    }

 



}
