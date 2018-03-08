using System;
using System.Security.Cryptography.X509Certificates;
using NUnit;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Training.Selenium.InterviewQuestions;
using Training.Selenium.InterviewQuestions.Series1;


namespace Training.Selenium.InterviewQuestions.Test
{
    [TestFixture()]
    public class InterviewQuestionsTest
    {
        private InterviewQuestionsSeries _interviewQuestions;

        // 1. How to find an alter is preset in the web page?
        [Test]
        public void TestAlertPresentInThePage()
        {
            _interviewQuestions = new InterviewQuestionsSeries();
            Assert.IsFalse(_interviewQuestions.AlertPresentInThePage());
        }

        [TearDown]
        public void CloseTest()
        {
            _interviewQuestions.close();
        }
    }
}
