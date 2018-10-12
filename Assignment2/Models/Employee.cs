using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        [InverseProperty("SaleMaker")]
        public virtual ICollection<Sale> MakerSales { get; set; }

        [InverseProperty("SaleAprover")]
        public virtual ICollection<Sale> AproverSales { get; set; }

        public Employee()
        {
            MakerSales = new HashSet<Sale>();
            AproverSales = new HashSet<Sale>();
        }
    }
}