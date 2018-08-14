using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitlements.api.Models
{
    public class EntitlementDto
    {
        public string LicenseId { get; set; }
        public string EntitlementId { get; set; }

        public virtual CustomerDto Customer { get; set; }

        public virtual List<PoolDto> { get; set; }

    }
}
