using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
    }
}