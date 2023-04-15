using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public  class SaleManager : ISaleService
    {
        public void Discount(Product product, Player player, Campaing campaing)
        {
            Console.WriteLine(product.ProductID+"Id'ed Product price is been changed on discount rate");
        }

        public void Sale(Product product, Player player, Campaing campaing)
        {
            Console.WriteLine(product.ProductName+"named Product is been sold");
        }
    }
}
