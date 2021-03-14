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
    }
}
