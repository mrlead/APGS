using System;
using System.Globalization;
using System.Windows.Media.Media3D;

namespace ObjParser.Types
{
    public class Vertex : IType
    {
        public const int MinimumDataLength = 4;
        public const string Prefix = "v";

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public int Index { get; set; }

        public Vertex(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vertex() {}

        public Vertex(Matrix3D M)
        {
            X = M.M11;
            Y = M.M21;
            Z = M.M31;
        }

        public void LoadFromStringArray(string[] data)
        {
            if (data.Length < MinimumDataLength)
                throw new ArgumentException("Input array must be of minimum length " + MinimumDataLength, "data");

            if (!data[0].ToLower().Equals(Prefix))
                throw new ArgumentException("Data prefix must be '" + Prefix + "'", "data");

            bool success;

            double x, y, z;

            success = double.TryParse(data[1], NumberStyles.Any, CultureInfo.InvariantCulture, out x);
            if (!success) throw new ArgumentException("Could not parse X parameter as double");

            success = double.TryParse(data[2], NumberStyles.Any, CultureInfo.InvariantCulture, out y);
            if (!success) throw new ArgumentException("Could not parse Y parameter as double");

            success = double.TryParse(data[3], NumberStyles.Any, CultureInfo.InvariantCulture, out z);
            if (!success) throw new ArgumentException("Could not parse Z parameter as double");

            X = x;
            Y = y;
            Z = z;
        }

        public static Vertex operator -(Vertex c1, Vertex c2)
        {
            return new Vertex { X = c1.X - c2.X, Y = c1.Y - c2.Y, Z = c1.Z - c2.Z };
        }

        public static Vertex operator *(Vertex c1, Vertex c2)
        {
            return new Vertex { X = c1.X * c2.X, Y = c1.Y * c2.Y, Z = c1.Z * c2.Z };
        }


        public static Vertex operator *(Vertex c1, double c2)
        {
            return new Vertex { X = c1.X * c2, Y = c1.Y * c2, Z = c1.Z * c2 };
        }

        public static Vertex operator +(Vertex c1, Vertex c2)
        {
            return new Vertex { X = c1.X + c2.X, Y = c1.Y + c2.Y, Z = c1.Z + c2.Z };
        }

        public static Vertex operator *(Vertex c1, Matrix3D World)
        {
            return new Vertex
            {
                X = World.M11 * c1.X + World.M12 * c1.Y + World.M13 * c1.Z + World.M14,
                Y = World.M21 * c1.X + World.M22 * c1.Y + World.M23 * c1.Z + World.M24,
                Z = World.M31 * c1.X + World.M32 * c1.Y + World.M33 * c1.Z + World.M34
            };
        }

        public static Vertex operator +(Vertex c1, Matrix3D World)
        {
            return new Vertex
            {
                X = World.M11 + c1.X,
                Y = World.M22 + c1.Y,
                Z = World.M33 + c1.Z
            };
        }

        public static double Normalize(Vertex p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y + p.Z * p.Z);
        }
        public static Vertex normalize(Vertex p)
        {
            Vertex P = new Vertex();
            if (p.X == 0 && p.Y == 0 && p.Z == 0)
            {
                P.X = 0;
                P.Y = 0;
                P.Z = 0;
            }
            else
            {
                P.X = p.X * (1 / Normalize(p));
                P.Y = p.Y * (1 / Normalize(p));
                P.Z = p.Z * (1 / Normalize(p));
            }
            return P;
        }
        public static Vertex operator ^(Vertex c1, Vertex c2)
        {
            return new Vertex { X = Math.Pow(c1.X, c2.X), Y = Math.Pow(c1.Y, c2.Y), Z = Math.Pow(c1.Z, c2.Z) };
        }

        public static Vertex CVertex(Vertex a, Vertex b)
        {
            Vertex A = new Vertex();
            A.X = a.Y * b.Z - a.Z * b.Y;
            A.Y = a.Z * b.X - a.X * b.Z;
            A.Z = a.X * b.Y - a.Y * b.X;
            return A;
        }

        public override string ToString()
        {
            return string.Format("v {0} {1} {2}", X, Y, Z);
        }
    }
}
