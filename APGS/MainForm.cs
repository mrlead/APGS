using System;
using System.Drawing;
using System.Windows.Forms;
using ObjParser;
using ObjParser.Types;

namespace APGS
{
    public partial class MainForm : Form
    {
        //Константы цвета, так надо
        System.Drawing.Color black = System.Drawing.Color.Black;
        System.Drawing.Color red = System.Drawing.Color.Red;
        System.Drawing.Color white = System.Drawing.Color.White;

        public static Bitmap picture = new Bitmap(1000, 1000);
        int width_picture = picture.Width;
        int height_picture = picture.Height;
        Graphics graphics = Graphics.FromImage(picture);

        public MainForm()
        {
            InitializeComponent();
        }

        private void start_render_Click(object sender, EventArgs e)
        {
            create_model();
        }

        //создание модели проволка/полная
        public void create_model()
        {
            var obj = new Obj();
            obj.LoadObj("../../test_model/4.obj");

            if(wire_but.Checked)
            {
                //проволочный рендер
                graphics.Clear(black);
                for (int k = 0; k < obj.FaceList.Count; k++)
                {
                    int[] face = obj.FaceList[k].VertexIndexList;
                    for (int j = 0; j < 3; j++)
                    {
                        line((int)(obj.VertexList[face[j]].X), (int)(obj.VertexList[face[j]].Y), (int)(obj.VertexList[face[(j + 1) % 3]].X), (int)(obj.VertexList[face[(j + 1) % 3]].Y), picture, red); 
                    }
                }
                render.Image = picture;
                picture.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            else
            {
                //закрашенный рендер
                graphics.Clear(black);
                for (int i = 0; i < obj.FaceList.Count; i++)
                {
                    int[] face = obj.FaceList[i].VertexIndexList;
                    Vertex[] screen_coords = new Vertex[3];
                    triangle(obj.VertexList[face[0]], obj.VertexList[face[1]], obj.VertexList[face[2]], picture, red);
                }
                render.Image = picture;
                picture.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
        }

        //Отрисовка треуольников + растеризация
        public void triangle(Vertex t0, Vertex t1, Vertex t2, Bitmap bitmap, System.Drawing.Color color)
        {
            if (t0.Y == t1.Y && t0.Y == t2.Y) return;
            if (t0.Y > t1.Y) Swap(ref t0, ref t1);
            if (t0.Y > t2.Y) Swap(ref t0, ref t2);
            if (t1.Y > t2.Y) Swap(ref t1, ref t2);

            int total_height = (int)(t2.Y - t0.Y);

            for (int i = 0; i < total_height; i++)
            {
                bool second_half = i > t1.Y - t0.Y || t1.Y == t0.Y;
                int segment_height = (int)(second_half ? t2.Y - t1.Y : t1.Y - t0.Y);
                float alpha = (float)(i / total_height);
                float beta = (float)(i - (second_half ? t1.Y - t0.Y : 0)) / segment_height;
                Vertex A = t0 + (t2 - t0) * alpha;
                Vertex B = second_half ? t1 + (t2 - t1) * beta : t0 + (t1 - t0) * beta;
                if (A.X > B.X) Swap(ref A, ref B);
                for (int j = (int)(A.X); j <= B.X; j++)
                {
                    if (j < 0 || (int)(t0.Y + i) < 0)
                        break;
                    bitmap.SetPixel(j, (int)(t0.Y + i), color);
                }
            }
        }

        //Отрисовка линии алгоритмом Брезенхэма
        public void line(int x0, int y0, int x1, int y1, Bitmap image, System.Drawing.Color color)
        {
            try
            {
                bool steep = false;
                if (Math.Abs(x0 - x1) < Math.Abs(y0 - y1))
                {
                    Swap(ref x0, ref y0);
                    Swap(ref x1, ref y1);
                    steep = true;
                }
                if (x0 > x1)
                {
                    Swap(ref x0, ref x1);
                    Swap(ref y0, ref y1);
                }
                int dx = x1 - x0;
                int dy = y1 - y0;
                int derror = Math.Abs(dy) * 2;
                int error = 0;
                int y = y0;
                for (int x = x0; x <= x1; x++)
                {
                    if (y < 0 || x < 0 || x > width_picture || y > height_picture)
                        continue;
                    if (steep)
                        image.SetPixel(y, x, color);
                    else
                        image.SetPixel(x, y, color);
                    error += derror;

                    if (error > dx)
                    {
                        y += (y1 > y0 ? 1 : -1);
                        error -= dx * 2;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка во время отрисовки!");
            }

        }

        static void Swap<T>(ref T x, ref T y)
        {
            T c = x;
            x = y;
            y = c;
        }
    }
}
