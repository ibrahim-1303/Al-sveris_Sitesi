using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Firma.Northwind.Entities.Concrete
{
  public  class ShippingDetails
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        [Range(15,75)]
        public int Age { get; set; }
    }
}
