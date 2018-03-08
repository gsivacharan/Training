using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Training.Selenium.PageFrameWork.Helper;

namespace Training.Selenium.PageFrameWork.Pages
{
    public class HomePage : TestBase
    {
        
        [FindsBy(How = How.XPath, Using = "//td[contains(text(),\"User\")]")]
        private IWebElement UserNameLable;

        [FindsBy(How = How.XPath, Using = "//a[@title=\"Contacts\"]")]
        private IWebElement ContactsMenuLink;

        [FindsBy(How = How.XPath, Using = "//a[@title=\"Calender\"]")]
        private IWebElement CalenderMenuLink;

        [FindsBy(How = How.XPath, Using = "//a[@title=\"Companies\"]")]
        private IWebElement CompaniesMenuLink;
        
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'New Contact')]")]
        private IWebElement newContactLink;

        [FindsBy(How = How.XPath, Using = "//a[@title=\"Deals\"]")]
        private IWebElement DealsMenuLink;

        [FindsBy(How = How.XPath, Using = "//a[@title=\"Tasks\"]")]
        private IWebElement TasksMenuLink;

        [FindsBy(How = How.XPath, Using = "//td[@class=\"datacardtitle\" and contains(text(),\"Contacts\")]")]
        private IWebElement contactLable;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'New Company')]")]
        private IWebElement newCompanyLink;

        public HomePage()
        {
            PageFactory.InitElements(Driver,this);
        }

        public string VerfyHompageTitle()
        {
            return Driver.Title;
        }

        public ContactsPage ClickOnContactsLink()
        {
            CalenderMenuLink.Click();
            return new ContactsPage();
        }

        public CalenderPage ClickCalenderLink()
        {
            CalenderMenuLink.Click();
            return new CalenderPage();
        }

        public CompanyPage ClickCompanyLink()
        {
            Thread.Sleep(100);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(e => e.FindElement(By.XPath("//a[contains(text(),\"Companies\") and @title=\"Companies\"]"))).Click();
            return new CompanyPage();
        }

        public void ClickOnNewCompanyLink()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(CompaniesMenuLink).Build().Perform();
            newCompanyLink.Click();
        }
    }
}
