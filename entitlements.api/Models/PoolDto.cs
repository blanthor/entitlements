using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitlements.api.Models
{
    public class PoolDto
    {
        public int Id { get; set; }
        public int SubsId { get; set; }

        public virtual SubscriptionDto Subscription { get; set; }

        public virtual List<FullfillmentBucketDto> FullfillmentBuckets { get; set; }
    }
}
