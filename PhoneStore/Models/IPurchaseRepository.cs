﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Models
{
    public interface IPurchaseRepository
    {
        void Add(Purchase purchase);
    }
}
