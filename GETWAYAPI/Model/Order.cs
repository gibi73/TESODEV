﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETWAYAPI.Model
{
    public class Order
    {

        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public string Status { get; set; }

        public Product Product { get; set; }

        public Address Address { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
