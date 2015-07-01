using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Math;
using BetterRayTrace.Render;
using BetterRayTrace.Render.Material;

namespace BetterRayTrace.Render.RayTrace
{
    class RayIntersection
    {
        private Ray ray;
        private IRenderObject obj;
        private Vector3f normal;
        private Vector3f position;
        private MaterialData materialData;

        public RayIntersection(Ray ray, IRenderObject obj, Vector3f position, Vector3f normal, MaterialData materialData)
        {
            this.ray = ray;
            this.obj = obj;
            this.position = new Vector3f(position);
            this.normal = new Vector3f(normal);
            this.materialData = materialData;
        }

        public Ray Ray
        {
            get { return ray; }
        }

        public IRenderObject Obj
        {
            get { return obj; }
        }

        public Vector3f Normal
        {
            get { return normal; }
        }

        public Vector3f Position
        {
            get { return position; }
        }

        public MaterialData MaterialData
        {
            get { return materialData; }
        }
    }
}
