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
    public class ReserveSessionTest
    {
        WebDriver webDriver;


        public void Init_ApplicationSearchTest()
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

    public class ApplicationSearch
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

            string reportPath = projectPath + "TestReport\\Search Application Button Test - Documentation - 09-05-2022.html";


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

        ReserveSessionTest script = new ReserveSessionTest();
        // String test_url = "https://tpoxygen-hmpo-pal-qa/";
        String test_url = "https://tpoxygen-rn-recruitment-qa/";        
        IWebDriver driver;



        [SetUp]
        public void start_Browser()
        {
            script.Init_ApplicationSearchTest();
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
        public void test_ApplicationSearchTest()
        {

            ExtentStart();
            var test = extent.CreateTest("Royal Navy - Search Applications Test").Info("Test Started");

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
            // Test 2
            // Clicking on the Search Application Button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(6) img"))).Click();

            // driver.FindElement(By.CssSelector("li:nth-child(6) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Search Application Button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 3
            // Selecting the Application Enquiry Status Id
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ApplicationEnquiryStatusId")));

            var dropdown = driver.FindElement(By.Id("ApplicationEnquiryStatusId"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("RitsCompletedAllocatedtoAFCO");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Application Enquiry Status Id");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the Role ID
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("RoleId"))).Click();

            // driver.FindElement(By.Id("RoleId")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Role ID");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting the Role Search Type Id
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("RoleSearchTypeId")));

            dropdown = driver.FindElement(By.Id("RoleSearchTypeId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("RITS Role");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Role Search Type Id");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the filter button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter button");
            test.Log(Status.Pass, "Test 6 Passed");
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
