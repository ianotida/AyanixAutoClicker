using System.Drawing;


namespace AyanixAutoCick.Models
{
    //public class ClickInfo
    //{ 
    //    public Color Color { get; set; }

    //    public int Click_X { get; set; }
    //    public int Click_Y { get; set; }    
    
    //    public int Counter { get; set; }
    //    public int Delay_ms { get; set; }
    //}

    public class ClickInfo2
    {
        public Color Color { get; set; }

        public int Pixel_X { get; set; }
        public int Pixel_Y { get; set; }

        public int Click_X { get; set; }
        public int Click_Y { get; set; }

        public int Counter { get; set; }

        public int CounterColor { get; set; }
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
