using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolblueApi.Models
{
    public class OrderItem
    {
        public long referenceId { get; set; }
        //+++++++++++++++++++++++++++++++++++++++++++++
        //idea was to create a list of ProductItems and BundleItems so that we can add as many as we want to an order
        //however, couldn't really get that working which is why i tried individual productId and bundleId
        //public List<ProductItem> orderproducts { get; set; }
        //+++++++++++++++++++++++++++++++++++++++++++++
        public int productId { get; set; }
        public int bundleId { get; set; }
        public double orderPrice { get; set; }
    }
}
