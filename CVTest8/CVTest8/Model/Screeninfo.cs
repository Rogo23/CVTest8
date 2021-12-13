using System;
using System.Collections.Generic;
using System.Text;
using CVTest8.Enums;

namespace CVTest8.Model
{
    public class ScreenInfo
    {
        public ScreenInfo(int width, int height, ScreenSizes screenSize)
        {
            this.ScreenSize = screenSize;
            Width = width;
            Height = height;
        }

        public ScreenSizes ScreenSize { get; set; }
        public int Width { get; }
        public int Height { get; }
    }
}
