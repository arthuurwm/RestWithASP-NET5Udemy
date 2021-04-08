using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Base;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create (T item);

        T FindByID (long ID);

        List<T> FindAll();

        T Update (T item);

        void Delete (long ID);

        bool Exists(long id);
    }
}