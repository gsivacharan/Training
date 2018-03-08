using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Selenium.PageFrameWork.Utils
{
    public class Company
    {
        public string Name { get; set; }
        public string Industry { get; set; }
        public string AnualRevenue { get; set; }
        public string Employees { get; set; }
        public Status Status { get; set; }
        public CompanyCategory Cateogyr { get; set; }
        public Priority Priority { get; set; }
        public Source Source { get; set; }
        public string Identifier { get; set; }
        public string VatNumber { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string Symbol { get; set; }
        public string ParentCompany { get; set; }
        public string Owner { get; set; }
        public Address Address { get; set; }
    }
}
