using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace Training.Selenium.ExecuteAutomation.POM.Test
{
    [TestFixture]
    public partial class ChromeTestBase
    {
        protected static IWebDriver Driver;
        public enum Browsers
        {
            Chrome,
            IE,
            Safari,
            FireFox
        }

       [SetUp]
        public void InIt(Browsers browser)
        {
            Driver = new ChromeDriver();
        }

        [TearDown]
        public void EndTest()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Close();
            Driver.Quit();
        }

        // Not used yet
        private void SetBrowser(Browsers browser)
        {
            switch (browser)
            {
                case Browsers.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case Browsers.IE:
                    Driver = new InternetExplorerDriver();
                    break;
                case Browsers.Safari:
                    Driver = new SafariDriver();
                    break;
                case Browsers.FireFox:
                    Driver = new FirefoxDriver();
                    break;
            }
        }
    }
}
