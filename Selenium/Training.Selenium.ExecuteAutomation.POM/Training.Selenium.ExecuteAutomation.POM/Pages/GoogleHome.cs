using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Training.Selenium.ExecuteAutomation.POM.Models;

namespace Training.Selenium.ExecuteAutomation.POM.Pages
{
    public class GoogleHome:PageModel
    {
        
        [FindsBy(How=How.Name,Using = "q")]
        internal IWebElement SearchText;

        [FindsBy(How = How.Name, Using = "btnK")]
        internal IWebElement SearchButton;

        [FindsBy(How = How.Id, Using = "vn1s0p1c0")]
        internal IWebElement SeleniumLink;


        public GoogleHome(IWebDriver driver) : base(driver)
        {
        }

        public void Search(string search)
        {
            var element = Driver.FindElement(By.TagName("input"));
            SearchText.Clear();
            SearchText.SendKeys(search);
            SearchButton.Submit();
        }

        public void ClickSeleniumLink()
        {
            SeleniumLink.Click();
        }
    }
}
