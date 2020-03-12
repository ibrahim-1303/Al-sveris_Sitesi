using Firma.Core.DataAccess.EntityFramework;
using Firma.Northwind.DataAccess.Abstract;
using Firma.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Northwind.DataAccess.Conctere.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
       
    }
}
