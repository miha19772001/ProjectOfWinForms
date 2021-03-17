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
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BookShop"].ConnectionString);
            connection.Open();
        }

        private void AddDB_Click(object sender, EventArgs e)
        {

            SqlCommand addWriter = new SqlCommand($"INSERT INTO [Writer] (Surname, Name, Middle_Name, Date_of_birth, Date_of_death)" +
                $"VALUES (@Surname, @Name, @Middle_Name, @Date_of_birth, @Date_of_death)", connection);
            SqlCommand addProduct = new SqlCommand($"INSERT INTO [Product] (Name, Date_of_writing, Genre) " +
                $"VALUES (@Name, @Date_of_writing, @Genre)", connection);


            //Addition values in the DataBase "Writer"

            DateTime Date_of_birth_of_the_Writer;
            DateTime Date_of_death_of_the_Writer;

            if (textBoxDateOfBirth.Text != null)
            {
                try
                {
                    Date_of_birth_of_the_Writer = DateTime.Parse(textBoxDateOfBirth.Text);


                    addWriter.Parameters.AddWithValue("Date_of_birth", $"{Date_of_birth_of_the_Writer.Month}/{Date_of_birth_of_the_Writer.Day}/{Date_of_birth_of_the_Writer.Year}");
                }

                catch (Exception)
                {
                    addWriter.Parameters.AddWithValue("Date_of_birth", "");

                }
            }

            if (textBoxDateOfDeath.Text != null)
            {
                try
                {
                    Date_of_death_of_the_Writer = DateTime.Parse(textBoxDateOfDeath.Text);

                    addWriter.Parameters.AddWithValue("Date_of_death", $"{Date_of_death_of_the_Writer.Month}/{Date_of_death_of_the_Writer.Day}/{Date_of_death_of_the_Writer.Year}");
                }
                catch (Exception)
                {
                    addWriter.Parameters.AddWithValue("Date_of_death", "");

                }
            }
            // DateTime Date_of_birth_of_the_Writer = DateTime.Parse(textBoxDateOfBirth.Text);
            // DateTime Date_of_death_of_the_Writer = DateTime.Parse(textBoxDateOfDeath.Text);

            addWriter.Parameters.AddWithValue("Surname", textBoxSurnameOfWriter.Text);
            addWriter.Parameters.AddWithValue("Name", textBoxNameOfWriter.Text);
            addWriter.Parameters.AddWithValue("Middle_Name", textBoxMiddleNameOfWriter.Text);
            // addWriter.Parameters.AddWithValue("Date_of_birth", $"{Date_of_birth_of_the_Writer.Month}/{Date_of_birth_of_the_Writer.Day}/{Date_of_birth_of_the_Writer.Year}");
            // addWriter.Parameters.AddWithValue("Date_of_death", $"{Date_of_death_of_the_Writer.Month}/{Date_of_death_of_the_Writer.Day}/{Date_of_death_of_the_Writer.Year}");

            //Addition values in the DataBase "Product"
            addProduct.Parameters.AddWithValue("Name", textBoxNameOfBook.Text);
            addProduct.Parameters.AddWithValue("Date_of_writing", textBoxDateOfWriting.Text);
            addProduct.Parameters.AddWithValue("Genre", textBoxGenre.Text);

            MessageBox.Show(addProduct.ExecuteNonQuery().ToString());



            if (true)
            {
                textBoxSurnameOfWriter.Clear();
                textBoxNameOfWriter.Clear();
                textBoxDateOfBirth.Clear();
                textBoxDateOfDeath.Clear();

                textBoxNameOfBook.Clear();
                textBoxDateOfWriting.Clear();
                textBoxGenre.Clear();
            }

        }


        private void SearchInDB_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = null;

            if (string.IsNullOrEmpty(textBoxSearchForBook.Text) && string.IsNullOrEmpty(textBoxSearchForSurname.Text) && string.IsNullOrEmpty(textBoxSearchForName.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Writer.Surname, Writer.Name, Writer.Middle_Name, Writer.Date_of_birth, Writer.Date_of_death, " +
                $"Product.Name, Product.Date_of_writing, Product.Genre FROM Writer JOIN Product ON Writer.Id = Product.Id_Writer", connection);
            }
            else if (!string.IsNullOrEmpty(textBoxSearchForBook.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Writer.Surname, Writer.Name, Writer.Middle_Name, Writer.Date_of_birth, Writer.Date_of_death, " +
                    $"Product.Name, Product.Date_of_writing, Product.Genre FROM Writer JOIN Product ON Writer.Id = Product.Id_Writer WHERE Product.Name LIKE N'{textBoxSearchForBook.Text}%'", connection);

            }
            else if (!string.IsNullOrEmpty(textBoxSearchForSurname.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Writer.Surname, Writer.Name, Writer.Middle_Name, Writer.Date_of_birth, Writer.Date_of_death," +
                    $" Product.Name, Product.Date_of_writing, Product.Genre FROM Writer JOIN Product ON Writer.Id = Product.Id_Writer WHERE Writer.Surname LIKE N'{textBoxSearchForSurname.Text}%'", connection);
            }
            else if (!string.IsNullOrEmpty(textBoxSearchForName.Text))
            {
                dataAdapter = new SqlDataAdapter($"SELECT Writer.Surname, Writer.Name, Writer.Middle_Name, Writer.Date_of_birth, Writer.Date_of_death," +
                    $" Product.Name, Product.Date_of_writing, Product.Genre FROM Writer JOIN Product ON Writer.Id = Product.Id_Writer WHERE Writer.Name LIKE N'{textBoxSearchForName.Text}%'", connection);
            }


            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

        }
    }

}
