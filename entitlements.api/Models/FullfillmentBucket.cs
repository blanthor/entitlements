using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitlements.api.Models
{
    public class FullfillmentBucket
    {
        public Guid Fguid { get; set; }
        public int PoolId { get; set; }

        public virtual Pool Pool { get; set; }

        public virtual List<License> Licenses { get; set; }

    }
}
