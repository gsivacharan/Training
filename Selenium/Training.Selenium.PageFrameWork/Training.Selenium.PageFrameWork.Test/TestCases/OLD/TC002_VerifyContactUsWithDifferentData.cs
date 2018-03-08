using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using Training.Selenium.PageFrameWork.Helper;

namespace Training.Selenium.PageFrameWork.Test.TestCases
{
    [TestFixture()]
    public class TC002_VerifyContactUsWithDifferentData : TestBase
    {
        private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            Initiate();
        }
        [Test]
        public void CreateContactUsWithExcelData()
        {
        }

        [TearDown]
        public void EndTest()
        {
            base.Close();
        }
    }
}