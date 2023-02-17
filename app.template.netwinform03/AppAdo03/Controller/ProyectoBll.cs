using ERPNETv1.Entity;
using ERPNETv1.Model;
using System;
using System.Data;

namespace ERPNETv1.Controller
{
    public class ProyectoBll
    {
        ProyectoDAO dao;
        public ProyectoBll()
        {
            dao = new ProyectoDAO();
        }
        public DataTable ProyectoListar()
        {
            try
            {
                return dao.listaProyectos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ProyectoAdicionar(Proyecto reg)
        {
            try
            {
                dao.create(reg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ProyectoActualizar(Proyecto reg)
        {
            try
            {
                dao.update(reg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ProyectoEliminar(Proyecto reg)
        {
            try
            {
                dao.delete(reg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Proyecto ProyectoBuscar(object p)
        {
            return dao.findForId(p);
        }

    }
}
