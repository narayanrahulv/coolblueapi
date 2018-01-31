using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolblueApi.Models.NewModels
{
    public class NewCustomerItem
    {
        public long Id { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerEmail { get; set; }
    }
}
