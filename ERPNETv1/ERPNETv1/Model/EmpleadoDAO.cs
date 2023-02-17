using AppAdo03.Service;
using ERPNETv1.DataBase;
using ERPNETv1.Entity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ERPNETv1.Model
{
    public class EmpleadoDAO : BusinessService<EmpleadoTO>
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public int create(EmpleadoTO t)
        {
            return 0;
        }

        public int delete(EmpleadoTO t)
        {
            return 0;
        }

        public EmpleadoTO findById(object t)
        {
            return null;
        }

        public List<EmpleadoTO> readAll()
        {
            return null;
        }

        public int update(EmpleadoTO t)
        {
            return 0;
        }

        public bool validar(string usuario, string clave)
        {
            bool ok = false;
            try
            {
                using (var cn = AccesoDB.Conexion())
                {
                    cmd = new SqlCommand("usp_validar_empleado", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", usuario);
                    cmd.Parameters.AddWithValue("@Apellido", clave);
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ok = true;
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return ok;
        }
    }
}
