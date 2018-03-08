using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Training.Selenium.InterviewQuestions.Helper
{
    public class TestBase
    {
        public IWebDriver driver;
        public string url = "http://localhost/DemoSite/demoSite.htm";

        public string ImageLocation = @"C:\Temp\Test.bmp";  
        
        
        public enum Browsers
        {
            Chrome,
            Ie,
            FireFox
        }

        public void InIt()
        {
            SelectBrowser(Browsers.Chrome);
            getUrl(url);
        }

        public void Close()
        {
            driver.Close();
            driver.Quit();
        }

        private void getUrl(string url)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

       private void SelectBrowser(Browsers browser)
        {
            switch (browser)
            {
                case Browsers.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Browsers.FireFox:
                    driver = new FirefoxDriver();
                    break;
                case Browsers.Ie:
                    driver = new InternetExplorerDriver();
                    break;            }
        }

        public void TakeScreenshot()
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            screenshot.SaveAsFile(ImageLocation, ScreenshotImageFormat.Bmp);
        }


    }
}
