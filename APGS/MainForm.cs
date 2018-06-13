﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ObjParser;
using ObjParser.Types;
using System.Windows.Media.Media3D;
using System.Collections.Generic;

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
        static int[] z_buff;
        public int sword;
        Matrix3D MView = Matrix3D.Identity;
        List<Sword> swords;
        CameraManagment camera;
        //Конец объявления общих объектов

        public MainForm()
        {
            InitializeComponent();
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
            picture.Dispose();
            picture = new Bitmap(render.Width, render.Height);
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
            swords.Add(new Sword("../../test_model/main.obj"));
            model.Items.Clear();
            for(int s = 0; s < swords.Count; s++)
            {
                model.Items.Add("Клеймор_" + s.ToString());
            }
            model.SelectedIndex = sword;
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

        public Matrix3D Lookat(Vertex Eye, Vertex Center, Vertex Up)
        {
            Vertex CameraDirection = Vertex.normalize(Eye - Center);
            Vertex cameraRight = Vertex.normalize(Vertex.CVertex(Up, CameraDirection));
            Vertex cameraUp = Vertex.normalize(Vertex.CVertex(CameraDirection, cameraRight));
            Matrix3D MinV = Matrix3D.Identity;
            Matrix3D tr = Matrix3D.Identity;

            MinV.M11 = cameraRight.X;
            MinV.M21 = cameraUp.X;
            MinV.M31 = CameraDirection.X;
            tr.M14 = -Eye.X;

            MinV.M12 = cameraRight.Y;
            MinV.M22 = cameraUp.Y;
            MinV.M32 = CameraDirection.Y;
            tr.M24 = -Eye.Y;

            MinV.M13 = cameraRight.Z;
            MinV.M23 = cameraUp.Z;
            MinV.M33 = CameraDirection.Z;
            tr.M34 = -Eye.Z;

            return MinV * tr;
        }

        //создание модели проволка/полная
        public void create_model()
        {
            try
            {
                Matrix3D World;
                double rasterization = -1000;
                double scaling = 1;
                z_buffer_clear();
                z_buffer_func();
                clear_picture();

                for(int q = 0; q < swords.Count; q++)
                {
                    double rad_x = Math.PI * swords[q].x_angle / 180;
                    double rad_y = Math.PI * swords[q].y_angle / 180;
                    double rad_z = Math.PI * swords[q].z_angle / 180;

                    swords[q].rotate_x.M22 = Math.Cos(rad_x);
                    swords[q].rotate_x.M23 = Math.Sin(rad_x);
                    swords[q].rotate_x.M32 = -Math.Sin(rad_x);
                    swords[q].rotate_x.M33 = Math.Cos(rad_x);

                    swords[q].rotate_y.M11 = Math.Cos(rad_y);
                    swords[q].rotate_y.M13 = -Math.Sin(rad_y);
                    swords[q].rotate_y.M31 = Math.Sin(rad_y);
                    swords[q].rotate_y.M33 = Math.Cos(rad_y);

                    swords[q].rotate_z.M11 = Math.Cos(rad_z);
                    swords[q].rotate_z.M12 = Math.Sin(rad_z);
                    swords[q].rotate_z.M21 = -Math.Sin(rad_z);
                    swords[q].rotate_z.M22 = Math.Cos(rad_z);

                    for(int i = 0; i < swords[q].obj.FaceList.Count; i++)
                    {
                        int[] face = swords[q].obj.FaceList[i].VertexIndexList;

                        Vertex p1 = new Vertex();
                        Vertex p2 = new Vertex();
                        Vertex p3 = new Vertex();

                        p1 = swords[q].obj.VertexList[face[0]];
                        p2 = swords[q].obj.VertexList[face[1]];
                        p3 = swords[q].obj.VertexList[face[2]];

                        World = swords[q].Zoom * swords[q].rotate_x * swords[q].rotate_y * swords[q].rotate_z;

                        p1 = p1 * World;
                        p2 = p2 * World;
                        p3 = p3 * World;
                        p1 = p1 + swords[q].Loc;
                        p2 = p2 + swords[q].Loc;
                        p3 = p3 + swords[q].Loc;

                        //Обработка камеры
                        if(camera.create)
                        {
                            create_camera(p1, p2, p3);
                            rasterization = camera.focus;
                            scaling = camera.scale * 1.1;
                        }
                        else
                        {
                            camera.c1 = p1;
                            camera.c2 = p2;
                            camera.c3 = p3;
                        }

                        //Обработка проекции
                        if(swords[q].proj == 0)
                        {
                            camera.c1.X /= (camera.c1.Z / (rasterization) + 1);
                            camera.c1.Y /= (camera.c1.Z / (rasterization) + 1);
                            camera.c2.X /= (camera.c2.Z / (rasterization) + 1);
                            camera.c2.Y /= (camera.c2.Z / (rasterization) + 1);
                            camera.c3.X /= (camera.c3.Z / (rasterization) + 1);
                            camera.c3.Y /= (camera.c3.Z / (rasterization) + 1);
                        }

                        camera.c1.X *= scaling;
                        camera.c1.Y *= scaling;
                        camera.c1.Z *= scaling;
                        camera.c2.X *= scaling;
                        camera.c2.Y *= scaling;
                        camera.c2.Z *= scaling;
                        camera.c3.X *= scaling;
                        camera.c3.Y *= scaling;
                        camera.c3.Z *= scaling;

                        if (wire_but.Checked)
                        {
                            //проволочная модель
                            line((int)(camera.c1.X), (int)(camera.c1.Y), (int)(camera.c2.X), (int)(camera.c2.Y), picture, System.Drawing.Color.Green);
                            line((int)(camera.c2.X), (int)(camera.c2.Y), (int)(camera.c3.X), (int)(camera.c3.Y), picture, System.Drawing.Color.Green);
                            line((int)(camera.c1.X), (int)(camera.c1.Y), (int)(camera.c3.X), (int)(camera.c3.Y), picture, System.Drawing.Color.Green);
                        }
                        else
                        {
                            //закрашенная модель
                            triangle(camera.c1, camera.c2, camera.c3, picture, System.Drawing.Color.Green);
                        }
                    }
                }
            }
            catch(Exception)
            {
                message(false, "Ошибка создания модели");
            }
        }

        public void create_camera(Vertex v1, Vertex v2, Vertex v3)
        {
            List<Matrix3D> MS = new List<Matrix3D>(3);

            Matrix3D coords1 = new Matrix3D();
            coords1.M11 = v1.X;
            coords1.M12 = 1;
            coords1.M13 = 1;
            coords1.M14 = 1;

            coords1.M21 = v1.Y;
            coords1.M22 = 1;
            coords1.M23 = 1;
            coords1.M24 = 1;

            coords1.M31 = v1.Z;
            coords1.M32 = 1;
            coords1.M33 = 1;
            coords1.M34 = 1;

            coords1.OffsetX = 1;
            coords1.OffsetY = 1;
            coords1.OffsetZ = 1;
            coords1.M44 = 1;

            MS.Add(coords1);

            coords1 = new Matrix3D();
            coords1.M11 = v2.X;
            coords1.M12 = 1;
            coords1.M13 = 1;
            coords1.M14 = 1;

            coords1.M21 = v2.Y;
            coords1.M22 = 1;
            coords1.M23 = 1;
            coords1.M24 = 1;


            coords1.M31 = v2.Z;
            coords1.M32 = 1;
            coords1.M33 = 1;
            coords1.M34 = 1;

            coords1.OffsetX = 1;
            coords1.OffsetY = 1;
            coords1.OffsetZ = 1;
            coords1.M44 = 1;

            MS.Add(coords1);

            coords1 = new Matrix3D();
            coords1.M11 = v3.X;
            coords1.M12 = 1;
            coords1.M13 = 1;
            coords1.M14 = 1;

            coords1.M21 = v3.Y;
            coords1.M22 = 1;
            coords1.M23 = 1;
            coords1.M24 = 1;

            coords1.M31 = v3.Z;
            coords1.M32 = 1;
            coords1.M33 = 1;
            coords1.M34 = 1;

            coords1.OffsetX = 1;
            coords1.OffsetY = 1;
            coords1.OffsetZ = 1;
            coords1.M44 = 1;

            MS.Add(coords1);

            MView = Lookat(camera.Eye, camera.Center, camera.Up);
            camera.c1 = new Vertex(MView * MS[0]);
            camera.c2 = new Vertex(MView * MS[1]);
            camera.c3 = new Vertex(MView * MS[2]);
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
            if (swords.Count != 0)
            {
                swords[sword].proj = 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void radio_par_CheckedChanged(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].proj = 0;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void zoom_val_Scroll(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].Zoom.M11 = zoom_val.Value / 10.0;
                swords[sword].Zoom.M22 = zoom_val.Value / 10.0;
                swords[sword].Zoom.M33 = zoom_val.Value / 10.0;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].x_angle += 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].x_angle -= 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].y_angle += 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].y_angle -= 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].z_angle += 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].z_angle -= 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].Loc.M11 -= 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].Loc.M11 += 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].Loc.M22 -= 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].Loc.M22 += 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].Loc.M33 -= 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].Loc.M33 += 1;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (swords.Count != 0)
            {
                swords[sword].Zoom.M11 = 1;
                swords[sword].Zoom.M22 = 1;
                swords[sword].Zoom.M33 = 1;
                swords[sword].Loc.M11 = 1;
                swords[sword].Loc.M22 = 1;
                swords[sword].Loc.M33 = 1;
                swords[sword].x_angle = 0;
                swords[sword].y_angle = 0;
                swords[sword].z_angle = 0;
                create_model();
            }
            else
            {
                MessageBox.Show("Создайте модель!");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            model.Items.Clear();
            swords.RemoveAt(sword);
            for (int i = 0; i < swords.Count; i++)
            {
                model.Items.Add("object " + i.ToString());
            }
            if (model.Items.Count != 0)
            {
                model.SelectedIndex = 0;
                create_model();
            }
            else
            {
                clear_picture();
            }
        }

        public void camera_data()
        {
            try
            {
                camera = new CameraManagment();
                camera.create = true;
                camera.Eye.X = Double.Parse(x_eye.Text);
                camera.Eye.Y = Double.Parse(y_eye.Text);
                camera.Eye.Z = Double.Parse(z_eye.Text);

                camera.Center.X = Double.Parse(x_center.Text);
                camera.Center.Y = Double.Parse(y_center.Text);
                camera.Center.Z = Double.Parse(z_center.Text);
                message(true, "Камера создана");
                create_model();
            }
            catch(Exception)
            {
                message(false, "Ошибка при изменении камеры");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            camera = new CameraManagment();
            camera.create = true;
            x_eye.Text = camera.Eye.X.ToString();
            y_eye.Text = camera.Eye.Y.ToString();
            z_eye.Text = camera.Eye.Z.ToString();
            x_center.Text = camera.Center.X.ToString();
            y_center.Text = camera.Center.Y.ToString();
            z_center.Text = camera.Center.Z.ToString();
            message(true, "Камера создана");
            create_model();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            camera.create = false;
            x_eye.Text = "";
            y_eye.Text = "";
            z_eye.Text = "";
            x_center.Text = "";
            y_center.Text = "";
            z_center.Text = "";
            message(false, "Камера удалена");
            create_model();
        }

        private void x_eye_TextChanged(object sender, EventArgs e)
        {
            camera_data();
        }

        private void y_eye_TextChanged(object sender, EventArgs e)
        {
            camera_data();
        }

        private void z_eye_TextChanged(object sender, EventArgs e)
        {
            camera_data();
        }

        private void x_center_TextChanged(object sender, EventArgs e)
        {
            camera_data();
        }

        private void y_center_TextChanged(object sender, EventArgs e)
        {
            camera_data();
        }

        private void z_center_TextChanged(object sender, EventArgs e)
        {
            camera_data();
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }
    }
}