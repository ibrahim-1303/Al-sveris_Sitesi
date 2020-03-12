using System.Collections.Generic;
using Firma.Northwind.Entities.Concrete;

namespace Firma.Northwind.MvcWebUI.Models
{
   public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}