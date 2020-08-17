using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace well_beings.Models
{
    public class Retailer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lat { get; set; }
        public string Long {get;set; }
        public string Country { get; set; }
        public string ProvinceState { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Telephone { get; set; }
    }
}
