using CoolblueApi.Models.NewModels;
using Microsoft.EntityFrameworkCore;

namespace CoolblueApi.Models
{
    public class CoolblueContext : DbContext
    {
        public CoolblueContext(DbContextOptions<CoolblueContext> options)
            :base(options)
        {
        }

        //OLD CODE
        public DbSet<CoolblueItem> TodoItems { get; set; }  //sample for debugging
        public DbSet<ProductItem> products { get; set; }
        public DbSet<ProductBundleItem> bundles { get; set; }
        public DbSet<CustomerItem> customers { get; set; }
        //END OLD CODE

        //*********************************
        //NEW CODE
        public DbSet<NewProductItem> newproducts { get; set; }
        public DbSet<NewBundleItem> newbundles { get; set; }
        public DbSet<ProdBundleAssociation> prodbundleassociations { get; set; }
        public DbSet<NewCustomerItem> newcustomers { get; set; }
        public DbSet<NewOrderItem> neworders { get; set; }
    }
}
