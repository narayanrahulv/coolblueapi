using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CoolblueApi.Models;
using System.Linq;
using System;
using CoolblueApi.Models.NewModels;
using System.Globalization;

namespace CoolblueApi.Controllers
{
    [Route("api/[controller]")]
    public class CoolblueController : Controller
    {
        private readonly CoolblueContext _context;

        public CoolblueController(CoolblueContext context)
        {
            _context = context;

            //add products
            if (_context.newproducts.Count() == 0)
            {
                createProductsNew(_context);
            }

            //add bundles
            if (_context.newbundles.Count() == 0)
            {
                createBundlesNew(_context);
            }

            //add product bundle associations
            if (_context.prodbundleassociations.Count() == 0)
            {
                createProductBundleAssociation(_context);
            }
        }

        //**************
        //SETUP METHODS (OLD)
        private void createProducts(CoolblueContext productaddcontext)
        {
            productaddcontext.products.Add(new ProductItem
            {
                productName = "iphone",
                productDescription = "this is an iphone from apple",
                productPrice = 200
            });

            productaddcontext.products.Add(new ProductItem
            {
                productName = "iphone screen protector",
                productDescription = "this is an iphone screen protector",
                productPrice = 20
            });

            productaddcontext.products.Add(new ProductItem
            {
                productName = "iphone battery",
                productDescription = "this is an iphone battery",
                productPrice = 120
            });

            productaddcontext.products.Add(new ProductItem
            {
                productName = "iphone case",
                productDescription = "this is an iphone case",
                productPrice = 50
            });

            productaddcontext.products.Add(new ProductItem
            {
                productName = "samsung TV",
                productDescription = "this is a samsung smart tv",
                productPrice = 5000
            });

            productaddcontext.products.Add(new ProductItem
            {
                productName = "samsung TV HD cable",
                productDescription = "this is an HDMI cable to be used with samsung smart tv",
                productPrice = 100
            });
            productaddcontext.SaveChanges();
        }

        private void createProductBundles(CoolblueContext bundleaddcontext)
        {
            bundleaddcontext.bundles.Add(new ProductBundleItem
            {
                bundleName = "iphone basic",
                productId = 1,
                productName = "iphone",
                bundlePrice = 237.50
            });

            bundleaddcontext.bundles.Add(new ProductBundleItem
            {
                bundleName = "iphone basic",
                productId = 2,
                productName = "iphone case",
                bundlePrice = 237.50
            });

            bundleaddcontext.bundles.Add(new ProductBundleItem
            {
                bundleName = "TV bonus",
                productId = 5,
                productName = "samsung TV",
                bundlePrice = 4845
            });

            bundleaddcontext.bundles.Add(new ProductBundleItem
            {
                bundleName = "TV bonus",
                productId = 6,
                productName = "samsung TV HD cable",
                bundlePrice = 4845
            });
            bundleaddcontext.SaveChanges();
        }
        //**************
        //END SETUP METHODS (OLD)

        //**************
        //NEW SETUP METHODS
        private void createProductsNew(CoolblueContext productaddcontext)
        {
            productaddcontext.newproducts.Add(new NewProductItem
            {
                productName = "iphone",
                productDescription = "this is an iphone from apple",
                productPrice = 200
            });

            productaddcontext.newproducts.Add(new NewProductItem
            {
                productName = "iphone screen protector",
                productDescription = "this is an iphone screen protector",
                productPrice = 20
            });

            productaddcontext.newproducts.Add(new NewProductItem
            {
                productName = "iphone battery",
                productDescription = "this is an iphone battery",
                productPrice = 120
            });

            productaddcontext.newproducts.Add(new NewProductItem
            {
                productName = "iphone case",
                productDescription = "this is an iphone case",
                productPrice = 50
            });

            productaddcontext.newproducts.Add(new NewProductItem
            {
                productName = "samsung TV",
                productDescription = "this is a samsung smart tv",
                productPrice = 5000
            });

            productaddcontext.newproducts.Add(new NewProductItem
            {
                productName = "samsung TV HD cable",
                productDescription = "this is an HDMI cable to be used with samsung smart tv",
                productPrice = 100
            });
            productaddcontext.SaveChanges();
        }
        
        private void createBundlesNew(CoolblueContext bundleaddcontext)
        {
            bundleaddcontext.newbundles.Add(new NewBundleItem
            {
                bundleName = "iphone basic",
                bundlePrice = 237.50
            });

            bundleaddcontext.newbundles.Add(new NewBundleItem
            {
                bundleName = "iphone premium",
                bundlePrice = 500
            });

            bundleaddcontext.newbundles.Add(new NewBundleItem
            {
                bundleName = "TV bonus",
                bundlePrice = 4845
            });
            bundleaddcontext.SaveChanges();
        }

        private void createProductBundleAssociation(CoolblueContext prodbundleaddcontext)
        {
            //IPHONE BASIC BUNDLE
            prodbundleaddcontext.prodbundleassociations.Add(new ProdBundleAssociation
            {
                bundleId = 1,
                productId = 1
            });
            prodbundleaddcontext.prodbundleassociations.Add(new ProdBundleAssociation
            {
                bundleId = 1,
                productId = 2
            });
            //IPHONE PREMIUM BUNDLE
            prodbundleaddcontext.prodbundleassociations.Add(new ProdBundleAssociation
            {
                bundleId = 2,
                productId = 1
            });
            prodbundleaddcontext.prodbundleassociations.Add(new ProdBundleAssociation
            {
                bundleId = 2,
                productId = 2
            });
            prodbundleaddcontext.prodbundleassociations.Add(new ProdBundleAssociation
            {
                bundleId = 2,
                productId = 3
            });
            prodbundleaddcontext.prodbundleassociations.Add(new ProdBundleAssociation
            {
                bundleId = 2,
                productId = 4
            });
            //TV PACKAGE BUNDLE
            prodbundleaddcontext.prodbundleassociations.Add(new ProdBundleAssociation
            {
                bundleId = 3,
                productId = 5
            });
            prodbundleaddcontext.prodbundleassociations.Add(new ProdBundleAssociation
            {
                bundleId = 3,
                productId = 6
            });

            prodbundleaddcontext.SaveChanges();
        }
        //**************
        //NEW SETUP METHODS

        //**************
        //DEBUG METHODS
        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAllProductsNew()
        {
            var allproductslisting = _context.newproducts;

            return new ObjectResult(allproductslisting);
        }

        [HttpGet]
        [Route("GetAllBundles")]
        public IActionResult GetAllBundlesNew()
        {
            var allbundleslisting = _context.newbundles;

            return new ObjectResult(allbundleslisting);
        }

        [HttpGet]
        [Route("GetAllProdBundleAssociations")]
        public IActionResult GetAllProdBundles()
        {
            var allprodbundleslisting = _context.prodbundleassociations;

            return new ObjectResult(allprodbundleslisting);
        }

        [HttpGet]
        [Route("GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {
            var allcustomerslisting = _context.newcustomers;

            return new ObjectResult(allcustomerslisting);
        }

        [HttpGet]
        [Route("GetBundleProducts/{id}")]
        public IActionResult GetBundleProducts(long id)
        {
            var bundleprodlisting = from b in _context.newbundles
                                    join pb in _context.prodbundleassociations
                                        on b.Id equals pb.bundleId
                                    join p in _context.newproducts
                                        on pb.productId equals p.Id
                                    where b.Id == id
                                    select new { b.bundleName, b.bundlePrice, p.productName, p.productDescription, p.productPrice };
                                    

            return new ObjectResult(bundleprodlisting);
        }
        //**************
        //DEBUG METHODS

        [HttpGet]
        [Route("GetProductBundleDetails/{id}")]
        public IActionResult GetProductBundleDetails(long id)
        {
            var prodbundlelisting = from p in _context.newproducts
                              where p.Id == id
                              select new
                              {
                                  p.productName,
                                  p.productDescription,
                                  p.productPrice,
                                  bundleCount =
                                  (from pba in _context.prodbundleassociations
                                   where pba.productId == p.Id
                                   select pba).Count(),
                                  bundlesProductIsIn =
                                    (from pba in _context.prodbundleassociations
                                     join b in _context.newbundles
                                        on pba.bundleId equals b.Id
                                     where pba.productId == p.Id
                                     select new { b.bundleName, b.bundlePrice }),
                              };

            return new ObjectResult(prodbundlelisting);
        }

        [HttpGet]
        [Route("SearchProducts/{searchTerm}")]
        public IActionResult SearchProducts(string searchTerm)
        {
            var prodsearchresults = _context.newproducts.Where(s =>
                                                        CultureInfo.CurrentCulture.CompareInfo.IndexOf
                                                        (s.productDescription, searchTerm, CompareOptions.IgnoreCase) >= 0
                                                        || CultureInfo.CurrentCulture.CompareInfo.IndexOf(s.productName, searchTerm, CompareOptions.IgnoreCase) >= 0);

            return new ObjectResult(prodsearchresults);
        }

        [HttpGet("{id}", Name = "CustomerDetails")]
        public IActionResult GetCustomerById(long id)
        {
            var custsearchresults = from c in _context.newcustomers
                                    where c.Id == id
                                    select new { c.customerName, c.customerAddress, c.customerEmail };

            return new ObjectResult(custsearchresults);
        }

        [HttpPost]
        [Route("CreateCustomer")]
        public IActionResult CreateCustomer([FromBody] NewCustomerItem customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            _context.newcustomers.Add(customer);
            _context.SaveChanges();

            return new CreatedAtRouteResult("CustomerDetails", new { id = customer.Id }, customer);
        }

        [HttpGet("{id}", Name = "ProductOrderDetails")]
        public IActionResult GetOrderById(long id)
        {
            var orderresults = from o in _context.neworders
                               where o.Id == id
                               select new { o.productId, o.orderPrice };

            return new ObjectResult(orderresults);
        }

        [HttpPost]
        [Route("CreateProductsOrder")]
        public IActionResult CreateOrderWithProducts([FromBody] NewOrderItem order)
        {
            if (order == null)
            {
                return BadRequest();
            }

            _context.neworders.Add(order);
            _context.SaveChanges();

            return CreatedAtRoute("ProductOrderDetails", new { id = order.Id }, order);
        }

        [HttpGet("{id}", Name = "BundleOrderDetails")]
        public IActionResult GetBundleOrderById(long id)
        {
            var orderresults = from o in _context.neworders
                               where o.Id == id
                               select new { o.productId, o.orderPrice };

            return new ObjectResult(orderresults);
        }


        [HttpPost]
        [Route("CreateBundleOrder/{customerid}")]
        public IActionResult CreateOrderWithBundle([FromBody] NewBundleItem orderbundle, [FromRoute] long customerid)
        {
            //create a new order object
            NewOrderItem order = new NewOrderItem();

            //get all the products within the bundle
            var bundleprodlisting = from b in _context.newbundles
                                    join pb in _context.prodbundleassociations
                                        on b.Id equals pb.bundleId
                                    join p in _context.newproducts
                                        on pb.productId equals p.Id
                                    where b.Id == orderbundle.Id
                                    select new { p.Id, p.productPrice };

            //initialize the order price
            double orderprice = 0;

            //loop through each product and append it to the same order
            foreach(var item in bundleprodlisting)
            {
                order.productId = item.Id;
                //order.orderPrice = item.productPrice;
                orderprice += item.productPrice;
            }

            //calculate the order price by deducting 5% from the total cost
            orderprice = orderprice - (0.05 * orderprice);

            //set the order price
            order.orderPrice = orderprice;

            //set the customer id for the order from the URI
            order.customerId = customerid;

            _context.neworders.Add(order);
            _context.SaveChanges();

            return CreatedAtRoute("BundleOrderDetails", new { id = order.Id }, order);
        }

        [HttpGet]
        [Route("regularcustomers")]
        public IActionResult GetRegularCustomers()
        {
            //display customers who have had at least 1 order
            var regularcustomers = from c in _context.customers
                                   where c.customerOrders > 1
                                   select new { c.customerName, c.customerAddress, c.customerEmail };
            
            return new ObjectResult(regularcustomers);
        }
    }
}