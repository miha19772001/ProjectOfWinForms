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
    public partial class DB : Form
    {
        private SqlConnection sqlConnection = null;

        public DB()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BookShop"].ConnectionString);
            sqlConnection.Open();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT Writer.Surname, Writer.Name FROM Writer WHERE Name LIKE N'{textBox1.Text}'", sqlConnection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }


    }





}
