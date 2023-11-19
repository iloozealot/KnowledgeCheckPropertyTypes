using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AddressModel
    {
        public int StreetNumber {  get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }

        public string FullAddress
        {
            get
            {
                return $"{StreetNumber} {StreetName} {City}, {State} {PostalCode}.";
            }
        }
    }
}
