﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class HotKey
{
    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    private int modifier;
    private int key;
    private IntPtr hWnd;
    private int id;

    public HotKey(int modifier, Keys key, Form form)
    {
        this.modifier = modifier;
        this.key = (int)key;
        this.hWnd = form.Handle;
        id = this.GetHashCode();
    }
    public override int GetHashCode(){  return key ^ hWnd.ToInt32();    }
    public bool Register()  {   return RegisterHotKey(hWnd, id, modifier, key); }
    public bool Unregiser() {   return UnregisterHotKey(hWnd, id);  }
}
