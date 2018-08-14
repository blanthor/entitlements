using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitlements.api.Models
{
    public class FullfillmentBucketDto
    {
        public Guid Fguid { get; set; }
        public int PoolId { get; set; }

        public virtual PoolDto Pool { get; set; }

        public virtual List<LicenseDto> Licenses { get; set; }

    }
}
