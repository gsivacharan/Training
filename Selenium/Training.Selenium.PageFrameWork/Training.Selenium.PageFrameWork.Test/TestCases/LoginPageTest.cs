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
        public void ClickOnLoginButtonWithNoUserName()
        {
            var res = _loginPage.ValidateWithNoUserName(base.GetKeyValue("password"));
            Assert.That(res, Is.True, "ClickOnLoginButtonWithNoUserName Failed.");
        }

        [Test]
        public void ClickOnLoginButtonWithNoPassWord()
        {
            var res = _loginPage.ValidateWithNoPassword(base.GetKeyValue("username"));
            Assert.That(res, Is.True, "ValidateWithNoPassword Failed.");
        }

        [Test]
        public void ClickOnLoginWithNoUserNameAndPassword()
        {
            var res = _loginPage.ValidateWithNoUserNameAndPassword();
            Assert.That(res, Is.True, "ClickOnLoginWithNoUserNameAndPassword Failed.");
        }

        [Test]
        public void ClickOnLoginButton()
        {
            var res = _loginPage.validateLoginWithRightValues(base.GetKeyValue("username"), base.GetKeyValue("password"));
            StringAssert.Contains(base.GetKeyValue("userloginname"), res, "ClickOnLoginWithNoUserNameAndPassword Failed.");
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
