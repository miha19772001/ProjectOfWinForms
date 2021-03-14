
namespace Application_1
{
    partial class InsertInMainMenu
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertInMainMenu));
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.tagline1 = new System.Windows.Forms.Label();
            this.tagline2 = new System.Windows.Forms.Label();
            this.tagline3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 222;
            this.iconPictureBox1.Location = new System.Drawing.Point(367, 239);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(277, 222);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // tagline1
            // 
            this.tagline1.AutoSize = true;
            this.tagline1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagline1.ForeColor = System.Drawing.Color.White;
            this.tagline1.Location = new System.Drawing.Point(140, 110);
            this.tagline1.Name = "tagline1";
            this.tagline1.Size = new System.Drawing.Size(532, 56);
            this.tagline1.TabIndex = 4;
            this.tagline1.Text = "Лучшая литература.";
            // 
            // tagline2
            // 
            this.tagline2.AutoSize = true;
            this.tagline2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagline2.ForeColor = System.Drawing.Color.White;
            this.tagline2.Location = new System.Drawing.Point(14, 74);
            this.tagline2.Name = "tagline2";
            this.tagline2.Size = new System.Drawing.Size(400, 47);
            this.tagline2.TabIndex = 4;
            this.tagline2.Text = "Русские классики!";
            // 
            // tagline3
            // 
            this.tagline3.AutoSize = true;
            this.tagline3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tagline3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagline3.ForeColor = System.Drawing.Color.White;
            this.tagline3.Location = new System.Drawing.Point(567, 166);
            this.tagline3.Name = "tagline3";
            this.tagline3.Size = new System.Drawing.Size(167, 25);
            this.tagline3.TabIndex = 4;
            this.tagline3.Text = "Нужные книги.";
            // 
            // InsertInMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.tagline3);
            this.Controls.Add(this.tagline2);
            this.Controls.Add(this.tagline1);
            this.Controls.Add(this.iconPictureBox1);
            this.Name = "InsertInMainMenu";
            this.Size = new System.Drawing.Size(764, 523);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label tagline1;
        private System.Windows.Forms.Label tagline2;
        private System.Windows.Forms.Label tagline3;
    }
}
