using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using Training.Selenium.PageFrameWork.Helper;
using Training.Selenium.PageFrameWork.Pages;

namespace Training.Selenium.PageFrameWork.Test.TestCases
{
    [TestFixture()]
    class TC003_ProductInfo : TestBase
    {
        [SetUp]
        public void StartTest()
        {
            Initiate();
        }

        [Test]
        public void ViewProducts()
        {
            ProductInfo productinfo = new ProductInfo(Driver);
            productinfo.ClickOnNavigationMenu("Mens");
            productinfo.ClickOnProductsInMensSection("Pants");
        }

        [TearDown]
        public void EndTest()
        {
            Close();
        }
    }
}
