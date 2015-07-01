using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Math;
using BetterRayTrace.Render.RayTrace;
using BetterRayTrace.Render.Material;

namespace BetterRayTrace.Render
{
    class Sphere : IRenderObject
    {
        private Vector3f position;
        private float radius;
        private MaterialData materialData;

        public Sphere(Vector3f position, float radius, Color color)
        {
            this.position = position;
            this.radius = radius;
            materialData = new MaterialData(color, new Color(1.0f, 1.0f, 1.0f), 0.3f, 0.3f, 0.3f, 0.3f);
        }

        public RayIntersection FindFirstIntersection(Ray ray)
        {
            Vector3f dist = ray.Start - position;
            float a = ray.Direction * ray.Direction;
            float b = 2.0f * (dist * ray.Direction);
            float c = (dist * dist) - (radius * radius);

            float d = b * b - (4.0f * a * c); //Discrimant of quadraditic equation

            if (d < 0.0f)
            {
                return null; //No collision
            }

            float t = (-b - d) / (2 * a);
            Vector3f collision = (t * ray.Direction) + ray.Start;

            return new RayIntersection(ray, this, collision, (ray.Start), materialData);
        }

        public Vector3f Position
        {
            get { return position; }
            set { position = value; }
        }

        private Vector3f CalculateSurfaceNormal(Vector3f point)
        {
            return new Vector3f(position - point).Normalize();
        }
    }
}
