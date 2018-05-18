using System;
using System.Drawing;
using System.Windows.Forms;
using ObjParser;

namespace APGS
{
    public partial class MainForm : Form
    {
        //Константы цвета, знаю, что можно напрямую, но мне так удобно)
        Color red = Color.Red;
        Color white = Color.White;
        Color black = Color.Black;

        public MainForm()
        {
            InitializeComponent();
        }

        private void start_render_Click(object sender, EventArgs e)
        {
            Bitmap picture = new Bitmap(render.Width, render.Height);
            Graphics graphics = Graphics.FromImage(picture);
            graphics.Clear(black);
            picture.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Obj obj = new Obj();
            obj.LoadObj("../../test_model/1_obj.obj");
            for(int i = 0; i < obj.FaceList.Count; i++)
            {
                int[] face = obj.FaceList[i].VertexIndexList;
                for (int j = 0; j < 3; j++)
                {
                    int x0 = (int)(obj.VertexList[face[j]].X + 1.0) * 3;
                    int y0 = (int)(obj.VertexList[face[j]].Y + 1.0) * 3;
                    int x1 = (int)(obj.VertexList[face[(j + 1) % 3]].X + 1.0) * 3;
                    int y1 = (int)(obj.VertexList[face[(j + 1) % 3]].Y + 1.0) * 3;
                    line(x0 + 100, y0 + 100, x1 + 100, y1 + 100, picture, white);
                }
            }
            render.Image = picture;
        }


        //Отрисовка линии алгоритмом Брезенхэма
        public void line(int x0, int y0, int x1, int y1, Bitmap image, Color color)
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
                //ErrorLabel.Text = "Произошла ошибка во время отрисовки!";
            }

        }

        private void Swap(ref int x0, ref int y0)
        {
            int c = x0;
            x0 = y0;
            y0 = c;
        }
    }
}
