using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Training.Selenium.PageFrameWork.Helper;

namespace Training.Selenium.PageFrameWork.Pages
{
    public class ContactsPage:TestBase
    {
       

        public ContactsPage()
        {
           PageFactory.InitElements(Driver,this);
        }

        public string VerifyContactsTitle()
        {
            return Driver.Url;
        }
    }
}
