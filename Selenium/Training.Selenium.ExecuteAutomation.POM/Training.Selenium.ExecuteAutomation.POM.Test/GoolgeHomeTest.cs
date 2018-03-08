using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Training.Selenium.ExecuteAutomation.POM.Pages;

namespace Training.Selenium.ExecuteAutomation.POM.Test
{
    [TestFixture]
    public class GoolgeHomeTest:ChromeTestBase
    {
        [Test]
        public void SearchGoogle()
        {
            Driver.Url = "https://online.vfsglobal.com/GlobalAppointment/Account/RegisterUser?Length=7";
            GoogleHome gHome = new GoogleHome(Driver);
            gHome.Search("selenium");
            Thread.Sleep(100);
            gHome.ClickSeleniumLink();
        }
    }
}
