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
    public class DataExportTest
    {
        WebDriver webDriver;


        public void Init_DataExportTest()
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

    public class DataExport
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

            string reportPath = projectPath + "TestReport\\Data Export Button Test - Documentation - 09-05-2022.html";


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

        DataExportTest script = new DataExportTest();
        // String test_url = "https://tpoxygen-hmpo-pal-qa/";
        String test_url = "https://tpoxygen-rn-recruitment-qa/";        
        IWebDriver driver;



        [SetUp]
        public void start_Browser()
        {
            script.Init_DataExportTest();
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
        public void test_DataExportTest()
        {

            ExtentStart();
            var test = extent.CreateTest("Royal Navy - Data Export Button Test").Info("Test Started");

            //IWebDriver driver = new ChromeDriver();

            driver = script.getDriver;

            // Test 1
            // Going to the url
            script.Goto(test_url);

            // Perform wait to check the output
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Royal Navy Launched");
            test.Log(Status.Pass, "Test 1 Passed");
            extent.Flush();

            // Test 2
            // Clicking on the Data Export button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(11) img"))).Click();

            // driver.FindElement(By.CssSelector("li:nth-child(11) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Data Export button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Clicking the One-off Data Export Button
            driver.FindElement(By.LinkText("One-off Data Export")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the One-off Data Export Button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the start date
            driver.FindElement(By.CssSelector(".ui-datepicker-month")).Click();
            driver.FindElement(By.LinkText("2")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the start date");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting the end date
            driver.FindElement(By.Id("EndDate")).Click();
            driver.FindElement(By.LinkText("7")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the end date");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Selecitng the Application Enquiry Statuses
            var dropdown = driver.FindElement(By.Id("SelectedApplicationEnquiryStatuses"));
            dropdown.FindElement(By.XPath("//option[. = 'RitsLinkSent']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecitng the Application Enquiry Statuses");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Selecting the Roles
            dropdown = driver.FindElement(By.Id("SelectedRoles"));
            dropdown.FindElement(By.XPath("//option[. = 'Air Engineer Officer']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Roles");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Clicking the Generate button
            driver.FindElement(By.Name("command")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Generate button");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Selecting the Toast message
            driver.FindElement(By.CssSelector("h1")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Toast message");
            test.Log(Status.Pass, "Test 9 Passed");
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
