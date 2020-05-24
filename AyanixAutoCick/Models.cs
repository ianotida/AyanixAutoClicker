﻿using System.Drawing;


namespace AyanixAutoCick.Models
{
    public class ClickInfo
    { 
        public Color Color { get; set; }

        public int Click_X { get; set; }
        public int Click_Y { get; set; }    
    
        public int App_Name { get; set; }
        public int App_X { get; set; }
        public int App_Y { get; set; }  

        public int Counter { get; set; }
        public int Delay_ms { get; set; }
    }



    public class WindowInfo
    {
        public string Title { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }

}
