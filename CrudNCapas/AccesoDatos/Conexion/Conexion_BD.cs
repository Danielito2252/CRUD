using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.Conexion
{
    public class Conexion_BD
    {
        private SqlConnection c = new SqlConnection("Data Source=.;Initial Catalog=Crud_N_Capas;Integrated Security=True;Encrypt=False");

        public SqlConnection OpenConnection()
        {
            if (c.State == ConnectionState.Closed) c.Open();
            return c;
        }
        public SqlConnection CloseConnection()
        {
            if (c.State == ConnectionState.Closed) c.Open();
            return c;
        }
    }
}
