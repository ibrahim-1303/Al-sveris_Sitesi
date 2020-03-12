using Firma.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Northwind.Business.Abstact
{
  public interface ICartService
    {

        void AddToCart(Cart cart, Product product);

        void RemovoFromCart(Cart cart, int productId);
        IList<CartLine> List(Cart cart);
    }
}
