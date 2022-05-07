using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo03.Service
{
    public interface BusinessService<T>
    {
        //definir las firmas
        int create(T t);
        int update(T t);
        int delete(T t);
        T findById(object t);
        List<T> readAll();
    }
}
