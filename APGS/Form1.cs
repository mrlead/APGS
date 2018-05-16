using System;
using System.Drawing;
using System.Windows.Forms;

namespace APGS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_render_Click(object sender, EventArgs e)
        {
            Color red = Color.Red;
            Color white = Color.White;
            Color black = Color.Black;

            Bitmap picture = new Bitmap(render.Width, render.Height);
            Graphics graphics = Graphics.FromImage(picture);
            graphics.Clear(black);
            line(13, 20, 80, 40, picture, white);
            line(20, 13, 40, 80, picture, red);
            line(80, 40, 13, 20, picture, red);
            render.Image = picture;
        }

        void line(int x0, int y0, int x1, int y1, Bitmap image, Color color)
        {
            for (int x = x0; x < x1; x++)
            {
                float t = (x - x0) / (float)(x1 - x0);
                int y = y0 * (1 - (int)t) + y1 * (int)t;
                image.SetPixel(x, y, color);
            }
        }
    }
}
