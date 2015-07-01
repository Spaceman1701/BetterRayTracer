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

        private TaskFactory<RenderData> taskFactory;

        public Renderer(IRenderManager renderManager, IDirectContributionModel renderModel)
        {
            this.renderManager = renderManager;
            this.renderModel = renderModel;

            this.width = renderManager.Width;
            this.height = renderManager.Height;

            taskFactory = new TaskFactory<RenderData>();
        }

        public OutputData RenderScene(Scene scene)
        {
            ISet<Task<RenderData>> results = new HashSet<Task<RenderData>>();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Vector3f rayDirection = renderManager.CalculateEyeRayDirection(x, y);
                    Vector3f rayStart = new Vector3f(x, y, 0.0f);

                    results.Add(taskFactory.StartNew(() => CastEyeRay(new Ray(rayStart, rayDirection), scene)));
                }
            }
            Task<RenderData>[] resultsArray = new Task<RenderData>[results.Count];
            results.CopyTo(resultsArray, 0);

            Task.WaitAll(resultsArray);

            BasicOutputConverter coverter = new BasicOutputConverter(1, width, height);

            RenderData[] finalData = new RenderData[resultsArray.Length];

            for (int i = 0; i < finalData.Length; i++)
            {
                finalData[i] = resultsArray[i].Result;
            }

            return coverter.DoConversion(finalData);
        }

        public RenderData CastEyeRay(Ray ray, Scene scene)
        {
            RayLifetimeManager rayManager = new RayLifetimeManager(ray, scene, renderModel);

            RenderData rayCastResult = rayManager.DoRayCast();

            if (rayCastResult == null)
            {
                return new RenderData(new Color(0, 0, 0));
            }

            return rayCastResult;
        }
    }
}
