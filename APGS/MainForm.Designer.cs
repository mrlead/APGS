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
            this.button17 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.ComboBox();
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
            this.start_render.Location = new System.Drawing.Point(34, 112);
            this.start_render.Name = "start_render";
            this.start_render.Size = new System.Drawing.Size(75, 23);
            this.start_render.TabIndex = 2;
            this.start_render.Text = "Рендер";
            this.start_render.UseVisualStyleBackColor = true;
            this.start_render.Click += new System.EventHandler(this.start_render_Click);
            // 
            // wire_but
            // 
            this.wire_but.AutoSize = true;
            this.wire_but.Checked = true;
            this.wire_but.Location = new System.Drawing.Point(4, 41);
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
            this.raster_but.Location = new System.Drawing.Point(6, 75);
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
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(140, 518);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 148);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Объект";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(7, 19);
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
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(7, 146);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(132, 23);
            this.button17.TabIndex = 5;
            this.button17.Text = "Исходное положение";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Объект";
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(140, 685);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(214, 21);
            this.model.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 714);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox model;
    }
}

