
namespace Application_1
{
    partial class InsertNovelty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertNovelty));
            this.pictureBoxWriter = new System.Windows.Forms.PictureBox();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            this.labeltaglineTop = new System.Windows.Forms.Label();
            this.labelDiscription = new System.Windows.Forms.Label();
            this.labeltaglineBottom = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWriter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWriter
            // 
            this.pictureBoxWriter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWriter.Image")));
            this.pictureBoxWriter.Location = new System.Drawing.Point(562, 16);
            this.pictureBoxWriter.Name = "pictureBoxWriter";
            this.pictureBoxWriter.Size = new System.Drawing.Size(176, 175);
            this.pictureBoxWriter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWriter.TabIndex = 0;
            this.pictureBoxWriter.TabStop = false;
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBook.Image")));
            this.pictureBoxBook.Location = new System.Drawing.Point(37, 254);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(169, 242);
            this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBook.TabIndex = 0;
            this.pictureBoxBook.TabStop = false;
            // 
            // labeltaglineTop
            // 
            this.labeltaglineTop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeltaglineTop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltaglineTop.ForeColor = System.Drawing.Color.White;
            this.labeltaglineTop.Location = new System.Drawing.Point(32, 90);
            this.labeltaglineTop.Name = "labeltaglineTop";
            this.labeltaglineTop.Size = new System.Drawing.Size(467, 56);
            this.labeltaglineTop.TabIndex = 4;
            this.labeltaglineTop.Text = "Прекрасное произведение для тех, кто любит комедии и забавные ситуации\r\n!";
            this.labeltaglineTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDiscription
            // 
            this.labelDiscription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDiscription.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscription.ForeColor = System.Drawing.Color.White;
            this.labelDiscription.Location = new System.Drawing.Point(361, 246);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(335, 33);
            this.labelDiscription.TabIndex = 5;
            this.labelDiscription.Text = "Краткое содержание:";
            this.labelDiscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeltaglineBottom
            // 
            this.labeltaglineBottom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltaglineBottom.ForeColor = System.Drawing.Color.White;
            this.labeltaglineBottom.Location = new System.Drawing.Point(362, 279);
            this.labeltaglineBottom.Name = "labeltaglineBottom";
            this.labeltaglineBottom.Size = new System.Drawing.Size(326, 229);
            this.labeltaglineBottom.TabIndex = 6;
            this.labeltaglineBottom.Text = resources.GetString("labeltaglineBottom.Text");
            this.labeltaglineBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(211, 254);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(36, 34);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 7;
            this.pictureBoxIcon.TabStop = false;
            // 
            // InsertNovelty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labeltaglineBottom);
            this.Controls.Add(this.labelDiscription);
            this.Controls.Add(this.labeltaglineTop);
            this.Controls.Add(this.pictureBoxBook);
            this.Controls.Add(this.pictureBoxWriter);
            this.Name = "InsertNovelty";
            this.Size = new System.Drawing.Size(764, 523);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWriter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWriter;
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.Label labeltaglineTop;
        private System.Windows.Forms.Label labelDiscription;
        private System.Windows.Forms.Label labeltaglineBottom;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
    }
}
