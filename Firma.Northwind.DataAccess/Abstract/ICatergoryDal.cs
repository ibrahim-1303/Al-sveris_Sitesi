using Firma.Core.DataAccess;
using Firma.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Northwind.DataAccess.Abstract
{
  public  interface ICatergoryDal:IEntityRepository<Category>
    {
    }
}
