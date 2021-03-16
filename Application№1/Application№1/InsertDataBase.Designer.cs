
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
            this.AddDB = new System.Windows.Forms.Button();
            this.labelDateOfDeath = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelMiddleNameOfWriter = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelDateOfWriting = new System.Windows.Forms.Label();
            this.labelNameOfBook = new System.Windows.Forms.Label();
            this.textBoxSurnameOfWriter = new System.Windows.Forms.TextBox();
            this.textBoxDateOfDeath = new System.Windows.Forms.TextBox();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxMiddleNameOfWriter = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxDateOfWriting = new System.Windows.Forms.TextBox();
            this.textBoxNameOfBook = new System.Windows.Forms.TextBox();
            this.textBoxNameOfWriter = new System.Windows.Forms.TextBox();
            this.labelSurnameOfWriter = new System.Windows.Forms.Label();
            this.labelNameOfWriter = new System.Windows.Forms.Label();
            this.SearchBook = new System.Windows.Forms.TabPage();
            this.SearchInDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchForSurname = new System.Windows.Forms.TextBox();
            this.textBoxSearchForName = new System.Windows.Forms.TextBox();
            this.textBoxSearchForBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddBook.SuspendLayout();
            this.SearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.AddBook.Controls.Add(this.AddDB);
            this.AddBook.Controls.Add(this.labelDateOfDeath);
            this.AddBook.Controls.Add(this.labelDateOfBirth);
            this.AddBook.Controls.Add(this.labelMiddleNameOfWriter);
            this.AddBook.Controls.Add(this.labelGenre);
            this.AddBook.Controls.Add(this.labelDateOfWriting);
            this.AddBook.Controls.Add(this.labelNameOfBook);
            this.AddBook.Controls.Add(this.textBoxSurnameOfWriter);
            this.AddBook.Controls.Add(this.textBoxDateOfDeath);
            this.AddBook.Controls.Add(this.textBoxDateOfBirth);
            this.AddBook.Controls.Add(this.textBoxMiddleNameOfWriter);
            this.AddBook.Controls.Add(this.textBoxGenre);
            this.AddBook.Controls.Add(this.textBoxDateOfWriting);
            this.AddBook.Controls.Add(this.textBoxNameOfBook);
            this.AddBook.Controls.Add(this.textBoxNameOfWriter);
            this.AddBook.Controls.Add(this.labelSurnameOfWriter);
            this.AddBook.Controls.Add(this.labelNameOfWriter);
            this.AddBook.Location = new System.Drawing.Point(4, 22);
            this.AddBook.Name = "AddBook";
            this.AddBook.Padding = new System.Windows.Forms.Padding(3);
            this.AddBook.Size = new System.Drawing.Size(756, 497);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "Add Book";
            // 
            // AddDB
            // 
            this.AddDB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDB.ForeColor = System.Drawing.Color.White;
            this.AddDB.Location = new System.Drawing.Point(28, 435);
            this.AddDB.Name = "AddDB";
            this.AddDB.Size = new System.Drawing.Size(119, 45);
            this.AddDB.TabIndex = 1;
            this.AddDB.Text = "Add";
            this.AddDB.UseVisualStyleBackColor = true;
            this.AddDB.Click += new System.EventHandler(this.AddDB_Click);
            // 
            // labelDateOfDeath
            // 
            this.labelDateOfDeath.AutoSize = true;
            this.labelDateOfDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfDeath.ForeColor = System.Drawing.Color.White;
            this.labelDateOfDeath.Location = new System.Drawing.Point(370, 164);
            this.labelDateOfDeath.Name = "labelDateOfDeath";
            this.labelDateOfDeath.Size = new System.Drawing.Size(105, 16);
            this.labelDateOfDeath.TabIndex = 2;
            this.labelDateOfDeath.Text = "Date of death:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.labelDateOfBirth.Location = new System.Drawing.Point(370, 131);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(96, 16);
            this.labelDateOfBirth.TabIndex = 2;
            this.labelDateOfBirth.Text = "Date of birth:";
            // 
            // labelMiddleNameOfWriter
            // 
            this.labelMiddleNameOfWriter.AutoSize = true;
            this.labelMiddleNameOfWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleNameOfWriter.ForeColor = System.Drawing.Color.White;
            this.labelMiddleNameOfWriter.Location = new System.Drawing.Point(370, 98);
            this.labelMiddleNameOfWriter.Name = "labelMiddleNameOfWriter";
            this.labelMiddleNameOfWriter.Size = new System.Drawing.Size(158, 16);
            this.labelMiddleNameOfWriter.TabIndex = 2;
            this.labelMiddleNameOfWriter.Text = "Writer\'s middle name:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.ForeColor = System.Drawing.Color.White;
            this.labelGenre.Location = new System.Drawing.Point(21, 96);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(54, 16);
            this.labelGenre.TabIndex = 2;
            this.labelGenre.Text = "Genre:";
            // 
            // labelDateOfWriting
            // 
            this.labelDateOfWriting.AutoSize = true;
            this.labelDateOfWriting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfWriting.ForeColor = System.Drawing.Color.White;
            this.labelDateOfWriting.Location = new System.Drawing.Point(21, 62);
            this.labelDateOfWriting.Name = "labelDateOfWriting";
            this.labelDateOfWriting.Size = new System.Drawing.Size(110, 16);
            this.labelDateOfWriting.TabIndex = 2;
            this.labelDateOfWriting.Text = "Date of writing:";
            // 
            // labelNameOfBook
            // 
            this.labelNameOfBook.AutoSize = true;
            this.labelNameOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfBook.ForeColor = System.Drawing.Color.White;
            this.labelNameOfBook.Location = new System.Drawing.Point(21, 28);
            this.labelNameOfBook.Name = "labelNameOfBook";
            this.labelNameOfBook.Size = new System.Drawing.Size(102, 16);
            this.labelNameOfBook.TabIndex = 2;
            this.labelNameOfBook.Text = "Book\'s name:";
            // 
            // textBoxSurnameOfWriter
            // 
            this.textBoxSurnameOfWriter.Location = new System.Drawing.Point(530, 32);
            this.textBoxSurnameOfWriter.Name = "textBoxSurnameOfWriter";
            this.textBoxSurnameOfWriter.Size = new System.Drawing.Size(208, 20);
            this.textBoxSurnameOfWriter.TabIndex = 3;
            // 
            // textBoxDateOfDeath
            // 
            this.textBoxDateOfDeath.Location = new System.Drawing.Point(530, 160);
            this.textBoxDateOfDeath.Name = "textBoxDateOfDeath";
            this.textBoxDateOfDeath.Size = new System.Drawing.Size(208, 20);
            this.textBoxDateOfDeath.TabIndex = 3;
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(530, 128);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(208, 20);
            this.textBoxDateOfBirth.TabIndex = 3;
            // 
            // textBoxMiddleNameOfWriter
            // 
            this.textBoxMiddleNameOfWriter.Location = new System.Drawing.Point(530, 96);
            this.textBoxMiddleNameOfWriter.Name = "textBoxMiddleNameOfWriter";
            this.textBoxMiddleNameOfWriter.Size = new System.Drawing.Size(208, 20);
            this.textBoxMiddleNameOfWriter.TabIndex = 3;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(129, 92);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(208, 20);
            this.textBoxGenre.TabIndex = 3;
            // 
            // textBoxDateOfWriting
            // 
            this.textBoxDateOfWriting.Location = new System.Drawing.Point(129, 60);
            this.textBoxDateOfWriting.Name = "textBoxDateOfWriting";
            this.textBoxDateOfWriting.Size = new System.Drawing.Size(208, 20);
            this.textBoxDateOfWriting.TabIndex = 3;
            // 
            // textBoxNameOfBook
            // 
            this.textBoxNameOfBook.Location = new System.Drawing.Point(129, 28);
            this.textBoxNameOfBook.Name = "textBoxNameOfBook";
            this.textBoxNameOfBook.Size = new System.Drawing.Size(208, 20);
            this.textBoxNameOfBook.TabIndex = 3;
            // 
            // textBoxNameOfWriter
            // 
            this.textBoxNameOfWriter.Location = new System.Drawing.Point(530, 64);
            this.textBoxNameOfWriter.Name = "textBoxNameOfWriter";
            this.textBoxNameOfWriter.Size = new System.Drawing.Size(208, 20);
            this.textBoxNameOfWriter.TabIndex = 3;
            // 
            // labelSurnameOfWriter
            // 
            this.labelSurnameOfWriter.AutoSize = true;
            this.labelSurnameOfWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurnameOfWriter.ForeColor = System.Drawing.Color.White;
            this.labelSurnameOfWriter.Location = new System.Drawing.Point(370, 32);
            this.labelSurnameOfWriter.Name = "labelSurnameOfWriter";
            this.labelSurnameOfWriter.Size = new System.Drawing.Size(128, 16);
            this.labelSurnameOfWriter.TabIndex = 2;
            this.labelSurnameOfWriter.Text = "Writer\'s surname:";
            // 
            // labelNameOfWriter
            // 
            this.labelNameOfWriter.AutoSize = true;
            this.labelNameOfWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfWriter.ForeColor = System.Drawing.Color.White;
            this.labelNameOfWriter.Location = new System.Drawing.Point(370, 65);
            this.labelNameOfWriter.Name = "labelNameOfWriter";
            this.labelNameOfWriter.Size = new System.Drawing.Size(107, 16);
            this.labelNameOfWriter.TabIndex = 2;
            this.labelNameOfWriter.Text = "Writer\'s name:";
            // 
            // SearchBook
            // 
            this.SearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.SearchBook.Controls.Add(this.SearchInDB);
            this.SearchBook.Controls.Add(this.dataGridView1);
            this.SearchBook.Controls.Add(this.label2);
            this.SearchBook.Controls.Add(this.label1);
            this.SearchBook.Controls.Add(this.textBoxSearchForSurname);
            this.SearchBook.Controls.Add(this.textBoxSearchForName);
            this.SearchBook.Controls.Add(this.textBoxSearchForBook);
            this.SearchBook.Controls.Add(this.label4);
            this.SearchBook.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBook.Location = new System.Drawing.Point(4, 22);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Padding = new System.Windows.Forms.Padding(3);
            this.SearchBook.Size = new System.Drawing.Size(756, 497);
            this.SearchBook.TabIndex = 0;
            this.SearchBook.Text = "Search Book";
            // 
            // SearchInDB
            // 
            this.SearchInDB.Location = new System.Drawing.Point(59, 411);
            this.SearchInDB.Name = "SearchInDB";
            this.SearchInDB.Size = new System.Drawing.Size(75, 23);
            this.SearchInDB.TabIndex = 5;
            this.SearchInDB.Text = "Search";
            this.SearchInDB.UseVisualStyleBackColor = true;
            this.SearchInDB.Click += new System.EventHandler(this.SearchInDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 360);
            this.dataGridView1.TabIndex = 4;
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
            // textBoxSearchForSurname
            // 
            this.textBoxSearchForSurname.Location = new System.Drawing.Point(597, 390);
            this.textBoxSearchForSurname.Name = "textBoxSearchForSurname";
            this.textBoxSearchForSurname.Size = new System.Drawing.Size(113, 21);
            this.textBoxSearchForSurname.TabIndex = 3;
            // 
            // textBoxSearchForName
            // 
            this.textBoxSearchForName.Location = new System.Drawing.Point(597, 433);
            this.textBoxSearchForName.Name = "textBoxSearchForName";
            this.textBoxSearchForName.Size = new System.Drawing.Size(113, 21);
            this.textBoxSearchForName.TabIndex = 3;
            // 
            // textBoxSearchForBook
            // 
            this.textBoxSearchForBook.Location = new System.Drawing.Point(441, 409);
            this.textBoxSearchForBook.Name = "textBoxSearchForBook";
            this.textBoxSearchForBook.Size = new System.Drawing.Size(113, 21);
            this.textBoxSearchForBook.TabIndex = 3;
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
            this.Load += new System.EventHandler(this.InsertDataBase_Load);
            this.AddBook.ResumeLayout(false);
            this.AddBook.PerformLayout();
            this.SearchBook.ResumeLayout(false);
            this.SearchBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TabPage AddBook;
        private System.Windows.Forms.Button AddDB;
        private System.Windows.Forms.Label labelNameOfBook;
        private System.Windows.Forms.TextBox textBoxSurnameOfWriter;
        private System.Windows.Forms.TextBox textBoxNameOfBook;
        private System.Windows.Forms.TextBox textBoxNameOfWriter;
        private System.Windows.Forms.Label labelSurnameOfWriter;
        private System.Windows.Forms.Label labelNameOfWriter;
        private System.Windows.Forms.TabPage SearchBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchForSurname;
        private System.Windows.Forms.TextBox textBoxSearchForName;
        private System.Windows.Forms.TextBox textBoxSearchForBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBoxMiddleNameOfWriter;
        private System.Windows.Forms.Label labelMiddleNameOfWriter;
        private System.Windows.Forms.Label labelDateOfDeath;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxDateOfDeath;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelDateOfWriting;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxDateOfWriting;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchInDB;
    }
}
