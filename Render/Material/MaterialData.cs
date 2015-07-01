using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BetterRayTrace.Render;

namespace BetterRayTrace.Render.Material
{
    class MaterialData
    {
        private Color diffuseColor;
        private Color specularColor;

        private float specular;
        private float diffuse;
        private float ambient;
        private float shininess;

        public MaterialData(Color diffuseColor, Color specularColor, float specular, float diffuse, float ambient, float shininess)
        {
            this.diffuseColor = diffuseColor;
            this.specularColor = specularColor;

            this.specular = specular;
            this.diffuse = diffuse;
            this.ambient = ambient;
            this.shininess = shininess;
        }

        public Color DiffuseColor
        {
            get { return diffuseColor; }
        }

        public Color SpecularColor
        {
            get { return specularColor; }
        }

        public float Specular
        {
            get { return specular; }
        }

        public float Diffuse
        {
            get { return diffuse; }
        }

        public float Ambient
        {
            get { return ambient; }
        }

        public float Shininess
        {
            get { return shininess; }
        }

    }
}
