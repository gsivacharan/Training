using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Training.Selenium.PageFrameWork.Helper;

namespace Training.Selenium.PageFrameWork.Pages
{
    public class ContactUs
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "PreviewFrame")]
        internal IWebElement HomePageIFramElement;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"SiteNav\"]/ul[1]/li[4]/a")]
        internal IWebElement ContactUsLink;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ContactFormName']")]
        internal IWebElement UserNameElement;

        [FindsBy(How = How.XPath, Using = ".//*[@id=\'ContactFormEmail\']")]
        internal IWebElement UserEmailElement;

        [FindsBy(How = How.XPath, Using = ".//*[@id=\'ContactFormPhone\']")]
        internal IWebElement UserPhonElement;

        [FindsBy(How = How.XPath, Using = ".//*[@id=\'ContactFormMessage\']")]
        internal IWebElement UserMessagElement;

        [FindsBy(How = How.XPath, Using = ".//*[@id=\'contact_form\']/input[6]")]
        internal IWebElement SendElement;

        [FindsBy(How = How.CssSelector, Using = "shopify-challenge__message")]
        public IWebElement ConfirmTextElement;

        public string ConfirmText = "To continue, let us know you're not a robot.";


        public ContactUs(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //public void ValidateContactUs(User user)
        //{

        //    driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id=\"PreviewFrame\"]")));
        //    ContactUsLink.Click();
        //    //driver.SwitchTo().DefaultContent(); // Not sure why we did not switch back to default frame?
        //    Thread.Sleep(10000);
        //    UserNameElement.Clear();
        //    UserNameElement.SendKeys(user.UserName);
        //    UserEmailElement.Clear();
        //    UserEmailElement.SendKeys(user.UserEmail);
        //    UserPhonElement.Clear();
        //    UserPhonElement.SendKeys(user.UserPhoneNumber);
        //    UserMessagElement.Clear();
        //    UserMessagElement.SendKeys(user.UserMessage);
        //    SendElement.Click();
        //    var windows = driver.WindowHandles;
        //    foreach (var win in windows){
        //        //TEST
        //    }
        //}

        public bool VerifyContactSuccess()
        {
            Thread.Sleep(1000);
            var message = WaitForElement(60, ".//*[@id=\'MainContent\']/div/p").Text;
            return message.Equals(ConfirmText, StringComparison.CurrentCultureIgnoreCase);
        }

        public IWebElement WaitForElement(int seconds, string xPath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(seconds));
            return wait.Until(x => x.FindElement(By.XPath(xPath)));
        }
    }
}
