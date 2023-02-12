using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTestApp.Data
{
    public class Window
    {
        [Key]
        public int WindowID { get; set; }
        public string Name { get; set; }
        public int  QuantityOfWindows { get; set; }
        public int TotalSubElements { get; set; }
        public int OrderID { get; set; }
        public Order Orders { get; set; }


    }
}
