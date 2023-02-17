using ERPNETv1.Model;

namespace ERPNETv1.Controller
{
    public class EmpleadoBLL
    {
        EmpleadoDAO dao;
        public EmpleadoBLL()
        {
            dao = new EmpleadoDAO();
        }

        public bool EmpleadoValidar(string usu, string pas)
        {
            return dao.validar(usu, pas);
        }
    }
}
