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
    public class StartScriptFulfilmentExistingApplicationTest
    {
        WebDriver webDriver;


        public void Init_CallForwardRegularsEmailmatchesupdatedtemplateTest()
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

    public class CallForwardRegularsEmailmatchesupdatedtemplate
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

            string reportPath = projectPath + "TestReport\\RAF Call Forward - Regulars Email matches updated template Test - Test Documentation - 27-04-2022.html";


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

        StartScriptFulfilmentExistingApplicationTest script = new StartScriptFulfilmentExistingApplicationTest();
        String test_url = "https://tpoxygen-raf-recruitment-qa/";
        IWebDriver driver;



        [SetUp]
        public void start_Browser()
        {
            script.Init_CallForwardRegularsEmailmatchesupdatedtemplateTest();
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
        public void test_CallForwardReservesEmailmatchesupdatedtemplateTest()
        {

            ExtentStart();
            var test = extent.CreateTest("RAF - Call Forward - Regulars Email matches updated template Test").Info("Test Started");

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
            // Clicking on the Call Forward button
            IWebElement element = driver.FindElement(By.CssSelector("li:nth-child(8) span"));
            element.Click();

            // Perform wait to check the output
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Role Admin button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the Send Test Email button
            driver.FindElement(By.LinkText("Send Test Email")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Send Test Email button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the Role ID
            var dropdown = driver.FindElement(By.Id("SelectedRoleId"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Regulars ▸ aaaa - Air and Space Operations [Open]");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Role ID");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Entering the EmailAddress
            driver.FindElement(By.Id("EmailAddress")).Click();
            driver.FindElement(By.Id("EmailAddress")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Email Address");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            
            // Test 6
            // Selecting a contact and entering the contact name
            driver.FindElement(By.Id("ContactName")).SendKeys("teleperformance");

            System.Threading.Thread.Sleep(5000);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ui-menu-item")));

            var elements = driver.FindElements(By.ClassName("ui-menu-item"));
            elements.First().Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a contact and entering the contact name");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();


            // Test 7
            // Clicking the Send Test Email Button
            driver.FindElement(By.CssSelector("form > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Send Test Email Button");
            test.Log(Status.Pass, "Test 7 Passed");
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
