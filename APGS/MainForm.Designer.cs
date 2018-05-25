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
            ((System.ComponentModel.ISupportInitialize)(this.render)).BeginInit();
            this.SuspendLayout();
            // 
            // render
            // 
            this.render.Location = new System.Drawing.Point(12, 12);
            this.render.Name = "render";
            this.render.Size = new System.Drawing.Size(968, 485);
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
            this.start_render.Location = new System.Drawing.Point(472, 585);
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
            this.wire_but.Location = new System.Drawing.Point(592, 568);
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
            this.raster_but.Location = new System.Drawing.Point(592, 592);
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
            this.alarma_lbl.Location = new System.Drawing.Point(12, 590);
            this.alarma_lbl.Name = "alarma_lbl";
            this.alarma_lbl.Size = new System.Drawing.Size(0, 13);
            this.alarma_lbl.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 620);
            this.Controls.Add(this.alarma_lbl);
            this.Controls.Add(this.raster_but);
            this.Controls.Add(this.wire_but);
            this.Controls.Add(this.start_render);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.render);
            this.Name = "MainForm";
            this.Text = "АПГС";
            ((System.ComponentModel.ISupportInitialize)(this.render)).EndInit();
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
    }
}

