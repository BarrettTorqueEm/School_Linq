using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products1.Models
{
    public class ProductList
    {
        private List<Product> aListOfProducts = new List<Product>();

        public void Add(Product aProduct)
        {
            this.aListOfProducts.Add(aProduct);
        }

        public void Clear()
        {
            aListOfProducts.Clear();
        }

        public override string ToString()
        {
            string message = "";
            foreach (var aProduct in aListOfProducts)
            {
                message = message + aProduct.ToString() + "\n\n";
            }
            return message;
        }
    }
}