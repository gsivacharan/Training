using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Selenium.PageFrameWork.Utils
{
    public class Contact
    {
        public Title Title { get; set; }
        public string FirstName{ get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Suffix Suffix { get; set; }
        public string NikName { get; set; }
        public string  Company { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Superviso{ get; set; }
        public string Assistant { get; set; }
        public string ReferBy { get; set; }
        public string Owner { get; set; }
        public ContactCategory Category { get; set; }
        public Status Status { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public string EmailAlternative { get; set; }
        public string ReceiveEmail { get; set; }
        public string ReceiveSMS { get; set; }
        public string AllowCalls { get; set; }
        public string MessangerID { get; set; }
        public MessengerNetWork MessengerNetWork { get; set; }
        public string SkypeId { get; set; }
        public  Source Source { get; set; }
        public DateTime BirthDay { get; set; }
        public string Identifier { get; set; }

    }

    
}
