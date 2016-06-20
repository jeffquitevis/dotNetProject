using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace FormFileStore
{
    public interface IDataStore
    {

        void AddPerson(Person person);
        Person SearchPerson(long id);
        void DeletePerson(long id);
    }
}
