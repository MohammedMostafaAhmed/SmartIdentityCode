using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartIdentity.Models
{
    public class PersonDto

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string Blood { get; set; }
        public string Job { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string ParentContact { get; set; }
        public string HealthStatus { get; set; }
    }
}