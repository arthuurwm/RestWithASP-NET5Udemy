using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository
{
    public interface IBookRepository
    {
        Book Create(Book person);

        Book FindByID(long ID);

        List<Book> FindAll();

        Book Update(Book person);

        void Delete(long ID);

        bool Exists(long id);
    }
}