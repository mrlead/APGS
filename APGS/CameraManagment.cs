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

        public void MoveCameraY(Vertex cameraFront, bool W)
        {
            if (W == true)
            {
                Eye.X += speed * Up.X;
                Eye.Y += speed * Up.Y;
                Eye.Z += speed * Up.Z;

                Center.X += speed * Up.X;
                Center.Y += speed * Up.Y;
                Center.Z += speed * Up.Z;
            }
            else
            {
                Eye.X -= speed * Up.X;
                Eye.Y -= speed * Up.Y;
                Eye.Z -= speed * Up.Z;

                Center.X -= speed * Up.X;
                Center.Y -= speed * Up.Y;
                Center.Z -= speed * Up.Z;
            }
        }

        public void MoveCameraZ(Vertex cameraFront, bool Plus)
        {
            if (Plus == true)
            {
                Eye.X += speed * cameraFront.X;
                Eye.Y += speed * cameraFront.Y;
                Eye.Z += speed * cameraFront.Z;

                Center.X += speed * cameraFront.X;
                Center.Y += speed * cameraFront.Y;
                Center.Z += speed * cameraFront.Z;
            }
            else
            {
                Eye.X -= speed * cameraFront.X;
                Eye.Y -= speed * cameraFront.Y;
                Eye.Z -= speed * cameraFront.Z;

                Center.X -= speed * cameraFront.X;
                Center.Y -= speed * cameraFront.Y;
                Center.Z -= speed * cameraFront.Z;
            }
        }

        public void RotateCamX(Vertex cameraFront, bool R)
        {
            if (R == true)
                Yaw += 10;
            else
                Yaw -= 10;
            RotateCam(cameraFront);
            Center = Vertex.normalize(cameraFront) + Eye;
        }

        public void RotateCamY(Vertex cameraFront, bool W)
        {
            if (W == true)
                Tangage += 10;
            else
                Tangage -= 10;

            if (Tangage > 89.0f)
                Tangage = 89.0f;
            if (Tangage < -89.0f)
                Tangage = -89.0f;

            RotateCam(cameraFront);
            Center = Vertex.normalize(cameraFront) + Eye;
        }

        public void RotateCamZ(Vertex cameraFront, bool flag)
        {
            double rad = Math.PI * (1) / 180;
            if (flag)
            {
                Carene++;
                Up.X += Math.Cos(rad);
                Up.Z += Math.Sin(rad);
            }
            else
            {
                Carene--;
                Up.X -= Math.Cos(rad);
                Up.Z -= Math.Sin(rad);
            }
        }

        public void MoveCameraXPan(Vertex cameraFront, bool R)
        {
            if (R == true)
            {
                Eye.X -= Vertex.normalize(Vertex.CVertex(cameraFront, Up)).X * speed;
                Eye.Y -= Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Y * speed;
                Eye.Z -= Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Z * speed;
            }
            else
            {
                Eye.X += Vertex.normalize(Vertex.CVertex(cameraFront, Up)).X * speed;
                Eye.Y += Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Y * speed;
                Eye.Z += Vertex.normalize(Vertex.CVertex(cameraFront, Up)).Z * speed;

            }
        }

        public void MoveCameraYPan(bool W)
        {
            if (W == true)
            {
                Eye.X += speed * Up.X;
                Eye.Y += speed * Up.Y;
                Eye.Z += speed * Up.Z;
            }
            else
            {
                Eye.X -= speed * Up.X;
                Eye.Y -= speed * Up.Y;
                Eye.Z -= speed * Up.Z;
            }
        }
    }
}