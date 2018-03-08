using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Selenium.PageFrameWork.Helper;
using NUnit.Framework;
using Training.Selenium.PageFrameWork.Pages;

namespace Training.Selenium.PageFrameWork.Test.TestCases
{
    [TestFixture]
    class HomePageTest:TestBase
    {
        private LoginPage loginPage;
        private HomePage homepage;

        public HomePageTest() : base()
        {}

        [SetUp]
        public void InitiliseTest()
        {
            base.Initiate();
            loginPage = new LoginPage();
            loginPage.Login(GetKeyValue("username"),GetKeyValue("password"));
        }

        [Test]
        public void ValidateTitle()
        {
            homepage = new HomePage();
            var homePageTitle = homepage.VerfyHompageTitle();
            Assert.AreEqual(homePageTitle, "Some Text","Homepage Title Not Matched.");
        }

        [TearDown]
        public void EndTest()
        {
            Close();
        }
    }
}
