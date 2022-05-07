using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace AppAdo03.DataBase
{
    public class AccesoDB
    {
        public static SqlConnection Conexion()
        {
            SqlConnection  myconexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Neptuno"].ConnectionString);
            return myconexion;
        }          
        
    }
}
