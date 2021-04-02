using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository
    {
        Person Create (Person person);

        Person FindByID (long ID);

        List<Person> FindAll();

        Person Update (Person person);

        void Delete (long ID);

        bool Exists(long id);
    }
}