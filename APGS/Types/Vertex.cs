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

        public override string ToString()
        {
            return string.Format("v {0} {1} {2}", X, Y, Z);
        }
    }
}
