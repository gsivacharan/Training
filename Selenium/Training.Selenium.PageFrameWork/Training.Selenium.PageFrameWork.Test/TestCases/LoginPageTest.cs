using AventStack.ExtentReports;
using log4net;
using NUnit.Framework;
using Training.Selenium.PageFrameWork.Helper;
using Training.Selenium.PageFrameWork.Pages;

namespace Training.Selenium.PageFrameWork.Test.TestCases
{
    [TestFixture]
    public class LoginPageTest : TestBase
    {
        private LoginPage _loginPage;
        private HomePage _homePage;
        
        public LoginPageTest() : base() { }
        
        [SetUp]
        public void InitTest()
        {
            Initiate();
            _loginPage = new LoginPage();
        }

        [Test]
        public void ValidateLoginTtitle()
        {
            var loginTitle = _loginPage.ValidateLoginPageTitle();
            Assert.AreEqual(loginTitle, "#1 Free CRM for Any Business: Online Customer Relationship Software");
        }

        [Test]
        public void ValidateLogoImageExisits()
        {
            var imageExists = _loginPage.ValidateCrmImage();
            Assert.AreEqual(imageExists,true);
        }

        [Test]
        public void LoginTest()
        {
            Log.Info("LoginTest Begins");

            TestInfo.Log(Status.Info, "Login Test begins");

            _homePage = _loginPage.Login(GetKeyValue("username"),GetKeyValue("password"));
            Log.InfoFormat("user name  = {0} and  password = {1} are entered", GetKeyValue("username"), GetKeyValue("password"));
            var homePageTitle = _homePage.VerfyHompageTitle();
            Log.Info("homePage.VerfyHompageTitle() is called.");
           // Assert.AreEqual(homePageTitle,"some Text", "HomePage Title not right.");
        }
    
        [TearDown]
        public void EndTest()
        {
            Close();
        }

    }
}
