using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        [InverseProperty("SaleMaker")]
        public ICollection<Sale> MakerSales { get; set; }

        [InverseProperty("SaleAprover")]
        public ICollection<Sale> AproverSales { get; set; }

        public Employee()
        {
            MakerSales = new HashSet<Sale>();
            AproverSales = new HashSet<Sale>();
        }
    }
}