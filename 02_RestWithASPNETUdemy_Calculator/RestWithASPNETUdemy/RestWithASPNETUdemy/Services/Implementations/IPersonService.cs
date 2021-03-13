using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public interface IPersonService
    {
        Person Create (Person person);

        Person FindByID (long ID);

        List<Person> FindAll();

        Person Update (Person person);

        void Delete (long ID);
    }
}