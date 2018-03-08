﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Training.Selenium.ExecuteAutomation.POM.Pages
{
    public class SeleniumPageObjects
    {
        public SeleniumPageObjects(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }

        public void ClickDownloadLink()
        {
            
        }
    }
}
