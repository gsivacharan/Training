using System;
using System.Data;
using System.Threading;
using NUnit.Framework;
using Training.Selenium.PageFrameWork.Helper;
using Training.Selenium.PageFrameWork.Pages;
using Training.Selenium.PageFrameWork.Utils;

namespace Training.Selenium.PageFrameWork.Test.TestCases
{
    [TestFixture]
    public class CompanyPageTest : TestBase
    {
        private CompanyPage companyPage;
        private Util util;
        public CompanyPageTest() : base()
        {}

        
        [SetUp]
        public void InitiateTest()
        {
            Log.Info("InitiateTest begins");
            base.Initiate();
            LoginPage loginPage = new LoginPage();
            Log.Info("loginPage object created.");
            util = new Util();
            HomePage homepage = loginPage.Login("sivacharan", "friend");
            Log.InfoFormat("Username = '{0}' and Password = '{1}' as passed.", "sivacharan","friend");
            base.SwitchToMainFrame();
            Log.Info("Switch to IFrame");
            companyPage = homepage.ClickCompanyLink();
            Log.Info("Clicked on Company Menu Link.");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Log.Info("Test Wait for 10 seconds.");
            homepage.ClickOnNewCompanyLink();
            Log.Info("New Company link clicked.");
        }

        [Test]
        public void AddNewCompany()
        {
            Company company = new Company
            {
                Name = "Google",
                Industry = "Search",
                AnualRevenue = "1000000",
                Employees = "80980",
                Status = Status.Active,
                Cateogyr = CompanyCategory.Client,
                Priority = Priority.High,
                Source = Source.Customer,
                Identifier = "unknown",
                VatNumber = "9090909",
                Phone = "909090909",
                Fax = "121-12-21-2",
                WebSite = "www.google.com",
                Email = "google@google.com",
                Symbol = "google",
                ParentCompany = "Unknown",
                Owner = "411470",
                Address = new Address
                {
                    Title = "Google Main Office",
                    Type = AddressTypes.BillingAddress,
                    DefaultAddress = "Someware in USA",
                    City = "silicon valley",
                    State = "California",
                    PostalCode = "LUZ07",
                    Country = "LA",
                    Tags = "#google,#something",
                    Notes = "this is my first testing."
                }
            };

            Log.Info("New Company object Created.");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Log.Info("Waited for 10 senconds.");
            var res = companyPage.clickSaveButton(company);
            Log.Info("New Company Added.");
            Assert.IsTrue(res);
        }

        [Test]
        public void AddNewCompaniesWithDataFromCsv()
        {
           var ExcelData = ExcelReaderHelper.ReadExcelFile(GetKeyValue("CompanyData"),"CompnayData");
            foreach (DataTable table in ExcelData.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    var ParentId = dr["ParentId"].ToString();
                }
            }

        }

        [TearDown]
        public void CloseTest()
        {
            Close();
        }
    }
}
