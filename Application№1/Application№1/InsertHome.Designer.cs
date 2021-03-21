
namespace Application_1
{
    partial class InsertHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertHome));
            this.labelDiscription = new System.Windows.Forms.Label();
            this.pictureBoxCornerTop = new System.Windows.Forms.PictureBox();
            this.pictureBoxCornerBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCornerTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCornerBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDiscription
            // 
            this.labelDiscription.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscription.ForeColor = System.Drawing.Color.White;
            this.labelDiscription.Location = new System.Drawing.Point(142, 178);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(471, 134);
            this.labelDiscription.TabIndex = 2;
            this.labelDiscription.Text = "Надеюсь, Вам понравится этот небольшой проект.\r\n";
            this.labelDiscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCornerTop
            // 
            this.pictureBoxCornerTop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCornerTop.Image")));
            this.pictureBoxCornerTop.Location = new System.Drawing.Point(664, 0);
            this.pictureBoxCornerTop.Name = "pictureBoxCornerTop";
            this.pictureBoxCornerTop.Size = new System.Drawing.Size(100, 101);
            this.pictureBoxCornerTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCornerTop.TabIndex = 3;
            this.pictureBoxCornerTop.TabStop = false;
            // 
            // pictureBoxCornerBottom
            // 
            this.pictureBoxCornerBottom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCornerBottom.Image")));
            this.pictureBoxCornerBottom.Location = new System.Drawing.Point(0, 422);
            this.pictureBoxCornerBottom.Name = "pictureBoxCornerBottom";
            this.pictureBoxCornerBottom.Size = new System.Drawing.Size(100, 101);
            this.pictureBoxCornerBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCornerBottom.TabIndex = 3;
            this.pictureBoxCornerBottom.TabStop = false;
            // 
            // InsertHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.pictureBoxCornerBottom);
            this.Controls.Add(this.pictureBoxCornerTop);
            this.Controls.Add(this.labelDiscription);
            this.Name = "InsertHome";
            this.Size = new System.Drawing.Size(764, 523);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCornerTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCornerBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDiscription;
        private System.Windows.Forms.PictureBox pictureBoxCornerTop;
        private System.Windows.Forms.PictureBox pictureBoxCornerBottom;
    }
}
