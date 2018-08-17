using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitlements.api.Models
{
    public class Pool
    {
        public int Id { get; set; }
        public int SubsId { get; set; }

        public virtual Subscription Subscription { get; set; }

        public virtual List<FullfillmentBucket> FullfillmentBuckets { get; set; }
    }
}
