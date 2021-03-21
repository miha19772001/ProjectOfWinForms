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
                SqlCommand addWriter = null;
                SqlCommand addProduct = null;


                addWriter = new SqlCommand($"INSERT INTO [Writer] (Surname, Name, Middle_Name, Date_of_birth, Date_of_death)" +
                    $"VALUES (@Surname, @Name, @Middle_Name, @Date_of_birth, @Date_of_death)", connection);
                addProduct = new SqlCommand($"INSERT INTO [Product] (Name, Date_of_writing, Genre) " +
                    $"VALUES (@Name, @Date_of_writing, @Genre)", connection);


                var date_of_birth = DateTime.Parse(textBoxDateOfBirth.Text);
                var date_of_death = DateTime.Parse(textBoxDateOfDeath.Text);

                //Addition information about Writer
                addWriter.Parameters.AddWithValue("Surname", textBoxSurnameOfWriter.Text);
                addWriter.Parameters.AddWithValue("Name", textBoxNameOfWriter.Text);
                addWriter.Parameters.AddWithValue("Middle_Name", textBoxMiddleNameOfWriter.Text);
                addWriter.Parameters.AddWithValue("Date_of_birth", $"{date_of_birth.Month}/{date_of_birth.Day}/{date_of_birth.Year}");
                addWriter.Parameters.AddWithValue("Date_of_death", $"{date_of_death.Month}/{date_of_death.Day}/{date_of_death.Year}");

                //Addition information about Product
                
                addProduct.Parameters.AddWithValue("Name", textBoxNameOfBook.Text);
                addProduct.Parameters.AddWithValue("Date_of_writing", textBoxDateOfWriting.Text);
                addProduct.Parameters.AddWithValue("Genre", textBoxGenre.Text);


                addProduct.ExecuteNonQuery();
                addWriter.ExecuteNonQuery();

               

                MessageBox.Show("Данные занесены.");



                if (true)
                {
                    textBoxSurnameOfWriter.Clear();
                    textBoxNameOfWriter.Clear();
                    textBoxMiddleNameOfWriter.Clear();
                    textBoxDateOfBirth.Clear();
                    textBoxDateOfDeath.Clear();

                    textBoxNameOfBook.Clear();
                    textBoxDateOfWriting.Clear();
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
                dataAdapter = new SqlDataAdapter($"SELECT Writer.Surname, Writer.Name, Writer.Middle_Name, Writer.Date_of_birth, Writer.Date_of_death, " +
                $"Product.Name, Product.Date_of_writing, Product.Genre FROM Writer JOIN Product ON Writer.Surname = Product.Surname_Writer", connection);
            }
            else if (!string.IsNullOrEmpty(textBoxSearchForBook.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Writer.Surname, Writer.Name, Writer.Middle_Name, Writer.Date_of_birth, Writer.Date_of_death, " +
                    $"Product.Name, Product.Date_of_writing, Product.Genre FROM Writer JOIN Product ON Writer.Surname = Product.Surname_Writer WHERE Product.Name LIKE N'{textBoxSearchForBook.Text}%'", connection);

            }
            else if (!string.IsNullOrEmpty(textBoxSearchForSurname.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Writer.Surname, Writer.Name, Writer.Middle_Name, Writer.Date_of_birth, Writer.Date_of_death," +
                    $" Product.Name, Product.Date_of_writing, Product.Genre FROM Writer JOIN Product ON Writer.Surname = Product.Surname_Writer WHERE Writer.Surname LIKE N'{textBoxSearchForSurname.Text}%'", connection);
            }
            else if (!string.IsNullOrEmpty(textBoxSearchForName.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Writer.Surname, Writer.Name, Writer.Middle_Name, Writer.Date_of_birth, Writer.Date_of_death," +
                    $" Product.Name, Product.Date_of_writing, Product.Genre FROM Writer JOIN Product ON Writer.Surname = Product.Surname_Writer WHERE Writer.Name LIKE N'{textBoxSearchForName.Text}%'", connection);
            }


            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

        }
    }

}
