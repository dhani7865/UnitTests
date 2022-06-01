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
    public class RITSFeedbackTest
    {
        WebDriver webDriver;


        public void Init_RITSFeedbackTest()
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

    public class RITSFeedback
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

            string reportPath = projectPath + "TestReport\\RITS Feedback Button Test - Documentation - 09-05-2022.html";


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

        RITSFeedbackTest script = new RITSFeedbackTest();
        // String test_url = "https://tpoxygen-hmpo-pal-qa/";
        String test_url = "https://tpoxygen-rn-recruitment-qa/";        
        IWebDriver driver;



        [SetUp]
        public void start_Browser()
        {
            script.Init_RITSFeedbackTest();
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
        public void test_RITSFeedbackTest()
        {

            ExtentStart();
            var test = extent.CreateTest("Royal Navy - RITS Feedback Test").Info("Test Started");

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
            // Clicking on the RITS Feedback button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-child(5) img"))).Click();

            // driver.FindElement(By.CssSelector("li:nth-child(5) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the RITS Feedback button");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 3
            // Clicking a RITS Feedback
            driver.FindElement(By.CssSelector("tr:nth-child(2) > td:nth-child(3)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking a RITS Feedback");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting a Status ID
            var dropdown = driver.FindElement(By.Id("SelectedStatus_ID"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("RITS Completed - Allocated to AFCO");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Status ID");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting a Afco ID
            driver.FindElement(By.Id("AllocatedAfco_ID")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a Afco ID");
            test.Log(Status.Pass, "Test 5 Passed");
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
