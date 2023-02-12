using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTestApp.Data
{
    public class SubElement
    {
        [Key]
        public int SubElementID { get; set; }
       
        public int Element { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int WindowID { get; set; }
        public List<Window> Windows { get; set; }

    }
}
