namespace Prak01
{
    partial class Form1
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
            this.quit_button = new System.Windows.Forms.Button();
            this.size_button = new System.Windows.Forms.Button();
            this.rectangle_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.input_button = new System.Windows.Forms.Button();
            this.circle_button = new System.Windows.Forms.Button();
            this.calc_button = new System.Windows.Forms.Button();
            this.reverse_button = new System.Windows.Forms.Button();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // quit_button
            // 
            this.quit_button.BackColor = System.Drawing.Color.LightCoral;
            this.quit_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quit_button.ForeColor = System.Drawing.Color.DarkRed;
            this.quit_button.Location = new System.Drawing.Point(12, 364);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(159, 44);
            this.quit_button.TabIndex = 0;
            this.quit_button.Text = "QUIT";
            this.quit_button.UseVisualStyleBackColor = false;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // size_button
            // 
            this.size_button.BackColor = System.Drawing.Color.PaleGreen;
            this.size_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.size_button.Location = new System.Drawing.Point(12, 12);
            this.size_button.Name = "size_button";
            this.size_button.Size = new System.Drawing.Size(159, 44);
            this.size_button.TabIndex = 1;
            this.size_button.Text = "SIZE";
            this.size_button.UseVisualStyleBackColor = false;
            this.size_button.Click += new System.EventHandler(this.size_button_Click);
            // 
            // rectangle_button
            // 
            this.rectangle_button.BackColor = System.Drawing.Color.PaleGreen;
            this.rectangle_button.Enabled = false;
            this.rectangle_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rectangle_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.rectangle_button.Location = new System.Drawing.Point(12, 62);
            this.rectangle_button.Name = "rectangle_button";
            this.rectangle_button.Size = new System.Drawing.Size(159, 44);
            this.rectangle_button.TabIndex = 3;
            this.rectangle_button.Text = "RECTANGLE";
            this.rectangle_button.UseVisualStyleBackColor = false;
            this.rectangle_button.Click += new System.EventHandler(this.rectangle_button_Click);
            // 
            // about_button
            // 
            this.about_button.BackColor = System.Drawing.Color.NavajoWhite;
            this.about_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_button.ForeColor = System.Drawing.Color.SaddleBrown;
            this.about_button.Location = new System.Drawing.Point(12, 314);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(159, 44);
            this.about_button.TabIndex = 4;
            this.about_button.Text = "ABOUT";
            this.about_button.UseVisualStyleBackColor = false;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // main
            // 
            this.main.Controls.Add(this.message);
            this.main.Location = new System.Drawing.Point(185, 10);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(397, 398);
            this.main.TabIndex = 5;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message.ForeColor = System.Drawing.SystemColors.ControlText;
            this.message.Location = new System.Drawing.Point(3, 6);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 18);
            this.message.TabIndex = 0;
            // 
            // input_button
            // 
            this.input_button.BackColor = System.Drawing.Color.PaleGreen;
            this.input_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.input_button.Location = new System.Drawing.Point(12, 112);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(159, 44);
            this.input_button.TabIndex = 6;
            this.input_button.Text = "INPUT";
            this.input_button.UseVisualStyleBackColor = false;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // circle_button
            // 
            this.circle_button.BackColor = System.Drawing.Color.PaleGreen;
            this.circle_button.Enabled = false;
            this.circle_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circle_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.circle_button.Location = new System.Drawing.Point(12, 162);
            this.circle_button.Name = "circle_button";
            this.circle_button.Size = new System.Drawing.Size(159, 44);
            this.circle_button.TabIndex = 7;
            this.circle_button.Text = "CIRCLE";
            this.circle_button.UseVisualStyleBackColor = false;
            this.circle_button.Click += new System.EventHandler(this.circle_button_Click);
            // 
            // calc_button
            // 
            this.calc_button.BackColor = System.Drawing.Color.PaleGreen;
            this.calc_button.Enabled = false;
            this.calc_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.calc_button.Location = new System.Drawing.Point(12, 213);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(159, 44);
            this.calc_button.TabIndex = 8;
            this.calc_button.Text = "CALC";
            this.calc_button.UseVisualStyleBackColor = false;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // reverse_button
            // 
            this.reverse_button.BackColor = System.Drawing.Color.PaleGreen;
            this.reverse_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reverse_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.reverse_button.Location = new System.Drawing.Point(12, 263);
            this.reverse_button.Name = "reverse_button";
            this.reverse_button.Size = new System.Drawing.Size(159, 44);
            this.reverse_button.TabIndex = 9;
            this.reverse_button.Text = "REVERSE";
            this.reverse_button.UseVisualStyleBackColor = false;
            this.reverse_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 418);
            this.Controls.Add(this.reverse_button);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.circle_button);
            this.Controls.Add(this.input_button);
            this.Controls.Add(this.main);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.rectangle_button);
            this.Controls.Add(this.size_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Логвинов Лев К3220 Вар. 1";
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button size_button;
        private System.Windows.Forms.Button rectangle_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.Button circle_button;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.Button reverse_button;
    }
}

