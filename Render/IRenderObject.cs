using BetterRayTrace.Render.RayTrace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Math;

namespace BetterRayTrace.Render
{
    interface IRenderObject
    {
        RayIntersection FindFirstIntersection(Ray r);
        Vector3f Position
        {
            get;
            set;
        }
    }
}
