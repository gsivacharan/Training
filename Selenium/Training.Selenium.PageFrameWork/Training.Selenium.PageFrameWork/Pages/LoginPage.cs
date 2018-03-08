using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using java.lang;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Training.Selenium.PageFrameWork.Helper;
using Boolean = System.Boolean;

namespace Training.Selenium.PageFrameWork.Pages
{
    public class LoginPage : TestBase
    {
        // Page Factory

        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement UserNamElement;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement UserPasswordElement;

        [FindsBy(How = How.XPath, Using = "//input[@type=\"submit\"]")]
        private IWebElement LoginButtonElement;

        [FindsBy(How=How.XPath,Using = "//a[@href=\"https://www.freecrm.com/login.cfm?pr=1\"]")]
        private IWebElement ForgotPasswordElement;

        [FindsBy(How= How.XPath, Using = "//button[contains(text(),\"Sign Up\")]")]
        private IWebElement SignUpElement;

        [FindsBy(How = How.ClassName, Using = "img-responsive")]
        private IWebElement LogoElement;

        [FindsBy(How = How.XPath, Using= "//a[contains(text(),\"Features\")]")]
        private IWebElement FeaturElement;

        [FindsBy(How = How.XPath,Using = "//a[contains(text(),\"Sign Up\")]")]
        private IWebElement MenuSingElement;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),\"Pricing\")]")]
        private IWebElement PricingElement;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),\"Customers\")]")]
        private IWebElement CustomerElement;

        [FindsBy(How = How.XPath,Using = "//a[contains(text(),\"Contact\")]")]
        private IWebElement ContactElement;
        
        
        public LoginPage()
        {
            PageFactory.InitElements(Driver,this);
        }

        //Actions
        public string ValidateLoginPageTitle()
        {
            return Driver.Title;
        }

        public Boolean ValidateCrmImage()
        {
            return LogoElement.Displayed;
        }

        public HomePage Login(string userName, string password)
        {
            UserNamElement.Clear();
            UserNamElement.SendKeys(userName);

            UserPasswordElement.Clear();
            UserPasswordElement.SendKeys(password);

            Thread.sleep(1000);
            LoginButtonElement.Click();
            return new HomePage();
        }
    }
}
