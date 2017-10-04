using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.Models
{
    public class PhoneRepository : IPhoneRepository
    {
        public void Add(Phone phone)
        {
            using(var context = new PhoneContext())
            {
                context.Phones.Add(phone);
                context.SaveChanges();
            }
        }

        public Phone Get(int id)
        {
            using (var context = new PhoneContext())
            {
                return context.Phones.FirstOrDefault(x => x.Id == id);
            }
        }

        public IEnumerable<Phone> GetAll()
        {
            using (var context = new PhoneContext())
            {
                return context.Phones;
            }
        }
    }
}