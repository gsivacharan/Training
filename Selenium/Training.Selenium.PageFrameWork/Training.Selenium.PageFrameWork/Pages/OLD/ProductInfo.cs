using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public class ProductInfo

    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "PreviewFrame")]
        internal IWebElement HomePageIFramElement;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),\'Mens\') and @aria-expanded=\'false\']")]
        private IWebElement mensMenuElement;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),\'Womens\') and @aria-expanded=\'false\']")]
        private IWebElement woMensMenuElement;

        public ProductInfo(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void ClickOnNavigationMenu(string menuName)
        {
            SwitchToIFrame();
            Thread.Sleep(3000);
            if(menuName == "Mens")
                mensMenuElement.Click();
            else
                woMensMenuElement.Click();
        }

       public void ClickOnProductsInMensSection(string productName)
        {
            Thread.Sleep(1000);
            SwitchToIFrame();
            driver.FindElement(
                By.XPath(".//*[@id=\'Collapsible2\']/li/child::a[contains(text(),\'" + productName + "\')]")).Click();

           
        }

        public void ClickOnProductsInWomensSection(string productName)
        {
            
            driver.FindElement(
                By.XPath(".//*[@id=\'Collapsible2\']/li/child::a[contains(text(),\'" + productName + "\')]")).Click();
        }

        public void SwitchToIFrame()
        {
            driver.SwitchTo().Frame(HomePageIFramElement);
        }

        public void SwitchToDefault()
        {
            driver.SwitchTo().DefaultContent();
        }

        public void RightClick()
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(100));
            wait.Until(ExpectedConditions.ElementToBeClickable(mensMenuElement));
            try
            {
                Actions action = new Actions(driver);
                action.ContextClick(mensMenuElement).Build().Perform();
            }
            catch (StaleElementReferenceException e)
            {
                // Element was not attached to page document.
            }
            catch (NoSuchElementException e)
            {
                // Element was not found in DOM object
            }
            catch (Exception e)
            {
                // Element was not clickable e.StackTrace;
            }

        }
    }
}
