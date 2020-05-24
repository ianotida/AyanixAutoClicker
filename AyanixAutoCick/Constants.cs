using System;
using System.Drawing;
using System.Runtime.InteropServices;

public class Constants
{
    //modifiers
    public const int NOMOD = 0x0000;
    public const int ALT = 0x0001;
    public const int CTRL = 0x0002;
    public const int SHIFT = 0x0004;
    public const int WIN = 0x0008;

    //windows message id for hotkey
    public const int WM_HOTKEY_MSG_ID = 0x0312;

    public const uint WM_LBUTTONDOWN = 0x0201;
    public const uint WM_LBUTTONUP = 0x0202;

    public const int MOUSEEVENTF_MOVE = 0x0001;
    public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
    public const int MOUSEEVENTF_LEFTUP = 0x0004;
    public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
    public const int MOUSEEVENTF_RIGHTUP = 0x0010;
    public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
    public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
    public const int MOUSEEVENTF_ABSOLUTE = 0x8000;

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
        public int Height;
        public int Width;
    }

}


public class ClickOnPointTool
{

    [DllImport("user32.dll")]
    static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

    [DllImport("user32.dll")]
    internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

#pragma warning disable 649
    internal struct INPUT
    {
        public UInt32 Type;
        public MOUSEKEYBDHARDWAREINPUT Data;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct MOUSEKEYBDHARDWAREINPUT
    {
        [FieldOffset(0)]
        public MOUSEINPUT Mouse;
    }

    internal struct MOUSEINPUT
    {
        public Int32 X;
        public Int32 Y;
        public UInt32 MouseData;
        public UInt32 Flags;
        public UInt32 Time;
        public IntPtr ExtraInfo;
    }
}