using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string ToString()
        {
            return string.Format("v {0} {1} {2}", X, Y, Z);
        }

        public static Vertex difference_vertex(Vertex a, Vertex b)
        {
            Vertex A = new Vertex();
            A.X = a.X - b.X;
            A.Y = a.Y - b.Y;
            A.Z = a.Z - b.Z;
            return A;
        }

        public static Vertex summa_vertex(Vertex a, Vertex b)
        {
            Vertex A = new Vertex();
            A.X = a.X + b.X;
            A.Y = a.Y + b.Y;
            A.Z = a.Z + b.Z;
            return A;
        }

        public static Vertex multiplication_vertex(Vertex a, Vertex b)
        {
            Vertex A = new Vertex();
            A.X = a.X * b.X;
            A.Y = a.Y * b.Y;
            A.Z = a.Z * b.Z;
            return A;
        }

        public static Vertex multiplication_vertex(Vertex a, double b)
        {
            Vertex A = new Vertex();
            A.X = a.X * b;
            A.Y = a.Y * b;
            A.Z = a.Z * b;
            return A;
        }

        public static Vertex cross_vertex(Vertex a, Vertex b)
        {
            Vertex A = new Vertex();
            //  A.X = a.Y * b.Z - a.Z * b.Y;
            // A.Y = a.Z * b.X - a.X * b.Z;
            //  A.Z = a.X * b.Y - a.Y * b.X;

            A.X = a.Y * b.Z - a.Z * b.Y;
            A.Y = a.Z * b.X - a.X * b.Z;
            A.Z = a.X * b.Y - a.Y * b.X;

            return A;
        }


        public static double norm(Vertex a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }

        public static Vertex normalize(Vertex a)
        {
            Vertex A = new Vertex();

            if (a.X == 0 && a.Y == 0 && a.Z == 0)
            {
                A.X = 0;
                A.Y = 0;
                A.Z = 0;
            }
            else
            {
                A.X = a.X * (1 / norm(a));
                A.Y = a.Y * (1 / norm(a));
                A.Z = a.Z * (1 / norm(a));
            }
            return A;
        }
    }
}
