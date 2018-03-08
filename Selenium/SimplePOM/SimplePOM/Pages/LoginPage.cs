using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SimplePOM.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SimplePOM.Pages
{
    public class LoginPage : BaseTest
    {
        //PageFactory Objects

        [FindsBy(How = How.XPath, Using = "//input[@name=\"username\"]")]
        private IWebElement userNameInput;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"password\"]")]
        private IWebElement passwordInput;

        [FindsBy(How = How.XPath, Using = "//input[@type=\"submit\" and @value=\"Login\"]")]
        private IWebElement loginButton;

        public LoginPage()
        {
            PageFactory.InitElements(Driver,this);
        }

        public Boolean ValidateWithNoUserName(string password)
        {
            passwordInput.Clear();
            passwordInput.SendKeys(password);
            loginButton.Click();
            return Driver.Url.Contains("e=1") ? true : false;
        }

        public Boolean ValidateWithNoPassword(string username)
        {
            userNameInput.Clear();
            userNameInput.SendKeys(username);
            loginButton.Click();
            return Driver.Url.Contains("e=1") ? true : false;
        }

        public Boolean ValidateWithNoUserNameAndPassword()
        {
            loginButton.Click();
            return Driver.Url.Contains("e=1") ? true : false;
        }

        public string  validateLoginWithRightValues(string username, string password)
        {
            userNameInput.Clear();
            userNameInput.SendKeys(username);

            passwordInput.Clear();
            passwordInput.SendKeys(password);

            Thread.Sleep(TimeSpan.FromSeconds(10));

            loginButton.Click();

            SwitchMainFrame();
            Thread.Sleep(TimeSpan.FromSeconds(10));

            return Driver.FindElement(By.XPath("//td[@class=\"headertext\" and contains(text(),\"siva gavvala\")]")).Text;
        }
    }
}
