using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APGS
{
    public partial class SceneBuilder : Form
    {

        MainForm main;

        public SceneBuilder()
        {
            InitializeComponent();
        }

        //создание сцены
        public SceneBuilder(int width, int height, Color color)
        {
           /* main.GetPictureBox().Width = width;
            main.GetPictureBox().Height = height;
            main.GetPictureBox().BackColor = color;*/
        }

        //сохранение сцены
        public void saveScene()
        {

        }

        //удаление сцены
        public void deleteScene()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
            }
        }
    }
}
