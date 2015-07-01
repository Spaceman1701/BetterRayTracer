using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BetterRayTrace.Math
{
    class MathUtil
    {
        private MathUtil() { }

        public static float Sqrt(float f)
        {
            return (float)System.Math.Sqrt(f);
        }

        public static float Pow(float f, float p)
        {
            return (float)System.Math.Pow(f, p);
        }

        public static float Max(float a, float b)
        {
            return System.Math.Max(a, b);
        }
    }
}
