using BetterRayTrace.Render.RayTrace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterRayTrace.Math;

namespace BetterRayTrace.Render
{
    class Scene
    {
        private ISet<Light> lights;
        private ISet<IRenderObject> renderables;

        public Scene()
        {
            ResetScene();
        }

        public void ResetScene()
        {
            lights = new HashSet<Light>();
            renderables = new HashSet<IRenderObject>();
        }

        public void AddRenderObject(IRenderObject o)
        {
            renderables.Add(o);
        }

        public void RemoveRenderObject(IRenderObject o)
        {
            renderables.Remove(o);
        }

        public void AddLight(Light o)
        {
            lights.Add(o);
        }

        public void RemoveLight(Light o)
        {
            lights.Remove(o);
        }

        public ISet<Light> Lights
        {
            get { return lights; }
        }

        public ISet<IRenderObject> RenderObjects
        {
            get { return renderables; }
        }

        public RayIntersection FindFirstIntersection(Ray ray)
        {
            IList<RayIntersection> intersections = new List<RayIntersection>();
            foreach (IRenderObject o in renderables)
            {
                RayIntersection intersection = o.FindFirstIntersection(ray);
                if (intersection != null)
                {
                    intersections.Add(intersection);
                } 
            }

            RayIntersection closestIntersection = null;
            float minDistance = float.MaxValue;

            foreach (RayIntersection ri in intersections)
            {
                float distance = Vector3f.Distance(ri.Position, ray.Start);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestIntersection = ri;
                }
            }

            return closestIntersection;
        }
    }
}
