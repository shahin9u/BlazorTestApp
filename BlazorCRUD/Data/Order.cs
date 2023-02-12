using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTestApp.Data
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
  
    }
}
