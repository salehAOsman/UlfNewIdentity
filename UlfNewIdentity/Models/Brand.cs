using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UlfNewIdentity.Models
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        List<Car> Cars { get; set; }         // *---> 1 to brand
    }
}