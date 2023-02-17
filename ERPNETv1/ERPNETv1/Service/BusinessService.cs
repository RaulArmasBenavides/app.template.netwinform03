using System.Collections.Generic;

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
