using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterRayTrace.Render
{
    class RenderData
    {
        private Color color;

        public RenderData(Color color)
        {
            this.color = color;
        }

        public Color Color
        {
            get { return color; }
        }
    }
}
