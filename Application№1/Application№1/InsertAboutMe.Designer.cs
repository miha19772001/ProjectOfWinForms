
namespace Application_1
{
    partial class InsertAboutMe
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
            this.labelDiscription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDiscription
            // 
            this.labelDiscription.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscription.ForeColor = System.Drawing.Color.White;
            this.labelDiscription.Location = new System.Drawing.Point(150, 175);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(471, 134);
            this.labelDiscription.TabIndex = 1;
            this.labelDiscription.Text = "Это приложение создано для показательного представления моих умений.\r\n";
            this.labelDiscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.labelDiscription);
            this.Name = "InsertAboutMe";
            this.Size = new System.Drawing.Size(764, 523);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDiscription;
    }
}
