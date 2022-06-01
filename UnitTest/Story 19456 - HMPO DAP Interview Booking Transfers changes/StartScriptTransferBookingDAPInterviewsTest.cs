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
    public class StartScriptTransferBookingDAPInterviewsTest
    {
        WebDriver webDriver;


        public void Init_BookingDAPInterviews()
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

    public class StartScriptTransferBookingDAPInterviews
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

            string reportPath = projectPath + "TestReport\\Start Script Button - Booking DAP Interviews - Test Documentation - 14-04-2022.html";


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

        StartScriptTransferBookingDAPInterviewsTest script = new StartScriptTransferBookingDAPInterviewsTest();
        String test_url = "https://tpoxygen-hmpo-pal-qa/";
        IWebDriver driver;



        [SetUp]
        public void start_Browser()
        {
            script.Init_BookingDAPInterviews();
        }

        [Test]
        public void test_StartScriptTransferBookingDAPInterviews()
        {

            ExtentStart();
            var test = extent.CreateTest("HMPO - Start Script - Booking DAP Interviews Test").Info("Test Started");

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
            // Clicking on the Start Script and Pal Button
            IWebElement element = driver.FindElement(By.CssSelector("li:nth-child(1) img"));
            element.Click();

            IWebElement pal = driver.FindElement(By.CssSelector("li:nth-child(1) img"));
            pal.Click();

            // Perform wait to check the output
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Start Script and Pal Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();


            // Test 3
            // Selecting the check box in the Call Reason Capture page
            driver.FindElement(By.Id("CallReasonCheckBoxes_11__isSelected")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the check box in the Call Reason Capture page");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the continue button
            driver.FindElement(By.CssSelector("p:nth-child(1) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting the Title ID from the dropdown
            var dropdown = driver.FindElement(By.Id("SelectedTitle_ID"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Mr");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Title ID from the dropdown");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Entering the Firstname
            driver.FindElement(By.Id("Firstname")).Clear();
            driver.FindElement(By.Id("Firstname")).SendKeys("tester");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Firstname");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Entering the Lastname
            driver.FindElement(By.Id("Lastname")).Clear();
            driver.FindElement(By.Id("Lastname")).SendKeys("rashid");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Lastname");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Entering the Postcode
            driver.FindElement(By.Id("Postcode")).Clear();
            driver.FindElement(By.Id("Postcode")).SendKeys("BS1 3LG");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Postcode");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Clicking the continue button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the Transfer button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(9) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Transfer button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the Create New button
            driver.FindElement(By.LinkText("Create New")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create New button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the continue button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Clicking the ICH button
            driver.FindElement(By.CssSelector("#ichTransferLink > img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the ICH button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Selecting the reason ID for the DAP Transfer
            dropdown = driver.FindElement(By.Id("Reason_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Booking DAP Interviews");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the reason ID for the DAP Transfer");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Clicking the Initiate Transfer button
            driver.FindElement(By.Id("InitiateTransfer")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Initiate Transfer button");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Clicking the cancel button
            driver.FindElement(By.Id("Cancel")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the cancel button");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Entering the telephone number
            driver.FindElement(By.Id("TelephoneNumberViewModel_TelephoneNumber")).Click();
            driver.FindElement(By.Id("TelephoneNumberViewModel_TelephoneNumber")).SendKeys("07982871086");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the telephone number");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Clicking the submit button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Clicking the confirm telephone number button
            driver.FindElement(By.CssSelector("input:nth-child(11)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the confirm telephone number button");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Selecting the dupplicate contact
            driver.FindElement(By.Id("SelectedTaskId")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the dupplicate contact");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Clicking the confirm callers response button
            driver.FindElement(By.Id("BtnProcessSelection")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the confirm callers response button");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Entering the notes
            driver.FindElement(By.Id("Notes")).Click();
            driver.FindElement(By.Id("Notes")).SendKeys("This is a test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the notes");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Selecting a task classification
            driver.FindElement(By.Id("TaskClassificationId")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a task classification");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking the Update Task button
            driver.FindElement(By.Id("SubmitCreateUpdateTask")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Update Task button");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            /* 
            // Test 17
            // Entering the Application Number
            driver.FindElement(By.Id("ffb9474c-12e3-4e79-aeb1-4afbf9c01df9")).Clear();
            driver.FindElement(By.Id("ffb9474c-12e3-4e79-aeb1-4afbf9c01df9")).SendKeys("13");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Application Number");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Entering the Callers Telephone number
            driver.FindElement(By.Id("2f04e272-9c8e-474e-b8ed-ec815dcebf2c")).Clear();
            driver.FindElement(By.Id("2f04e272-9c8e-474e-b8ed-ec815dcebf2c")).SendKeys("07982871086");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Callers Telephone number");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Entering the Email Address
            driver.FindElement(By.Id("329371e5-734f-4b55-bf07-0e6f24cc307f")).Clear();
            driver.FindElement(By.Id("329371e5-734f-4b55-bf07-0e6f24cc307f")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Email Address");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Selecting the Date of Travel
            driver.FindElement(By.Id("1324fa06-2625-4aa4-8fd1-e08c0df32cd2")).Click();
            // driver.FindElement(By.CssSelector(".ui-icon-circle-triangle-e")).Click();
            driver.FindElement(By.LinkText("27")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Date of Travel");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Entering the Notes
            driver.FindElement(By.Id("73a8760a-cf4e-4142-9411-5f2b2e0c9322")).Click();
            driver.FindElement(By.Id("73a8760a-cf4e-4142-9411-5f2b2e0c9322")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Notes");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Clicking the Send Email Button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Send Email Button");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();
            */

            // Test 25
            // Selecting the SelectedDAPResult
            dropdown = driver.FindElement(By.Id("SelectedDAPResult"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedDAPResult");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Selecting the SelectedPreApplicationResult
            dropdown = driver.FindElement(By.Id("SelectedPreApplicationResult"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedPreApplicationResult");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Selecting the SelectedOutcome_ID
            dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("UK Advice");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedPreApplicationResult");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Selecting the SelectedChildOutcome_ID1
            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID1"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Nationality");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedChildOutcome_ID1");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Selecting the SelectedChildOutcome_ID2
            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID2"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Nationality - General");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedChildOutcome_ID2");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();

            // Test 30
            // Entering the notes
            driver.FindElement(By.Id("Notes")).Click();
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the notes");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Clicking the Finish button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Finish button");
            test.Log(Status.Pass, "Test 31 Passed");
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
