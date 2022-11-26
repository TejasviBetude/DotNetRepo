using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentMVC01.Models
{
    public class Product
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string supplier { get; set; }

    }
    
}