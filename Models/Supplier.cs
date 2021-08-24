using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyManagementSystem.Models
{
   
    public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierID {get;set;}
        [Display(Name ="Supplier")]
       public string SupplierName { get; set; }
        [Display(Name = "Contact")]
        public string ContactName { get; set; }

        [Display(Name = "Phone Number")]
        public string SupplierPhone { get; set; }


        public virtual ICollection<Product> Products { get; set; }

        
    }
}
