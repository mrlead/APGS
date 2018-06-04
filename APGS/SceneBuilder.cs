using System;
using System.Drawing;
using System.Windows.Forms;

namespace APGS
{
    public partial class SceneBuilder : Form
    {
        public Color color;
        public int width, height;

        MainForm form;

        public SceneBuilder(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
                color = colorDialog1.Color;
            }
        }

        //создание сцены
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                height = Convert.ToInt32(height_val.Text);
                width = Convert.ToInt32(width_val.Text);
                if (width >= 500 && width <= 1000 && height >= 500 && height <= 1000)
                {
                    if (color != null)
                    {
                        color = Color.Black;
                        form.scene_managment(width, height, color);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали цвет, по умолчанию чёрный");
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректную высоту и ширину!");
                }
            }catch (Exception)
            {
                MessageBox.Show("Ошибка при создании сцены!");
            }
        }
    }
}
