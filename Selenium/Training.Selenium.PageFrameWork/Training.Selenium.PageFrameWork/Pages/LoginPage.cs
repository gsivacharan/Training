using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Training.Selenium.PageFrameWork.Helper;
using System.Threading;

namespace Training.Selenium.PageFrameWork.Pages
{
    public class LoginPage : TestBase
    {
        // Page Factory

        [FindsBy(How = How.Name, Using = "username")] private IWebElement userNameInput;

        [FindsBy(How = How.Name, Using = "password")] private IWebElement passwordInput;

        [FindsBy(How = How.XPath, Using = "//input[@type=\"submit\"]")] private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//a[@href=\"https://www.freecrm.com/login.cfm?pr=1\"]")] private IWebElement
            ForgotPasswordElement;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),\"Sign Up\")]")] private IWebElement SignUpElement;

        [FindsBy(How = How.ClassName, Using = "img-responsive")] private IWebElement LogoElement;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),\"Features\")]")] private IWebElement FeaturElement;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),\"Sign Up\")]")] private IWebElement MenuSingElement;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),\"Pricing\")]")] private IWebElement PricingElement;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),\"Customers\")]")] private IWebElement CustomerElement;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),\"Contact\")]")] private IWebElement ContactElement;


        public LoginPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        //Actions
        public bool ValidateWithNoUserName(string password)
        {
            passwordInput.Clear();
            passwordInput.SendKeys(password);
            loginButton.Click();
            return Driver.Url.Contains("e=1") ? true : false;
        }

        public bool ValidateWithNoPassword(string username)
        {
            userNameInput.Clear();
            userNameInput.SendKeys(username);
            loginButton.Click();
            return Driver.Url.Contains("e=1") ? true : false;
        }

        public bool ValidateWithNoUserNameAndPassword()
        {
            loginButton.Click();
            return Driver.Url.Contains("e=1") ? true : false;
        }

        public string validateLoginWithRightValues(string username, string password)
        {
            userNameInput.Clear();
            userNameInput.SendKeys(username);

            passwordInput.Clear();
            passwordInput.SendKeys(password);

            Thread.Sleep(TimeSpan.FromSeconds(10));

            loginButton.Click();

            base.SwitchToMainFrame();
            Thread.Sleep(TimeSpan.FromSeconds(10));

            return
                Driver.FindElement(By.XPath("//td[@class=\"headertext\" and contains(text(),\"siva gavvala\")]")).Text;
        }

        public HomePage Login(string username, string password)
        {
            userNameInput.Clear();
            userNameInput.SendKeys(username);

            passwordInput.Clear();
            passwordInput.SendKeys(password);

            Thread.Sleep(TimeSpan.FromSeconds(10));

            loginButton.Click();

            return new HomePage();
        }
    }
}
