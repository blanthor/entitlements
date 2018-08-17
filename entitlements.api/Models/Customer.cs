using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitlements.api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int SubsId { get; set; }
        public string Name { get; set; }

        public virtual List<Subscription> Subscriptions { get; set; }
    }
}
