using ERPNETv1.DataBase;
using ERPNETv1.Entity;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ERPNETv1.Model
{
    public class ProyectoDAO
    {
        public void create(Proyecto reg)
        {
            using (var cn = AccesoDB.Conexion())
            {
                SqlCommand cmd = new SqlCommand("usp_Proyecto_Adicionar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@monto", reg.monto);
                cmd.Parameters.Add("@IdProyecto", SqlDbType.Int).Direction = ParameterDirection.Output;
                //ejecutar sp
                cn.Open();
                cmd.ExecuteNonQuery();
                reg.idProyecto = (int)cmd.Parameters["@IdProyecto"].Value;
            }
        }//end

        public void update(Proyecto reg)
        {
            using (var cn = AccesoDB.Conexion())
            {
                SqlCommand cmd = new SqlCommand("usp_Producto_Actualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProyecto", reg.idProyecto);
                cmd.Parameters.AddWithValue("@Monto", reg.monto);
                cmd.Parameters.AddWithValue("@Fecha", reg.fecha);
                cmd.ExecuteNonQuery();
            }

        }//end

        public void delete(Proyecto reg)
        {
            using (var cn = AccesoDB.Conexion())
            {
                SqlCommand cmd = new SqlCommand("usp_Producto_Eliminar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProyecto", reg.idProyecto);
                cmd.ExecuteNonQuery();
            }
        }//end

        public DataTable listaProyectos()
        {
            DataTable dt;
            using (var cn = AccesoDB.Conexion())
            {
                SqlDataAdapter dap = new SqlDataAdapter("usp_Proyectos_Listar", cn);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                dap.Fill(dt);
            }
            return dt;
        }

        public Proyecto findForId(object t)
        {
            Proyecto pro = null;
            try
            {
                using (var cn = AccesoDB.Conexion())
                {
                    SqlCommand cmd = new SqlCommand("usp_Producto_Datos", cn);
                    SqlDataReader dr;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProducto", Convert.ToInt32(t));
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        pro = new Proyecto()
                        {
                            //IdProducto = Convert.ToInt32(dr[0]),
                            //NombreProducto = dr[1].ToString(),
                            //IdProveedor = Convert.ToInt32(dr[2]),
                            //IdCategoria = Convert.ToInt32(dr[3]),
                            //Precio = Convert.ToDecimal(dr[4]),
                            //Stock = Convert.ToInt32(dr[5]),
                        };
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return pro;
        }
    }
}
