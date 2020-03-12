using Firma.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Northwind.Business.Abstact
{
  public  interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int CategoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int ProductId);
        Product GetById(int productId);
    }
}
