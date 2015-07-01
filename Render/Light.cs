using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Math;

namespace BetterRayTrace.Render
{
    class Light
    {
        private Vector3f position;
        private Color color;
        private float intensity;

        public Light(Vector3f position, Color color, float intensity)
        {
            this.position = new Vector3f(position);
            this.color = new Color(color);
            this.intensity = intensity;
        }

        public Vector3f Position
        {
            get { return new Vector3f(position); }
            set { position = new Vector3f(value); }
        }

        public Color Color
        {
            get { return new Color(color); }
            set { color = new Color(color); }
        }

        public float Intensity
        {
            get { return intensity; }
            set { intensity = value; }
        }
    }
}
