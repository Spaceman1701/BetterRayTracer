using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Math;

namespace BetterRayTrace.Render
{
    class OrthoRenderManager : IRenderManager
    {

        private Vector3f eyeDirection;

        private int width;
        private int height;

        public OrthoRenderManager(Vector3f eyeDirection, int width, int height)
        {
            this.eyeDirection = new Vector3f(eyeDirection).Normalize();

            this.width = width;
            this.height = height;
        }

        public Vector3f CalculateEyeRayDirection(int x, int y)
        {
            return EyeDirection;
        }

        public Vector3f EyeDirection
        {
            get { return new Vector3f(eyeDirection); }
            set { eyeDirection = new Vector3f(value).Normalize(); }
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
