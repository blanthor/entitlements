using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitlements.api.Models
{
    public class Entitlement
    {
        public string LicenseId { get; set; }
        public string EntitlementId { get; set; }

        public Customer Customer { get; set; }

        public List<Pool> Pools{ get; set; }

    }
}
