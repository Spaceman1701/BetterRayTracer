using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterRayTrace.Render.Output
{
    class OutputData
    {
        private int width;
        private int height;

        private Color[,] data;

        public OutputData(int width, int height)
        {
            this.width = width;
            this.height = height;

            data = new Color[width, height];
        }

        public Color this[int x, int y] 
        {
            get { return data[x, y]; }
            set { data[x, y] = value; }
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }
    }
}
