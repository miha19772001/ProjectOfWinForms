
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
            this.iconPictureBoxBooks = new FontAwesome.Sharp.IconPictureBox();
            this.taglineMiddle = new System.Windows.Forms.Label();
            this.taglineTop = new System.Windows.Forms.Label();
            this.taglineBottom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBoxBooks
            // 
            this.iconPictureBoxBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBoxBooks.BackgroundImage")));
            this.iconPictureBoxBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBoxBooks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxBooks.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBoxBooks.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxBooks.IconSize = 222;
            this.iconPictureBoxBooks.Location = new System.Drawing.Point(367, 239);
            this.iconPictureBoxBooks.Name = "iconPictureBoxBooks";
            this.iconPictureBoxBooks.Size = new System.Drawing.Size(277, 222);
            this.iconPictureBoxBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxBooks.TabIndex = 3;
            this.iconPictureBoxBooks.TabStop = false;
            // 
            // taglineMiddle
            // 
            this.taglineMiddle.AutoSize = true;
            this.taglineMiddle.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taglineMiddle.ForeColor = System.Drawing.Color.White;
            this.taglineMiddle.Location = new System.Drawing.Point(140, 110);
            this.taglineMiddle.Name = "taglineMiddle";
            this.taglineMiddle.Size = new System.Drawing.Size(532, 56);
            this.taglineMiddle.TabIndex = 4;
            this.taglineMiddle.Text = "Лучшая литература.";
            // 
            // taglineTop
            // 
            this.taglineTop.AutoSize = true;
            this.taglineTop.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taglineTop.ForeColor = System.Drawing.Color.White;
            this.taglineTop.Location = new System.Drawing.Point(14, 74);
            this.taglineTop.Name = "taglineTop";
            this.taglineTop.Size = new System.Drawing.Size(400, 47);
            this.taglineTop.TabIndex = 4;
            this.taglineTop.Text = "Русские классики!";
            // 
            // taglineBottom
            // 
            this.taglineBottom.AutoSize = true;
            this.taglineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.taglineBottom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taglineBottom.ForeColor = System.Drawing.Color.White;
            this.taglineBottom.Location = new System.Drawing.Point(567, 166);
            this.taglineBottom.Name = "taglineBottom";
            this.taglineBottom.Size = new System.Drawing.Size(167, 25);
            this.taglineBottom.TabIndex = 4;
            this.taglineBottom.Text = "Нужные книги.";
            // 
            // InsertInMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.taglineBottom);
            this.Controls.Add(this.taglineTop);
            this.Controls.Add(this.taglineMiddle);
            this.Controls.Add(this.iconPictureBoxBooks);
            this.Name = "InsertInMainMenu";
            this.Size = new System.Drawing.Size(764, 523);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBooks;
        private System.Windows.Forms.Label taglineMiddle;
        private System.Windows.Forms.Label taglineTop;
        private System.Windows.Forms.Label taglineBottom;
    }
}
