﻿using System;
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

        public static Bitmap picture;
        //Vertex m2v;
        const int depth = 255;
        static int[] z_buff;

        public MainForm()
        {
            InitializeComponent();
        }

        public PictureBox GetPictureBox()
        {
            return render;
        }

        public void scene_managment(int width, int height, System.Drawing.Color background)
        {
            render.Width = width;
            render.Height = height;
            render.BackColor = background;
            picture = new Bitmap(width, height);
            start_render.Enabled = true;
        }

        private void clear_picture()
        {
            Graphics graphics = Graphics.FromImage(picture);
            graphics.Clear(render.BackColor);
        }

        //Создание сцены
        private void button1_Click(object sender, EventArgs e)
        {
            SceneBuilder sc = new SceneBuilder(this);
            sc.Show();
        }

        //z-buffer
        private void z_buffer_func()
        {
            z_buff = new int[render.Width * render.Height];
            for (int i = 0; i < render.Width * render.Height; i++)
            {
                z_buff[i] = Numeric_clone<int>.MinValue;
            }
        }

        private void z_buffer_clear()
        {
            Array.Clear(z_buff, 0, z_buff.Length);
        }

        private void start_render_Click(object sender, EventArgs e)
        {
            z_buffer_func();
            clear_picture();
            create_model();
        }

        private void message(bool flag, string s)
        {
            if(flag)
            {
                alarma_lbl.BackColor = System.Drawing.Color.Green;
                alarma_lbl.Text = s;
            }
            else
            {
                alarma_lbl.BackColor = System.Drawing.Color.Red;
                alarma_lbl.Text = s;
            }
        }

        //создание модели проволка/полная
        public void create_model()
        {
            var obj = new Obj();
            obj.LoadObj("../../test_model/4.obj");

            if(wire_but.Checked)
            {
                //проволочный рендер
                for (int k = 0; k < obj.FaceList.Count; k++)
                {
                    int[] face = obj.FaceList[k].VertexIndexList;
                    for (int j = 0; j < 3; j++)
                    {
                        line((int)(obj.VertexList[face[j]].X + render.Width / 2), (int)(obj.VertexList[face[j]].Y + render.Height / 2), (int)(obj.VertexList[face[(j + 1) % 3]].X + render.Width / 2), (int)(obj.VertexList[face[(j + 1) % 3]].Y + render.Height / 2), picture, red); 
                    }
                }
                render.Image = picture;
                picture.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            else
            {
                //закрашенный рендер

                //сдвиг модели на центр сцены
                for (int i = 0; i < obj.VertexList.Count; i++)
                {
                    Vertex t0 = obj.VertexList[i];

                    t0.X += render.Width / 2;
                    t0.Y += render.Height / 2;
                    t0.Z += 0;
                }

                for (int i = 0; i < obj.FaceList.Count; i++)
                {
                    int[] face = obj.FaceList[i].VertexIndexList;
                    Vertex[] world_coords = new Vertex[3];
                    for (int j = 0; j < 3; j++)
                    {
                        Vertex v = obj.VertexList[face[j]];
                        world_coords[j] = v;
                    }
                    triangle(obj.VertexList[face[0]], obj.VertexList[face[1]], obj.VertexList[face[2]], picture, red);
                }

                render.Image = picture;
                picture.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
        }

        //Отрисовка треуольников + растеризация
        public void triangle(Vertex t0, Vertex t1, Vertex t2, Bitmap bitmap, System.Drawing.Color color)
        { 
            try
            { 
                if (t0.Y == t1.Y && t0.Y == t2.Y) return;
                if (t0.Y > t1.Y)
                    Swap(ref t0, ref t1);
                if (t0.Y > t2.Y)
                    Swap(ref t0, ref t2);
                if (t1.Y > t2.Y)
                    Swap(ref t1, ref t2);
                double total_height = t2.Y - t0.Y;
                for (int i = 0; i < total_height; i++)
                {
                    bool sec_h = i > t1.Y - t0.Y || t1.Y == t0.Y;
                    double seg_h = sec_h ? t2.Y - t1.Y : t1.Y - t0.Y;
                    double alpha = (double)i / total_height;

                    double beta = (double)(i - (sec_h ? t1.Y - t0.Y : 0)) / seg_h;

                    Vertex A = t0 + (t2 - t0) * alpha;

                    Vertex B = sec_h ? t1 + (t2 - t1) * beta : t0 + (t1 - t0) * beta;

                    if (A.X > B.X)
                    {
                        Swap(ref A, ref B);
                    }
                    for (double j = A.X; j <= B.X; j++)
                    {
                        double phi = B.X == A.X ? 1 : (double)(j - A.X) / (double)(B.X - A.X);
                        Vertex C = new Vertex();

                        C = A + (B - A) * phi;

                        int idx = (int)((int)C.X + (int)C.Y * render.Width);

                        if ((int)C.X >= render.Width || (int)C.Y >= render.Height || (int)C.X < 0) continue;
                        if (z_buff[idx] < (int)C.Z)
                        {
                            z_buff[idx] = (int)C.Z;
                            bitmap.SetPixel((int)C.X, (int)C.Y, color);

                        }
                    }
                }
                message(true, "Отрисовка готова");
            }
            catch (Exception)
            {
                message(false, "Возникла проблема при отрисовке объекта");
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
                int derror2 = Math.Abs(dy) * 2;
                int error2 = 0;
                int y = y0;
                for (int x = x0; x <= x1; x++)
                {
                    if (steep)
                    {
                        image.SetPixel(y, x, color);
                    }
                    else
                    {
                        image.SetPixel(x, y, color);
                    }
                    error2 += derror2;

                    if (error2 > dx)
                    {
                        y += (y1 > y0 ? 1 : -1);
                        error2 -= dx * 2;
                    }
                }
                message(true, "Отрисовка готова");
            }
            catch (Exception)
            {
                message(false, "Возникла проблема при отрисовке объекта");
            }
        }

        //Работа с преобразованиями
        private Vertex m2v(Matrix m)
        {
            Vertex s = null;
            s.X = m.element[0, 0] / m.element[3, 0];
            s.Y = m.element[1, 0] / m.element[3, 0];
            s.Z = m.element[2, 0] / m.element[3, 0];
            return s;
        }

        Matrix v2m(Vertex v)
        {
            Matrix m = new Matrix(4, 1);
            m.element[0, 0] = v.X;
            m.element[1, 0] = v.Y;
            m.element[2, 0] = v.Z;
            m.element[3, 0] = 1.0;
            return m;
        }

        Matrix viewport(int x, int y, int w, int h)
        {
            Matrix m = new Matrix(4);
            m.element[0, 3] = x + w / 2;
            m.element[1, 3] = y + h / 2;
            m.element[2, 3] = depth / 2;

            m.element[0, 0] = w / 2;
            m.element[1, 1] = h / 2;
            m.element[2, 2] = depth / 2;
            return m;
        }

        Matrix translation(Vertex v)
        {
            Matrix tr = new Matrix(4);
            tr.element[0, 3] = v.X;
            tr.element[1, 3] = v.Y;
            tr.element[2, 3] = v.Z;
            return tr;
        }

        Matrix zoom(float factor)
        {
            Matrix z = new Matrix(4);
            z.element[0, 0] = z.element[1, 1] = z.element[2, 2] = factor;
            return z;
        }

        Matrix rotation_x(float cosangle, float sinangle)
        {
            Matrix r = new Matrix(4);
            r.element[1, 1] = r.element[2, 2] = cosangle;
            r.element[1, 2] = -sinangle;
            r.element[2, 1] = sinangle;
            return r;
        }

        Matrix rotation_y(float cosangle, float sinangle)
        {
            Matrix r = new Matrix(4);
            r.element[0, 0] = r.element[2, 2] = cosangle;
            r.element[0, 2] = sinangle;
            r.element[2, 0] = -sinangle;
            return r;
        }

        Matrix rotation_z(float cosangle, float sinangle)
        {
            Matrix r = new Matrix(4);
            r.element[0, 0] = r.element[1, 1] = cosangle;
            r.element[0, 1] = -sinangle;
            r.element[1, 0] = sinangle;
            return r;
        }

        //Функция обмена данными координат
        static void Swap<T>(ref T x, ref T y)
        {
            T c = x;
            x = y;
            y = c;
        }

        //сохранение сцены
        private void button2_Click(object sender, EventArgs e)
        {
            //потом...
        }

        //удаление сцены
        private void button3_Click(object sender, EventArgs e)
        {
            render.Height = 0;
            render.Width = 0;
            render.BackColor = white;
            z_buffer_clear();
            start_render.Enabled = false;
            picture.Dispose();
        }
    }
}
