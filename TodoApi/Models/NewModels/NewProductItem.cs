using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolblueApi.Models.NewModels
{
    public class NewProductItem
    {
        public long Id { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public double productPrice { get; set; }
    }
}
