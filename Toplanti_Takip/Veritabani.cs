using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Toplanti_Takip
{
    class Veritabani
    {
        public SqlConnection getConn()
        {
            string connectionString = "Data Source=.;Initial Catalog=CRUD_SP_DB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            //Return Connection.
            return connection;
        } 
        
    }
}
