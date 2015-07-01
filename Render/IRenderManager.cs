using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Math;

namespace BetterRayTrace.Render
{
    interface IRenderManager
    {
        Vector3f CalculateEyeRayDirection(int x, int y);

        int Width
        {
            get;
        }
        int Height
        {
            get;
        }
    }
}
