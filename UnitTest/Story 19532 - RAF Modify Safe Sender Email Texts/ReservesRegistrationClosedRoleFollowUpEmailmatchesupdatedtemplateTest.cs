using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace UnitTest
{
    public class ReservesRegistrationClosedRoleFollowUpEmailmatchesupdatedtemplateTest
    {
        WebDriver webDriver;


        public void Init_ReservesRegistrationClosedRoleFollowUpEmailmatchesupdatedtemplateTest()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        public string Title
        {
            get { return webDriver.Title; }
        }

        public void Goto(string url)
        {
            webDriver.Url = url;
        }

        public void Close()
        {
            webDriver.Quit();
        }

        public IWebDriver getDriver
        {
            get { return webDriver; }
        }
    }

    public class ReservesRegistrationClosedRoleFollowUpEmailmatchesupdatedtemplate
    {
        private static ExtentReports extent;
        private static object perform;

        // Start method for extent reports
        [OneTimeSetUp]
        public static void ExtentStart()
        {
            extent = new ExtentReports();

            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "TestReport\\RAF Role Admin - Reserves Registration Closed Role Follow Up Email matches updated template Test - Test Documentation - 27-04-2022.html";


            var htmlReporter = new ExtentV3HtmlReporter(reportPath);

            extent.AttachReporter(htmlReporter);

        }



        public void ExtentClose()
        {
            extent.Flush();
        }


        class OneTimeSetUpAttribute : Attribute
        {
        }

        ReservesRegistrationClosedRoleFollowUpEmailmatchesupdatedtemplateTest script = new ReservesRegistrationClosedRoleFollowUpEmailmatchesupdatedtemplateTest();
        String test_url = "https://tpoxygen-raf-recruitment-qa/";
        IWebDriver driver;



        [SetUp]
        public void start_Browser()
        {
            script.Init_ReservesRegistrationClosedRoleFollowUpEmailmatchesupdatedtemplateTest();
        }

        // Scroll into view method
        private static void ScrollintoView(IWebDriver driver, By bySelector)
        {
            var element = driver.FindElement(bySelector);
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        [Test]
        public void test_ReservesRegistrationSpecialistClosedRoleEmailmatchesupdatedtemplateTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Role Admin - Reserves Registration Closed Role Follow Up Email matches updated template Test").Info("Test Started");

            //IWebDriver driver = new ChromeDriver();

            driver = script.getDriver;

            // Test 1
            // Going to the url
            script.Goto(test_url);

            // Perform wait to check the output
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "HMPO Pal QA Oxygon Launched");
            test.Log(Status.Pass, "Test 1 Passed");
            extent.Flush();

            // Test 2
            // Clicking on the Role Admin button
            IWebElement element = driver.FindElement(By.CssSelector("li:nth-child(5) img"));
            element.Click();

            // Perform wait to check the output
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Role Admin button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the search button
            driver.FindElement(By.Id("lnkSearch")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Entering the Value
            driver.FindElement(By.Id("value")).Clear();
            driver.FindElement(By.Id("value")).SendKeys("logistics (Driver)");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Value");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the Search button
            driver.FindElement(By.CssSelector("div:nth-child(11) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Search button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting a role
            driver.FindElement(By.CssSelector("tr:nth-child(8) a:nth-child(2)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a role");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // De-Selecting and selecting IsClosedRoleFollowup
            driver.FindElement(By.Id("IsClosedRoleFollowup")).Click();
            driver.FindElement(By.Id("IsClosedRoleFollowup")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "De-Selecting and selecting IsClosedRoleFollowup");
            test.Log(Status.Pass, "Test 6 Passed");

            // Test 7
            // De-Selecting and selecting IsSpecialist
            driver.FindElement(By.Id("IsSpecialist")).Click();
            driver.FindElement(By.Id("IsSpecialist")).Click();
            driver.FindElement(By.Id("IsSpecialist")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "De-Selecting and selecting IsSpecialist");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            driver.FindElement(By.CssSelector(".field-holder:nth-child(1) > .forCheckbox")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the save button
            driver.FindElement(By.CssSelector("input:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the save button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();


            // Scrolling back into view and finding the element for the button to select
            ScrollintoView(driver, By.LinkText("Back to Listing"));

            // Test 10
            // Clicking the Back to Listing button
            driver.FindElement(By.LinkText("Back to Listing")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back to Listing button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the Home button
            driver.FindElement(By.LinkText("Home")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Home button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();


            // quit driver after all tests completed
            // driver.Quit();

        }

        [TearDown]
        public void close_Browser()
        {
            script.Close();
        }
    }
}
