using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Math;

namespace BetterRayTrace.Render
{
    class Color
    {
        private Vector3f data;

        public Color(float r, float g, float b)
        {
            data = new Vector3f(r, g, b);
        }

        public Color(float grayscale)
        {
            data = new Vector3f(grayscale);
        }

        public Color(Vector3f src)
        {
            this.data = new Vector3f(src);
        }

        public Color(Color c) : this(c.R, c.G, c.B) { }

        public Color Trim()
        {
            for (int i = 0; i < 3; i++)
            {
                if (data[i] > 1)
                {
                    data[i] = 1;
                }
                else if (data[i] < 0)
                {
                    data[i] = 0;
                }
            }

            return this;
        }

        public Vector3f AsVector3()
        {
            return new Vector3f(data);
        }

        public int[] AsIntArray() //Returns as int array with values 0-255
        {
            Color outputColor = new Color(this).Trim();

            int r = (int)outputColor.R * 255;
            int g = (int)outputColor.G * 255;
            int b = (int)outputColor.B * 255;

            return new int[] { r, g, b };
        }

        public float R
        {
            get { return data.x; }
            set { data.x = value; }
        }

        public float G
        {
            get { return data.y; }
            set { data.y = value; }
        }

        public float B
        {
            get { return data.z; }
            set { data.z = value; }
        }
    }
}
