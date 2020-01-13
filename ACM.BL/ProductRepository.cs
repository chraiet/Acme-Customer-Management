using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        //  Retrieve one product.
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            
            //  Temporary hard-coded values to return a populated product.
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        //  Saves the current customer.
        public bool Save(Customer customer)
        {
            //  Code that saves the passed in product.

            return true;
        }
    }
}
