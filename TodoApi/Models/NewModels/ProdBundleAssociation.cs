using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolblueApi.Models
{
    public class ProdBundleAssociation
    {
        public long Id { get; set; }
        public int bundleId { get; set; }
        public long productId { get; set; }
    }
}
