using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Math;

namespace BetterRayTrace.Render.RayTrace
{
    class Ray
    {
        private Vector3f start;
        private Vector3f direction;


        public Ray(Vector3f start, Vector3f direction)
        {
            this.start = new Vector3f(start);
            this.direction = new Vector3f(direction);
        }

        public Vector3f Start
        {
            get { return new Vector3f(start); }
        }

        public Vector3f Direction
        {
            get { return new Vector3f(direction); }
        }
    }
}
