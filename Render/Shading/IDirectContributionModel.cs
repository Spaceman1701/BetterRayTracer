using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Math;
using BetterRayTrace.Render.Material;
using BetterRayTrace.Render.RayTrace;

namespace BetterRayTrace.Render.Shading
{
    interface IDirectContributionModel
    {
        Vector3f CalculateDirectShading(RayIntersection data, Light l);
        float CalculateIndirectDiffuseContribution(RayIntersection data, Scene scene);
        float CalculateIndirectSpecularContribution(RayIntersection data, Scene scene);
        Vector3f CalculateSpecularReflectionDirection(RayIntersection data, Scene scene);
    }
}
