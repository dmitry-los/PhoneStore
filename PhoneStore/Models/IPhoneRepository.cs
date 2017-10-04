using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Models
{
    public interface IPhoneRepository
    {
        Phone Get(int id);
        IEnumerable<Phone> GetAll();        
        void Add(Phone phone);
    }
}
