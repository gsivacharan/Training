using System;
using System.Collections.Generic;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace Training.Selenium.InterviewQuestions.Series1
{
    public class InterviewQuestionsSeries
    {
        private IWebDriver driver;
        // 1. How to find an alter is preset in the web page?
        public bool AlertPresentInThePage()
        {
            driver = new ChromeDriver { Url = "https://uk.yahoo.com/?p=us" };
            try
            {
                var alert = driver.SwitchTo().Alert();

                // ***** This will retrive alert messages *********
                var alertMessage = alert.Text;

                // ***** This will give set the user athentications for popup windows *********
                alert.SetAuthenticationCredentials("system", "system");


                // ******** to accept the alert *********
                alert.Accept();

                // ******** to dismis the alert *********
                alert.Dismiss();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void SwithchToFrame()
        {
            // ****** Swithching to IFrame by Index  
            driver.SwitchTo().Frame(0);
            // ****** Swithching to IFrame by Name
            driver.SwitchTo().Frame("SomeFrameName");

            // ****** Finding elements in that particular frame
            driver.SwitchTo().Frame(0).FindElement(By.XPath("SomePath"));
        }

        public void SwitchToWindow()
        {
            // **** To get active window handler
            var ActiveWindow = driver.CurrentWindowHandle;

            // **** To move to different window

            var otherwindowHandle = driver.SwitchTo().Window("Testing");

            // **** To move back to current working window
            driver.SwitchTo().DefaultContent();

            // To get windows cooridinators
            var position = driver.Manage().Window.Position;
            var x = position.X;
            var y = position.Y;
        }

        public void Navigation()
        {
            driver.Navigate().Forward();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();

            // To get current title and url
            var url = driver.Url;
            var title = driver.Title;
        }

        public void ListSelectBox()
        {
            IWebElement select = driver.FindElement(By.Id("users"));
            IList<IWebElement> options = select.FindElements(By.TagName("Options"));
            foreach (var option in options)
            {
                Console.Write(option.Text);
            }
        }

        public void SelectBox()
        {
            
        }

        public void SubmitPage()
        {
            driver.FindElement(By.Id("Submit")).Click();

            //or
            // Selenium will walk throug DOM find the Sumbit button and clicks by choosing 
            // Submit() on any other inputs in the page.

            driver.FindElement(By.Id("AnyOtherElement")).Submit();
            
            
        }
        
        public void FileUploadTest()
        {
            /*
             * Selenium does not support fileupload windows
             * To test fileupload we need to use AutoIT thardparty tool
             * This tool will generate a exe which will help to upload file.
             * First we need to configure this tool to upload file using provided AutoIT tool console
             * It will create an EXE and run this exe using selenuim
             * 
             * https://www.youtube.com/watch?v=51iuVOHGUHs
             * 
             * 
             */

            IWebDriver driver1 = new FirefoxDriver();
            driver1.Url =
                @"file:///D:/_TRAINING/Selenium/Training.Selenium.InterviewQuestions/Training.Selenium.InterviewQuestions/AutoIT/FileUpload.htm";
            driver1.FindElement(By.Name("fileupload")).Click();

            Process p = new Process();
            p.StartInfo.FileName = @"D:\_TRAINING\Selenium\Training.Selenium.InterviewQuestions\Training.Selenium.InterviewQuestions\AutoIT\FileUpload.exe";
            p.Start();

        }

        public void WaitConditions()
        {
            // Implicit Wait (Page Leavel Wait)

            // This is page leavel waithing time to load all the elements. When page not loaded 
            // this will throw exception of timeout
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Explicit Wait (Element Level Wait)
            // Generally used for dynamic variables popup
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(x => x.FindElement(By.XPath("asdf")));
            // OR
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("ASDF")));
        }

        public void ActionClass()
        {
            // Mouse over
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("Asdf")), 100, 200).Build().Perform();


            // Drag Drop
            actions.DragAndDrop(driver.FindElement(By.XPath("")), driver.FindElement(By.XPath(""))).Build().Perform();

            // Dropdown select box
            SelectElement sel = new SelectElement(driver.FindElement(By.XPath("")));
            sel.DeselectByValue("sadf");

            // To list 
            IList<IWebElement> selectedOptions = sel.AllSelectedOptions;
            foreach (var element in selectedOptions)
            {
                var a = element.Text;
            }


        }

        public void TakeScreenShots()
        {
            driver.TakeScreenshot().SaveAsFile("c:\\Test.bmp", ScreenshotImageFormat.Bmp);
        }

        public void PageElements()
        {
            var elementsCount = driver.FindElement(By.XPath("")).Size;
        }

        public void Siblings()
        {
            driver.FindElement(By.XPath("//*[@type='Submit/']//following-siblings::input"));
        }

        public void close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
