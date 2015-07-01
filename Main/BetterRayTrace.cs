using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Render;
using BetterRayTrace.Render.Shading;
using BetterRayTrace.Render.Output;

namespace BetterRayTrace.Main
{
    class BetterRayTrace
    {
        private const int width = 640;
        private const int height = 640;

        
        public static void Main()
        {
            BetterRayTrace app = new BetterRayTrace();
            app.Run();
        }

        public void Run()
        {
            Renderer renderer = new Renderer(new OrthoRenderManager(new Math.Vector3f(0, 0, 1), width, height), new PhongDirectContributionModel());

            Scene scene = new Scene();
            scene.AddRenderObject(new Sphere(new Math.Vector3f(320, 320, 650), 150, new Color(1, 0, 1)));
            scene.AddRenderObject(new Sphere(new Math.Vector3f(320, 500, 800), 150, new Color(1, 0, 1)));
            OutputData data = renderer.RenderScene(scene);

            ImageOutput imageOut = new ImageOutput(width, height, data);

            imageOut.WriteOutput(@"C:\users\Ethan\Desktop\RayTraceSceneTest.png");
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
