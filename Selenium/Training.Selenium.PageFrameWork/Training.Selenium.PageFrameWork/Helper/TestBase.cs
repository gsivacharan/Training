using System;
using System.Configuration;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Training.Selenium.PageFrameWork.Helper
{
    public class TestBase
    {
        protected static IWebDriver Driver;
        protected ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected ExtentHtmlReporter HtmlReporter;
        protected ExtentTest TestInfo;
        protected ExtentReports Reports;

        public enum Browsers
        {
            Chrome,
            Ie,
            FireFox
        }

        public void Initiate()
        {
            SelectBrowser(Browsers.Chrome);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Util.IMPLICIT_WAIT);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Util.PAGE_LOAD_TIMEOUT);
            Driver.Url = GetKeyValue("url");

            // Issue found in Extend Reports Need to be fixed later......
            //ConfigureExtentReports();

        }

        public void Close()
        {
            Driver.Close();
            Driver.Quit();
        }

        private void ConfigureExtentReports()
        {
            HtmlReporter = new ExtentHtmlReporter(GetKeyValue("ReportPath"));
            HtmlReporter.LoadConfig(GetKeyValue("ReportConfigFile"));
            Reports = new ExtentReports();
            Reports.AddSystemInfo("Environment", "QA");
            Reports.AttachReporter(HtmlReporter);
        }
        
        private void SelectBrowser(Browsers browser)
        {
            switch (browser)
            {
                case Browsers.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case Browsers.FireFox:
                    Driver = new FirefoxDriver();
                    break;
                case Browsers.Ie:
                    Driver = new InternetExplorerDriver();
                    break;
            }
        }

        public void TakeScreenshot()
        {
            //ITakesScreenshot ssdriver = Driver as ITakesScreenshot;
            //Screenshot screenshot = ssdriver.GetScreenshot();
            //screenshot.SaveAsFile(ImageLocation, ScreenshotImageFormat.Bmp);
        }

        public string GetKeyValue(string key)
        {
            var appSettings = new AppSettingsReader();
            return (string) appSettings.GetValue(key, typeof(string));
        }

        public void SwitchToMainFrame()
        {
            Driver.SwitchTo().Frame("mainpanel");
        }

    }
}
