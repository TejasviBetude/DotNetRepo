using AssignmentMVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssignmentMVC01.Models;
using AssignmentMVC01.ViewModel;

namespace AssignmentMVC01.ViewModel
{
    public class AllDetailsViewModel
    {
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
        public Customer Customer { get; set; }
        public string Headermessage { get; set; }

    }
}