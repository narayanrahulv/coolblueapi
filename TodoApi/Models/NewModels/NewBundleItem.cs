using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolblueApi.Models
{
    public class NewBundleItem
    {
        public long Id { get; set; }
        public String bundleName { get; set; }
        public double bundlePrice { get; set; }
    }
}
