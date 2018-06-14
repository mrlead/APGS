namespace APGS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.render = new System.Windows.Forms.PictureBox();
            this.label_status = new System.Windows.Forms.Label();
            this.start_render = new System.Windows.Forms.Button();
            this.wire_but = new System.Windows.Forms.RadioButton();
            this.raster_but = new System.Windows.Forms.RadioButton();
            this.alarma_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.model = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radio_par = new System.Windows.Forms.RadioButton();
            this.radio_center = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.zoom_val = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.x_center = new System.Windows.Forms.TextBox();
            this.y_center = new System.Windows.Forms.TextBox();
            this.z_center = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.x_eye = new System.Windows.Forms.TextBox();
            this.y_eye = new System.Windows.Forms.TextBox();
            this.z_eye = new System.Windows.Forms.TextBox();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.render)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoom_val)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // render
            // 
            this.render.Location = new System.Drawing.Point(12, 12);
            this.render.Name = "render";
            this.render.Size = new System.Drawing.Size(1000, 500);
            this.render.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.render.TabIndex = 0;
            this.render.TabStop = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 404);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 13);
            this.label_status.TabIndex = 1;
            // 
            // start_render
            // 
            this.start_render.Enabled = false;
            this.start_render.Location = new System.Drawing.Point(6, 98);
            this.start_render.Name = "start_render";
            this.start_render.Size = new System.Drawing.Size(131, 23);
            this.start_render.TabIndex = 2;
            this.start_render.Text = "Создать модель";
            this.start_render.UseVisualStyleBackColor = true;
            this.start_render.Click += new System.EventHandler(this.start_render_Click);
            // 
            // wire_but
            // 
            this.wire_but.AutoSize = true;
            this.wire_but.Checked = true;
            this.wire_but.Location = new System.Drawing.Point(2, 35);
            this.wire_but.Name = "wire_but";
            this.wire_but.Size = new System.Drawing.Size(133, 17);
            this.wire_but.TabIndex = 3;
            this.wire_but.TabStop = true;
            this.wire_but.Text = "Проволочная модель";
            this.wire_but.UseVisualStyleBackColor = true;
            // 
            // raster_but
            // 
            this.raster_but.AutoSize = true;
            this.raster_but.Location = new System.Drawing.Point(2, 58);
            this.raster_but.Name = "raster_but";
            this.raster_but.Size = new System.Drawing.Size(135, 17);
            this.raster_but.TabIndex = 4;
            this.raster_but.TabStop = true;
            this.raster_but.Text = "Закрашенная модель";
            this.raster_but.UseVisualStyleBackColor = true;
            // 
            // alarma_lbl
            // 
            this.alarma_lbl.AutoSize = true;
            this.alarma_lbl.Location = new System.Drawing.Point(15, 685);
            this.alarma_lbl.Name = "alarma_lbl";
            this.alarma_lbl.Size = new System.Drawing.Size(0, 13);
            this.alarma_lbl.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Создать сцену";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить сцену";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить сцену";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 518);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сцена";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 113);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(110, 23);
            this.button16.TabIndex = 10;
            this.button16.Text = "Загрузить сцену";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.model);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(140, 518);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 188);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Объект";
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(6, 19);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(201, 21);
            this.model.TabIndex = 14;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(201, 120);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(193, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Перемещение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(126, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "Z ->";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(7, 65);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "<- Z";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(126, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Y ->";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "<- Y";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(126, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "X ->";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "<- X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.button15);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(193, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вращение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(126, 65);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Z ->";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 65);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(61, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "<- Z";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(126, 36);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(61, 23);
            this.button12.TabIndex = 9;
            this.button12.Text = "Y ->";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(7, 36);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(61, 23);
            this.button13.TabIndex = 8;
            this.button13.Text = "<- Y";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(126, 7);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(61, 23);
            this.button14.TabIndex = 7;
            this.button14.Text = "X ->";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(7, 7);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(61, 23);
            this.button15.TabIndex = 6;
            this.button15.Text = "<- X";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radio_par);
            this.tabPage3.Controls.Add(this.radio_center);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(193, 94);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Проецирование";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radio_par
            // 
            this.radio_par.AutoSize = true;
            this.radio_par.Location = new System.Drawing.Point(49, 48);
            this.radio_par.Name = "radio_par";
            this.radio_par.Size = new System.Drawing.Size(99, 17);
            this.radio_par.TabIndex = 1;
            this.radio_par.TabStop = true;
            this.radio_par.Text = "Параллельное";
            this.radio_par.UseVisualStyleBackColor = true;
            this.radio_par.CheckedChanged += new System.EventHandler(this.radio_par_CheckedChanged);
            // 
            // radio_center
            // 
            this.radio_center.AutoSize = true;
            this.radio_center.Checked = true;
            this.radio_center.Location = new System.Drawing.Point(49, 25);
            this.radio_center.Name = "radio_center";
            this.radio_center.Size = new System.Drawing.Size(92, 17);
            this.radio_center.TabIndex = 0;
            this.radio_center.TabStop = true;
            this.radio_center.Text = "Центральное";
            this.radio_center.UseVisualStyleBackColor = true;
            this.radio_center.Click += new System.EventHandler(this.radio_center_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.zoom_val);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(193, 94);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Масштабирование";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // zoom_val
            // 
            this.zoom_val.Location = new System.Drawing.Point(6, 23);
            this.zoom_val.Maximum = 16;
            this.zoom_val.Minimum = 1;
            this.zoom_val.Name = "zoom_val";
            this.zoom_val.Size = new System.Drawing.Size(181, 45);
            this.zoom_val.TabIndex = 2;
            this.zoom_val.TabStop = false;
            this.zoom_val.Value = 8;
            this.zoom_val.Scroll += new System.EventHandler(this.zoom_val_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button18);
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.wire_but);
            this.groupBox3.Controls.Add(this.raster_but);
            this.groupBox3.Controls.Add(this.start_render);
            this.groupBox3.Location = new System.Drawing.Point(360, 518);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 188);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отрисовка";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(6, 128);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(131, 23);
            this.button18.TabIndex = 6;
            this.button18.Text = "Удалить модель";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 157);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(132, 23);
            this.button17.TabIndex = 5;
            this.button17.Text = "Исходное положение";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.x_center);
            this.groupBox4.Controls.Add(this.y_center);
            this.groupBox4.Controls.Add(this.z_center);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.x_eye);
            this.groupBox4.Controls.Add(this.y_eye);
            this.groupBox4.Controls.Add(this.z_eye);
            this.groupBox4.Controls.Add(this.button32);
            this.groupBox4.Controls.Add(this.button31);
            this.groupBox4.Controls.Add(this.button25);
            this.groupBox4.Controls.Add(this.button26);
            this.groupBox4.Controls.Add(this.button27);
            this.groupBox4.Controls.Add(this.button28);
            this.groupBox4.Controls.Add(this.button29);
            this.groupBox4.Controls.Add(this.button30);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button21);
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Controls.Add(this.button23);
            this.groupBox4.Controls.Add(this.button24);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(509, 518);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 188);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Камера";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(440, 141);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 13);
            this.label26.TabIndex = 110;
            this.label26.Text = "Z";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(440, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 109;
            this.label27.Text = "Y";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(440, 55);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 108;
            this.label28.Text = "X";
            // 
            // x_center
            // 
            this.x_center.Location = new System.Drawing.Point(409, 73);
            this.x_center.Name = "x_center";
            this.x_center.Size = new System.Drawing.Size(79, 20);
            this.x_center.TabIndex = 105;
            this.x_center.TextChanged += new System.EventHandler(this.x_center_TextChanged);
            // 
            // y_center
            // 
            this.y_center.Location = new System.Drawing.Point(409, 116);
            this.y_center.Name = "y_center";
            this.y_center.Size = new System.Drawing.Size(79, 20);
            this.y_center.TabIndex = 106;
            this.y_center.TextChanged += new System.EventHandler(this.y_center_TextChanged);
            // 
            // z_center
            // 
            this.z_center.Location = new System.Drawing.Point(409, 157);
            this.z_center.Name = "z_center";
            this.z_center.Size = new System.Drawing.Size(79, 20);
            this.z_center.TabIndex = 107;
            this.z_center.TextChanged += new System.EventHandler(this.z_center_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(341, 142);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 104;
            this.label21.Text = "Z";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(341, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 103;
            this.label22.Text = "Y";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(341, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 102;
            this.label23.Text = "X";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(413, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 101;
            this.label24.Text = "Точка цели:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(307, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 13);
            this.label25.TabIndex = 100;
            this.label25.Text = "Точка зрения:";
            // 
            // x_eye
            // 
            this.x_eye.Location = new System.Drawing.Point(307, 73);
            this.x_eye.Name = "x_eye";
            this.x_eye.Size = new System.Drawing.Size(79, 20);
            this.x_eye.TabIndex = 97;
            this.x_eye.TextChanged += new System.EventHandler(this.x_eye_TextChanged);
            // 
            // y_eye
            // 
            this.y_eye.Location = new System.Drawing.Point(307, 116);
            this.y_eye.Name = "y_eye";
            this.y_eye.Size = new System.Drawing.Size(79, 20);
            this.y_eye.TabIndex = 98;
            this.y_eye.TextChanged += new System.EventHandler(this.y_eye_TextChanged);
            // 
            // z_eye
            // 
            this.z_eye.Location = new System.Drawing.Point(307, 157);
            this.z_eye.Name = "z_eye";
            this.z_eye.Size = new System.Drawing.Size(79, 20);
            this.z_eye.TabIndex = 99;
            this.z_eye.TextChanged += new System.EventHandler(this.z_eye_TextChanged);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(173, 26);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 23);
            this.button32.TabIndex = 20;
            this.button32.Text = "Удалить";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(34, 25);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 23);
            this.button31.TabIndex = 19;
            this.button31.Text = "Добавить";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(220, 154);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(61, 23);
            this.button25.TabIndex = 18;
            this.button25.Text = "Z ->";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(153, 154);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(61, 23);
            this.button26.TabIndex = 17;
            this.button26.Text = "<- Z";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(220, 125);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(61, 23);
            this.button27.TabIndex = 16;
            this.button27.Text = "Y ->";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(153, 125);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(61, 23);
            this.button28.TabIndex = 15;
            this.button28.Text = "<- Y";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(220, 96);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(61, 23);
            this.button29.TabIndex = 14;
            this.button29.Text = "X ->";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(153, 96);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(61, 23);
            this.button30.TabIndex = 13;
            this.button30.Text = "<- X";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Вращение";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(72, 154);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(61, 23);
            this.button19.TabIndex = 11;
            this.button19.Text = "Z ->";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(5, 154);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(61, 23);
            this.button20.TabIndex = 10;
            this.button20.Text = "<- Z";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(72, 125);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(61, 23);
            this.button21.TabIndex = 9;
            this.button21.Text = "Y ->";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(5, 125);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(61, 23);
            this.button22.TabIndex = 8;
            this.button22.Text = "<- Y";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(72, 96);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(61, 23);
            this.button23.TabIndex = 7;
            this.button23.Text = "X ->";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(5, 96);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(61, 23);
            this.button24.TabIndex = 6;
            this.button24.Text = "<- X";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перемещение";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 714);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.alarma_lbl);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.render);
            this.Name = "MainForm";
            this.Text = "АПГС";
            ((System.ComponentModel.ISupportInitialize)(this.render)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoom_val)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox render;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button start_render;
        private System.Windows.Forms.RadioButton wire_but;
        private System.Windows.Forms.RadioButton raster_but;
        private System.Windows.Forms.Label alarma_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radio_par;
        private System.Windows.Forms.RadioButton radio_center;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TrackBar zoom_val;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox x_center;
        private System.Windows.Forms.TextBox y_center;
        private System.Windows.Forms.TextBox z_center;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox x_eye;
        private System.Windows.Forms.TextBox y_eye;
        private System.Windows.Forms.TextBox z_eye;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
    }
}

