using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyManagementSystem.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        
        [Display(Name ="Product")]
        public string ProductName { get; set; }

        public int SupplierID { get; set; }

        public int Stock { get; set; }

        public string OrderStatus { get; set; }

        public Supplier Supplier { get; set; }
    }
}
