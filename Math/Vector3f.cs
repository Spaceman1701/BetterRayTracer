using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterRayTrace.Math
{
    class Vector3f
    {
        public float x;
        public float y;
        public float z;

        public Vector3f(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3f()
            : this(0.0f, 0.0f, 0.0f)
        {}

        public Vector3f(Vector3f vec)
            : this(vec.x, vec.y, vec.z)
        {}

        public Vector3f(float f)
            : this(f, f, f)
        {}

        public float Mag2()
        {
            return (x * x) + (y * y) + (z * z);
        }

        public float Mag()
        {
            return MathUtil.Sqrt(Mag2());
        }

        public Vector3f Normalize()
        {
            float mag = Mag();
            x /= mag;
            y /= mag;
            z /= mag;
            return this;
        }

        public override string ToString()
        {
            return "Vector3 <" + x + ", " + y + ", " + z + ">";
        }

        public static Vector3f ReflectVector(Vector3f vec, Vector3f reflector)
        {
            Vector3f norm = new Vector3f(reflector).Normalize();
            return vec - (2 * (vec * norm) * norm);
        }

        public static float Distance2(Vector3f a, Vector3f b)
        {
            return (a - b).Mag2();
        }

        public static float Distance(Vector3f a, Vector3f b)
        {
            return (a - b).Mag();
        }

        public float this[int i] //For easy loop access
        {
            get
            {
                if (i > 2 || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                switch (i)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    case 2:
                        return z;
                }
                return 0;
            }
            set
            {
                if (i > 2 || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                switch (i)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    case 2:
                        z = value;
                        break;
                }
            }
        }

        public static bool operator ==(Vector3f a, Vector3f b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }

        public static bool operator !=(Vector3f a, Vector3f b)
        {
            return !(a == b);
        }

        public static Vector3f operator +(Vector3f a, Vector3f b) 
        {
            return new Vector3f(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3f operator -(Vector3f a, Vector3f b)
        {
            return a + (-b); //Add negative vector
        }

        public static Vector3f operator -(Vector3f a)
        {
            return new Vector3f(-a.x, -a.y, -a.z);
        }

        public static float operator *(Vector3f a, Vector3f b) //Dot product
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }

        public static Vector3f operator *(Vector3f vec, float f)
        {
            return new Vector3f(vec.x * f, vec.y * f, vec.z * f);
        }

        public static Vector3f operator *(float f, Vector3f vec)
        {
            return vec * f;
        }

       
    }
}
