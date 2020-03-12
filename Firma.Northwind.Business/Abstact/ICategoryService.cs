using Firma.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Northwind.Business.Abstact
{
  public  interface ICategoryService
    {
        List<Category> GetAll();
       


    }
}
