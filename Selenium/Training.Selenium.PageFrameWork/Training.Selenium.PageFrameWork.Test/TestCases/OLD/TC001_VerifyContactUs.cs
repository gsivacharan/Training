using NUnit.Framework;
using Training.Selenium.PageFrameWork.Helper;
using Training.Selenium.PageFrameWork.Pages;

namespace Training.Selenium.PageFrameWork.Test.TestCases
{
    [TestFixture]
    class TC001_VerifyContactUs : TestBase
    {
        [SetUp]
        public void StartTest()
        {
            Initiate(); 
        }

        //[Test]
        //public void TestContactUs()
        //{
        //    User user = new User
        //    {
        //        UserName = "siva",
        //        UserEmail = "sivacharan@gmail.com",
        //        UserPhoneNumber = "0898989898",
        //        UserMessage = "testing"
        //    };
        //    ContactUs contactUs = new ContactUs(Driver);
        //    TakeScreenshot();
        //    contactUs.ValidateContactUs(user);
        //    TakeScreenshot();
        //    Assert.IsTrue(contactUs.VerifyContactSuccess());
            
        //}

        [TearDown]
        public void EndTest()
        {
            Close();
        }
        
    }
}
