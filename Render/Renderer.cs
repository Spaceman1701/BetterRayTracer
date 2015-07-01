using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Render.Shading;
using BetterRayTrace.Render.Output;
using BetterRayTrace.Math;
using BetterRayTrace.Render.RayTrace;

namespace BetterRayTrace.Render
{
    class Renderer
    {
        private IRenderManager renderManager;
        private IDirectContributionModel renderModel;

        private int width;
        private int height;

        public Renderer(IRenderManager renderManager, IDirectContributionModel renderModel)
        {
            this.renderManager = renderManager;
            this.renderModel = renderModel;

            this.width = renderManager.Width;
            this.height = renderManager.Height;
        }

        public OutputData RenderScene(Scene scene)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Vector3f rayDirection = renderManager.CalculateEyeRayDirection(x, y);

                }
            }

            return null;
        }

        public RenderData CastEyeRay(Ray ray)
        {
            return null;
        }
    }
}
