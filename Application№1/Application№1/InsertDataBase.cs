using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;


namespace Application_1
{
    public partial class InsertDataBase : UserControl
    {
        private SqlConnection connection = null;

        public InsertDataBase()
        {
            InitializeComponent();
        }

        private void InsertDataBase_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Books"].ConnectionString);
            connection.Open();
        }

        private void AddDB_Click(object sender, EventArgs e)
        {



            try
            {
                SqlCommand addBooks = null;
              


                addBooks = new SqlCommand($"INSERT INTO [Books] (Surname_Of_Writer, Name_Of_Writer, MiddleName_Of_Writer, Name_Of_Book, Genre)" +
                    $"VALUES (@Surname_Of_Writer, @Name_Of_Writer, @MiddleName_Of_Writer, @Name_Of_Book, @Genre)", connection);
               

                //Addition information about table Books
                addBooks.Parameters.AddWithValue("Surname_Of_Writer", textBoxSurnameOfWriter.Text);
                addBooks.Parameters.AddWithValue("Name_Of_Writer", textBoxNameOfWriter.Text);
                addBooks.Parameters.AddWithValue("MiddleName_Of_Writer", textBoxMiddleNameOfWriter.Text);
                addBooks.Parameters.AddWithValue("Name_Of_Book", textBoxNameOfBook.Text);
                addBooks.Parameters.AddWithValue("Genre", textBoxGenre.Text);

                addBooks.ExecuteNonQuery();
               

               

                MessageBox.Show("Данные занесены.");



                if (true)
                {
                    textBoxSurnameOfWriter.Clear();
                    textBoxNameOfWriter.Clear();
                    textBoxMiddleNameOfWriter.Clear();
                    textBoxNameOfBook.Clear();
                    textBoxGenre.Clear();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Необходимо ввести данные во все ячейкии.");

            }


        }


        private void SearchInDB_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = null;

            if (string.IsNullOrEmpty(textBoxSearchForBook.Text) && string.IsNullOrEmpty(textBoxSearchForSurname.Text) && string.IsNullOrEmpty(textBoxSearchForName.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Surname_Of_Writer, Name_Of_Writer, MiddleName_Of_Writer, Name_Of_Book, Genre FROM Books", connection);
            }
            else if (!string.IsNullOrEmpty(textBoxSearchForBook.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Surname_Of_Writer, Name_Of_Writer, MiddleName_Of_Writer, Name_Of_Book, Genre" +
                    $" FROM Books WHERE Name_Of_Book LIKE N'{textBoxSearchForBook.Text}%'", connection);

            }
            else if (!string.IsNullOrEmpty(textBoxSearchForSurname.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Surname_Of_Writer, Name_Of_Writer, MiddleName_Of_Writer, Name_Of_Book, Genre" +
                    $" FROM Books WHERE Surname_Of_Writer LIKE N'{textBoxSearchForSurname.Text}%'", connection);
            }
            else if (!string.IsNullOrEmpty(textBoxSearchForName.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Surname_Of_Writer, Name_Of_Writer, MiddleName_Of_Writer, Name_Of_Book, Genre" +
                    $" FROM Books WHERE Name_Of_Writer LIKE N'{textBoxSearchForName.Text}%'", connection);
            }


            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

        }
    }

}
