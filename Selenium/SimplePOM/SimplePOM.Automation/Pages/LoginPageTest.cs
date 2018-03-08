using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplePOM.Helper;
using NUnit;
using NUnit.Framework;
using SimplePOM.Pages;

namespace SimplePOM.Automation.Pages
{
    [TestFixture]
    public class LoginPageTest : BaseTest
    {
        private LoginPage loginPage;
        public LoginPageTest() : base()
        {
        }

        [SetUp]
        public void StartTest()
        {
            base.Initiate();
            loginPage = new LoginPage();
        }

        [Test]
        public void ClickOnLoginButtonWithNoUserName()
        {
            var res = loginPage.ValidateWithNoUserName(base.GetAppKey("password"));
            Assert.That(res,Is.True, "ClickOnLoginButtonWithNoUserName Failed.");
        }

        [Test]
        public void ClickOnLoginButtonWithNoPassWord()
        {
            var res = loginPage.ValidateWithNoPassword(base.GetAppKey("username"));
            Assert.That(res, Is.True, "ValidateWithNoPassword Failed.");
        }

        [Test]
        public void ClickOnLoginWithNoUserNameAndPassword()
        {
            var res = loginPage.ValidateWithNoUserNameAndPassword();
            Assert.That(res, Is.True, "ClickOnLoginWithNoUserNameAndPassword Failed.");
        }

        [Test]
        public void ClickOnLoginButton()
        {
            var res = loginPage.validateLoginWithRightValues(base.GetAppKey("username"), base.GetAppKey("password"));
            StringAssert.Contains(base.GetAppKey("userloginname"), res, "ClickOnLoginWithNoUserNameAndPassword Failed.");
        }

        [TearDown]
        public void EndTest()
        {
            base.Close();
        }
    }
}
