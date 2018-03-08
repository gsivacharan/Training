using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Selenium.PageFrameWork.Utils
{
    public class Address
    {
        public string Title { get; set; }
        public AddressTypes Type { get; set; }
        public string DefaultAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Tags { get; set; }
        public string Notes { get; set; }
        public string ContactTimeZone { get; set; }
        public string TimeZoneByCountry { get; set; }
    }
}
