﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitlements.api.Models
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public int SubsId { get; set; }
        public string Name { get; set; }
    }
}
