using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolblueApi.Models
{
    public class ProductBundleItem
    {
        public long Id { get; set; }
        public String bundleName { get; set; }
        public long productId { get; set; }
        public String productName { get; set; }
        public double bundlePrice { get; set; }
        //public List<String> productsInBundle { get; set; }
    }
}
