using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
