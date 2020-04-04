using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ayx.AudioVisualization.Core.Drawer
{
    public class SimpleBitmap
    {
        public byte[] Bitmap { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        private int GetIndex(int x, int y)
        {
            return x + y * Width;
        }

        public void DrawPixel(int x, int y, byte colorIndex)
        {

        }

        public void DrawVerticalLine(int x, int y1, int y2, byte colorIndex)
        {

        }

        public void DrawHorizontalLine(int x1, int x2, int y, byte colorIndex)
        {

        }

        public void DrawRectangle(int left, int top, int width, int height, byte colorIndex)
        {

        }
    }
}
