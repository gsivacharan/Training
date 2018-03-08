using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Training.Selenium.ExecuteAutomation.POM.Models
{
    public class PageModel
    {
        protected readonly IWebDriver Driver;

        public PageModel(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(Driver,this);
        }
    }
}
