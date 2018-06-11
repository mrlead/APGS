﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ObjParser;
using ObjParser.Types;
using System.Windows.Media.Media3D;

namespace APGS
{
    public partial class MainForm : Form
    {
        //Константы цвета, так надо
        System.Drawing.Color black = System.Drawing.Color.Black;
        System.Drawing.Color red = System.Drawing.Color.Red;
        System.Drawing.Color white = System.Drawing.Color.White;
        System.Drawing.Color green = System.Drawing.Color.Green;
        //Конец объявления констант

        //Общие объекты
        public static Bitmap picture;
        const int depth = 255;
        static int[] z_buff;
        Obj obj = new Obj();
        //Конец объявления общих объектов

        //Объекты для преобразований
        double x_angle = 0;
        double y_angle = 0;
        double z_angle = 0;
        int proj = 0;
        int zoom_value = 2;
        Matrix3D Zoom = Matrix3D.Identity;
        Matrix3D Loc = Matrix3D.Identity;
        Matrix3D rotate_x = Matrix3D.Identity;
        Matrix3D rotate_y = Matrix3D.Identity;
        Matrix3D rotate_z = Matrix3D.Identity;
        //Конец объявления объектов преобразования

        public MainForm()
        {
            InitializeComponent();
            Zoom.M11 = 1;
            Zoom.M22 = 1;
            Zoom.M33 = 1;
            Loc.M11 = 0;
            Loc.M22 = 0;
            Loc.M33 = 0;
        }

        //Ссылка на объект для управления вне класса
        public PictureBox GetPictureBox()
        {
            return render;
        }

        //Создание сцены
        public void scene_managment(int width, int height, System.Drawing.Color background)
        {
            render.Width = width;
            render.Height = height;
            render.BackColor = background;
            picture = new Bitmap(width, height);
            start_render.Enabled = true;
        }

        //Очистка bitmap
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

        //Инициализация z-buffer
        private void z_buffer_func()
        {
            z_buff = new int[render.Width * render.Height];
            for (int i = 0; i < render.Width * render.Height; i++)
            {
                z_buff[i] = Numeric_clone<int>.MinValue;
            }
        }

        //Очитска z-buffer
        private void z_buffer_clear()
        {
            Array.Clear(z_buff, 0, z_buff.Length);
        }

        //Запуск отрисовки
        private void start_render_Click(object sender, EventArgs e)
        {
            z_buffer_func();
            clear_picture();
            create_model();
        }

        //Функция вывода сообщений в статус бар
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
            obj.LoadObj("../../test_model/main.obj");

            z_buffer_clear();
            z_buffer_func();

            double rad_x = Math.PI * x_angle / 180;
            double rad_y = Math.PI * y_angle / 180;
            double rad_z = Math.PI * z_angle / 180;

            rotate_x.M22 = Math.Cos(rad_x);
            rotate_x.M23 = Math.Sin(rad_x);
            rotate_x.M32 = -Math.Sin(rad_x);
            rotate_x.M33 = Math.Cos(rad_x);

            rotate_y.M11 = Math.Cos(rad_y);
            rotate_y.M13 = -Math.Sin(rad_y);
            rotate_y.M31 = Math.Sin(rad_y);
            rotate_y.M33 = Math.Cos(rad_y);

            rotate_z.M11 = Math.Cos(rad_z);
            rotate_z.M12 = Math.Sin(rad_z);
            rotate_z.M21 = -Math.Sin(rad_z);
            rotate_z.M22 = Math.Cos(rad_z);

            double rasterization = -1000;
            double scaling = 1;

            Matrix3D World;

            if (wire_but.Checked)
            {
                //проволочный рендер
                for (int i = 0; i < obj.FaceList.Count; i++)
                {
                    int[] face = obj.FaceList[i].VertexIndexList;
                    for (int j = 0; j < 3; j++)
                    {
                        Vertex p1 = new Vertex();
                        Vertex p2 = new Vertex();

                        p1.X = (obj.VertexList[face[j]].X);
                        p1.Y = (obj.VertexList[face[j]].Y);
                        p1.Z = (obj.VertexList[face[j]].Z);

                        p2.X = obj.VertexList[face[(j + 1) % 3]].X;
                        p2.Y = obj.VertexList[face[(j + 1) % 3]].Y;
                        p2.Z = obj.VertexList[face[(j + 1) % 3]].Z;

                        World = Zoom * rotate_x * rotate_y * rotate_z;

                        p1 = (p1 * World) + Loc;
                        p2 = (p2 * World) + Loc;

                        if(proj == 0)
                        {
                            p1.X /= (p1.Z / (rasterization) + 1);
                            p1.Y /= (p1.Z / (rasterization) + 1);
                            p1.Z /= (p1.Z / (rasterization) + 1);
                            p2.X /= (p2.Z / (rasterization) + 1);
                            p2.Y /= (p2.Z / (rasterization) + 1);
                            p2.Z /= (p2.Z / (rasterization) + 1);
                        }

                        p1.X *= scaling;
                        p1.Y *= scaling;
                        p1.Z *= scaling;
                        p2.X *= scaling;
                        p2.Y *= scaling;
                        p2.Z *= scaling;

                        //line((int)(obj.VertexList[face[j]].X + render.Width / 2), (int)(obj.VertexList[face[j]].Y + render.Height / 2), (int)(obj.VertexList[face[(j + 1) % 3]].X + render.Width / 2), (int)(obj.VertexList[face[(j + 1) % 3]].Y + render.Height / 2), picture, red); 
                        line((int)(p1.X) + 200, (int)(p1.Y) + render.Height / 2, (int)(p2.X) + 200, (int)(p2.Y) + render.Height / 2, picture, red);
                    }
                }
                render.Image = picture;
                picture.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            else
            {
                //закрашенный рендер
                for (int i = 0; i < obj.FaceList.Count; i++)
                {
                    int[] face = obj.FaceList[i].VertexIndexList;

                    Vertex p1 = new Vertex();
                    Vertex p2 = new Vertex();
                    Vertex p3 = new Vertex();

                    p1 = obj.VertexList[face[0]];
                    p2 = obj.VertexList[face[1]];
                    p3 = obj.VertexList[face[2]];

                    World = Zoom * rotate_x * rotate_y * rotate_z;

                    p1 = p1 * World;
                    p2 = p2 * World;
                    p3 = p3 * World;
                    p1 = p1 + Loc;
                    p2 = p2 + Loc;
                    p3 = p3 + Loc;

                    if (proj == 0)
                    {
                        p1.X /= (p1.Z / (rasterization) + 1);
                        p1.Y /= (p1.Z / (rasterization) + 1);
                        p2.X /= (p2.Z / (rasterization) + 1);
                        p2.Y /= (p2.Z / (rasterization) + 1);
                        p3.X /= (p3.Z / (rasterization) + 1);
                        p3.Y /= (p3.Z / (rasterization) + 1);
                    }

                    p1.X *= scaling;
                    p1.Y *= scaling;
                    p1.Z *= scaling;
                    p2.X *= scaling;
                    p2.Y *= scaling;
                    p2.Z *= scaling;
                    p3.X *= scaling;
                    p3.Y *= scaling;
                    p3.Z *= scaling;

                    triangle(p1, p2, p3, picture, red);
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
                    double alpha = i / total_height;

                    double beta = (i - (sec_h ? t1.Y - t0.Y : 0)) / seg_h;

                    Vertex A = t0 + (t2 - t0) * alpha;

                    Vertex B = sec_h ? t1 + (t2 - t1) * beta : t0 + (t1 - t0) * beta;

                    if (A.X > B.X)
                    {
                        Swap(ref A, ref B);
                    }
                    for (double j = A.X; j <= B.X; j++)
                    {
                        double phi = B.X == A.X ? 1 : (j - A.X) / (B.X - A.X);
                        Vertex C = new Vertex();

                        C = A + (B - A) * phi;

                        int idx = ((int)C.X + (int)C.Y * render.Width);

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
                    if (y < 0 || x < 0 || x >= render.Width || y >= render.Height)
                        continue;
                    if (steep)
                        image.SetPixel(y, x, color);
                    else
                        image.SetPixel(x, y, color);
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

        //Функция обмена данными координат
        void Swap<T>(ref T x, ref T y)
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

        //Загрузка сцены
        private void button16_Click(object sender, EventArgs e)
        {
            //завтра...
            //дедлайн 14.06, я в ****...
        }

        private void radio_center_Click(object sender, EventArgs e)
        {
            proj = 0;
            clear_picture();
            create_model();
        }

        private void radio_par_CheckedChanged(object sender, EventArgs e)
        {
            proj = 1;
            clear_picture();
            create_model();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Zoom.M11 = zoom_val.Value / 10.0;
            Zoom.M22 = zoom_val.Value / 10.0;
            Zoom.M33 = zoom_val.Value / 10.0;
            clear_picture();
            create_model();
        }

        private void zoom_val_Scroll(object sender, EventArgs e)
        {
            Zoom.M11 = zoom_val.Value / 10.0;
            Zoom.M22 = zoom_val.Value / 10.0;
            Zoom.M33 = zoom_val.Value / 10.0;
            clear_picture();
            create_model();
        }
    }
}