using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCRM.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        public string NameOrNum { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }

        public virtual Customer Customer { get; set; }
    }
}