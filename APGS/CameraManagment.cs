using ObjParser.Types;
using System;

namespace APGS
{
    class CameraManagment
    {
        public Vertex Eye;
        public Vertex Center;
        public Vertex Up;
        public string Name = "Camera";
        public double focus = 1000;
        public int scale = 1;
        public Vertex c1;
        public Vertex c2;
        public Vertex c3;
        public bool create;
        public double speed = 2f;

        public double Tangage = 0;
        public double Yaw = -90;
        public double Carene = 0;


        public CameraManagment()
        {
            Eye = new Vertex(0, 10, 1);
            Center = new Vertex(0, 10, 0);
            Up = new Vertex(0, 1, 0);
        }

        public void RotateCam(Vertex cameraFront)
        {
            double rad = Math.PI * (Tangage) / 180;
            double rad2 = Math.PI * (Yaw) / 180;
            double rad3 = Math.PI * (Carene) / 180;
            cameraFront.X = Math.Cos(rad) * Math.Cos(rad2);
            cameraFront.Y = Math.Sin(rad);
            cameraFront.Z = Math.Cos(rad) * Math.Sin(rad2);
        }

        public void MoveCameraX(Vertex cameraFront, bool R)
        {
            if (R == true)
            {
                Eye.X -= Vertex.normalize(Vertex.CVertex(cameraFront, Up)).X * speed;
                Eye.Y -= Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Y * speed;
                Eye.Z -= Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Z * speed;

                Center.X -= Vertex.normalize(Vertex.CVertex(cameraFront, Up)).X * speed;
                Center.Y -= Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Y * speed;
                Center.Z -= Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Z * speed;
            }
            else
            {
                Eye.X += Vertex.normalize(Vertex.CVertex(cameraFront, Up)).X * speed;
                Eye.Y += Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Y * speed;
                Eye.Z += Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Z * speed;

                Center.X += Vertex.normalize(Vertex.CVertex(cameraFront, Up)).X * speed;
                Center.Y += Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Y * speed;
                Center.Z += Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Z * speed;
            }
        }
    }
}