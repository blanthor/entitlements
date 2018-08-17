using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entitlements.api.Models
{
    public class License
    {
        public int Id { get; set; }
        public Guid Fguid { get; set; }
        public int SubsId { get; set; }
    }
}
