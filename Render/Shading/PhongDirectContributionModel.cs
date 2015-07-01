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
    class PhongDirectContributionModel : IDirectContributionModel
    {
        public Vector3f CalculateDirectShading(RayIntersection data, Light l)
        {
            Vector3f eyeVec = new Vector3f(-data.Position).Normalize(); //Eye position must be at (0,0,0)

            MaterialData md = data.MaterialData;

            //Vector3f outputColor = new Vector3f();

            //foreach (Light l in scene.Lights) //Foreach light, compute direct diffuse reflection and direct specular highlight
            //{
            Vector3f norm = data.Normal;

            Vector3f lVec = (data.Position - l.Position).Normalize();

            float lambert = (lVec * norm) * 0.3f * md.Diffuse;

            //Specular
            Vector3f reflect = -Vector3f.ReflectVector(lVec, norm);
            float spec = md.Specular * MathUtil.Pow(MathUtil.Max(reflect * eyeVec, 0.0f), 1);

            //outputColor = (spec * md.SpecularColor.AsVector3()) + (lambert * md.DiffuseColor.AsVector3());
            //}
            return new Vector3f((spec * md.SpecularColor.AsVector3()) + (lambert * md.DiffuseColor.AsVector3()));
        }
        public float CalculateIndirectDiffuseContribution(RayIntersection data, Scene scene)
        {
            return data.MaterialData.Diffuse;
        }
        public float CalculateIndirectSpecularContribution(RayIntersection data, Scene scene)
        {
            return data.MaterialData.Specular;
        }
        public Vector3f CalculateSpecularReflectionDirection(RayIntersection data, Scene scene)
        {
            Vector3f normal = new Vector3f(data.Normal).Normalize();
            Vector3f eyeVec = new Vector3f(-data.Position).Normalize(); //Eye position is always (0,0,0)

            return Vector3f.ReflectVector(eyeVec, normal).Normalize();
        }
    }
}
