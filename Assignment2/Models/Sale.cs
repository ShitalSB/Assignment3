using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public int SaleCustomerId { get; set; }
        public virtual Customer SaleCustomer { get; set; }

        public int SaleStoreLocationId { get; set; }
        public virtual StoreLocation SaleStoreLocation { get; set; }

        public virtual ICollection<Product> Prodcuts { get; set; }

        public string SaleMakerId { get; set; }
        public virtual Employee SaleMaker { get; set; }

        public string SaleAproverId { get; set; }
        public virtual Employee SaleAprover { get; set; }
    }
}