using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.Models
{
    public class PurchaseRepository : IPurchaseRepository
    {
        public void Add(Purchase purchase)
        {
            using(var context = new PhoneContext())
            {
                context.Purchases.Add(purchase);
                context.SaveChanges();
            }
        }
    }
}