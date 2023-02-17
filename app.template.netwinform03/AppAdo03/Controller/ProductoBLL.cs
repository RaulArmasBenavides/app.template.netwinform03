using ERPNETv1.Entity;
using ERPNETv1.Model;
using System.Collections.Generic;
using System.Data;

namespace ERPNETv1.Controller
{
    public class ProductoBLL
    {
        ProductoDAO dao;
        public ProductoBLL()
        {
            dao = new ProductoDAO();
        }
        // metodos de negocio
        public int ProductoAdicionar(ProductoTO p)
        {
            return dao.create(p);
        }

        public int ProductoActualizar(ProductoTO p)
        {
            return dao.update(p);
        }

        public int ProductoEliminar(ProductoTO p)
        {
            return dao.delete(p);
        }

        public ProductoTO ProductoBuscar(object p)
        {
            return dao.findById(p);
        }

        public List<ProductoTO> ProductoListar()
        {
            return dao.readAll();
        }

        public DataTable CategoriaListar()
        {
            return dao.readAllCategorias();
        }

        public DataTable ProveedorListar()
        {
            return dao.readAllProveedores();
        }

    }
}
