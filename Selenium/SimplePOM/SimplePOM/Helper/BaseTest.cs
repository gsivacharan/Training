using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace SimplePOM.Helper
{
    public class BaseTest
    {
        protected static IWebDriver Driver;

        public void Initiate()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Driver.Url = GetAppKey("url");
        }

        public void Close()
        {
            Driver.Close();
            Driver.Quit();            
        }

        public void SwitchMainFrame()
        {
            Driver.SwitchTo().Frame("mainpanel");
        }

        public string GetAppKey(string key)
        {
            var appReader = new AppSettingsReader();
            return appReader.GetValue(key,typeof(string)).ToString();
        }
    }
}
