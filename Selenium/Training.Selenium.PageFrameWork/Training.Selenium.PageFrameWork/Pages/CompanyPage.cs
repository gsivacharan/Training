using System;
using System.Runtime.InteropServices;
using com.sun.org.apache.xpath.@internal.operations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Training.Selenium.PageFrameWork.Helper;
using Training.Selenium.PageFrameWork.Utils;

namespace Training.Selenium.PageFrameWork.Pages
{
    public class CompanyPage:TestBase
    {
        // Page Factory

        [FindsBy(How = How.XPath, Using = "//input[@id=\"company_name\"]")]
        private IWebElement CompanyName;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"industry\"]")]
        private IWebElement Industry;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"annual_revenue\"]")]
        private IWebElement AnnualRevenue;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"num_of_employees\"]")]
        private IWebElement Employess;

        [FindsBy(How = How.XPath, Using = "//select[@name=\"status\"]")]
        private IWebElement Status;

        [FindsBy(How = How.XPath, Using = "//select[@name=\"category\"]")]
        private IWebElement Category;

        [FindsBy(How = How.XPath, Using = "//select[@name=\"priority\"]")]
        private IWebElement Priority;

        [FindsBy(How = How.XPath, Using = "//select[@name=\"source\"]")]
        private IWebElement Source;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"identifier\"]")]
        private IWebElement Identifier;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"vat_number\"]")]
        private IWebElement VatNumber;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"phone\"]")]
        private IWebElement Phone;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"fax\"]")]
        private IWebElement Fax;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"website\"]")]
        private IWebElement WebSite;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"email\"]")]
        private IWebElement Email;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"symbol\"]")]
        private IWebElement Symbol;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"client_lookup\"]")]
        private IWebElement ParentCompany;

        [FindsBy(How = How.XPath, Using = "//select[@name=\"owner_user_id\"]")]
        private IWebElement Owner;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"address_title\"]")]
        private IWebElement AddressTitle;

        [FindsBy(How = How.XPath, Using = "//select[@name=\"type\"]")]
        private IWebElement Type;

        [FindsBy(How = How.XPath, Using = "//textarea[@name=\"address\"]")]
        private IWebElement Address;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"city\"]")]
        private IWebElement City;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"state\"]")]
        private IWebElement State;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"country\"]")]
        private IWebElement Country;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"postcode\"]")]
        private IWebElement Postcode;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"tags\"]")]
        private IWebElement Tags;

        [FindsBy(How = How.XPath, Using = "//textarea[@name=\"service\"]")]
        private IWebElement Discription;

        [FindsBy(How = How.XPath, Using = "//input[@type=\"submit\" and @value=\"Save\"]")]
        private IWebElement SaveButton;

        [FindsBy(How = How.XPath, Using = "//a[@title=\"New Company\"]")]
        private IWebElement NewCompanyLink;


        //Actions

        
        public CompanyPage()
        {
          PageFactory.InitElements(Driver,this);
        }
        
        public void SetCompany(string companyName)
        {
            CompanyName.Clear();
            CompanyName.SendKeys(companyName);
        }

        public Boolean clickSaveButton(Company company)
        {
            CompanyName.Clear();
            CompanyName.SendKeys(company.Name);

            Industry.Clear();
            Industry.SendKeys(company.Industry);

            AnnualRevenue.Clear();
            AnnualRevenue.SendKeys(company.AnualRevenue);

            Employess.Clear();
            Employess.SendKeys(company.Employees);

            SelectElement status = new SelectElement(Status);
            status.SelectByIndex((int)Utils.Status.Hot);

            SelectElement category = new SelectElement(Category);
            category.SelectByIndex((int)Utils.CompanyCategory.Client);

            SelectElement priority = new SelectElement(Priority);
            priority.SelectByIndex((int)Utils.Priority.High);

            SelectElement source = new SelectElement(Source);
            source.SelectByIndex((int)Utils.Source.Ad);

            Identifier.Clear();
            Identifier.SendKeys(company.Identifier);

            VatNumber.Clear();
            VatNumber.SendKeys(company.VatNumber);

            Phone.Clear();
            Phone.SendKeys(company.Phone);

            Fax.Clear();
            Fax.SendKeys(company.Fax);

            WebSite.Clear();
            WebSite.SendKeys(company.WebSite);

            Email.Clear();
            Email.SendKeys(company.Email);

            Symbol.Clear();
            Symbol.SendKeys(company.Symbol);

            ParentCompany.Clear();
            ParentCompany.SendKeys(company.ParentCompany);

            SelectElement owner = new SelectElement(Owner);
            owner.SelectByValue(company.Owner);

            AddressTitle.Clear();
            Address.SendKeys(company.Address.Title);

            //SelectElement type = new SelectElement(Type);
            //type.SelectByIndex((int)AddressTypes.BillingAddress);

            Address.Clear();
            Address.SendKeys(company.Address.DefaultAddress);

            City.Clear();
            City.SendKeys(company.Address.City);

            State.Clear();
            State.SendKeys(company.Address.State);

            Postcode.Clear();
            Postcode.SendKeys(company.Address.PostalCode);

            Country.Clear();
            Country.SendKeys(company.Address.Country);

            Tags.Clear();
            Tags.SendKeys(company.Address.Tags);

            Discription.Clear();
            Discription.SendKeys(company.Address.Notes);

            SaveButton.Click();
            Log.Info("Save Button Clicked.");

            return true;
        }
        
    }
}
