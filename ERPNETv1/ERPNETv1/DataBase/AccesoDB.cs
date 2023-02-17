using System.Configuration;
using System.Data.SqlClient;

namespace ERPNETv1.DataBase
{
    public class AccesoDB
    {
        public static SqlConnection Conexion()
        {
            SqlConnection myconexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Neptuno"].ConnectionString);
            return myconexion;
        }

    }
}
