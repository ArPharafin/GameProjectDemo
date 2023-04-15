using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Product product, Player player, Campaing campaing);
        
        void Discount(Product product,Player player, Campaing campaing);

        

    }
}
