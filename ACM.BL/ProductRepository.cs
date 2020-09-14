using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductName = "Biryani";
                product.ProductDescription = "Oil less and add more onions";
                product.CurrentPrice = 80;
            }
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }
    }
}
