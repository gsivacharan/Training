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
    public class CalenderPage : TestBase
    {
        public CalenderPage()
        {
            PageFactory.InitElements(Driver,this);
        }

        public string VerifyCalnderTitle()
        {
            return Driver.Title;
        }

    }
}
