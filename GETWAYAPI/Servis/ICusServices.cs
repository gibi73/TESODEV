﻿using GETWAYAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETWAYAPI.Servis
{
 interface ICusServices
    {
        Task<Customer> CustomerGetir(Guid customerId);
    }
}
