using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolblueApi.Models.NewModels
{
    public class NewOrderItem
    {
        public long Id { get; set; }
        public long productId { get; set; }
        public double orderPrice { get; set; }
        public long customerId { get; set; }
    }
}
