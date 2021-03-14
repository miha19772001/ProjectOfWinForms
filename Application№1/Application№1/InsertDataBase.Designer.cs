
namespace Application_1
{
    partial class InsertDataBase
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.AddBook = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SearchBook = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SearchInDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.AddBook.Controls.Add(this.dataGridView2);
            this.AddBook.Controls.Add(this.button1);
            this.AddBook.Controls.Add(this.label6);
            this.AddBook.Controls.Add(this.textBox6);
            this.AddBook.Controls.Add(this.textBox5);
            this.AddBook.Controls.Add(this.textBox3);
            this.AddBook.Controls.Add(this.label5);
            this.AddBook.Controls.Add(this.label3);
            this.AddBook.Location = new System.Drawing.Point(4, 22);
            this.AddBook.Name = "AddBook";
            this.AddBook.Padding = new System.Windows.Forms.Padding(3);
            this.AddBook.Size = new System.Drawing.Size(756, 497);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "Add Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(601, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Writer\'s name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(591, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Writer\'s Surname:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(597, 433);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(441, 409);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(113, 20);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(597, 390);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 20);
            this.textBox6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(447, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Book\'s name:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(764, 366);
            this.dataGridView2.TabIndex = 0;
            // 
            // SearchBook
            // 
            this.SearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.SearchBook.Controls.Add(this.dataGridView1);
            this.SearchBook.Controls.Add(this.label2);
            this.SearchBook.Controls.Add(this.label1);
            this.SearchBook.Controls.Add(this.SearchInDB);
            this.SearchBook.Controls.Add(this.textBox2);
            this.SearchBook.Controls.Add(this.textBox4);
            this.SearchBook.Controls.Add(this.textBox1);
            this.SearchBook.Controls.Add(this.label4);
            this.SearchBook.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBook.Location = new System.Drawing.Point(4, 22);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Padding = new System.Windows.Forms.Padding(3);
            this.SearchBook.Size = new System.Drawing.Size(756, 497);
            this.SearchBook.TabIndex = 0;
            this.SearchBook.Text = "Search Book";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(597, 433);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 21);
            this.textBox4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(601, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Writer\'s name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(597, 390);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 21);
            this.textBox2.TabIndex = 3;
            // 
            // SearchInDB
            // 
            this.SearchInDB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchInDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchInDB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchInDB.ForeColor = System.Drawing.Color.White;
            this.SearchInDB.Location = new System.Drawing.Point(28, 435);
            this.SearchInDB.Name = "SearchInDB";
            this.SearchInDB.Size = new System.Drawing.Size(119, 45);
            this.SearchInDB.TabIndex = 1;
            this.SearchInDB.Text = "Search";
            this.SearchInDB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book\'s name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(591, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Writer\'s Surname:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SearchBook);
            this.tabControl1.Controls.Add(this.AddBook);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 523);
            this.tabControl1.TabIndex = 4;
            // 
            // InsertDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.tabControl1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "InsertDataBase";
            this.Size = new System.Drawing.Size(764, 523);
            this.AddBook.ResumeLayout(false);
            this.AddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.SearchBook.ResumeLayout(false);
            this.SearchBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TabPage AddBook;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage SearchBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchInDB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
