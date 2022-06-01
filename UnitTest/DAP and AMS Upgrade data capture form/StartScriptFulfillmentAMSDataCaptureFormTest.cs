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
    public class StartScriptFulfillmentAMSDataCaptureFormTest
    {
        WebDriver webDriver;


        public void Init_fulfilment()
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

    public class StartScriptFulfillmentAMSDataCaptureForm
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

            string reportPath = projectPath + "TestReport\\Start Script Button - Fulfillment - AMS Data Capture Form - Test Documentation - 11-04-2022.html";


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

        StartScriptFulfillmentAMSDataCaptureFormTest script = new StartScriptFulfillmentAMSDataCaptureFormTest();
        String test_url = "https://tpoxygen-hmpo-pal-qa/";
        IWebDriver driver;



        [SetUp]
        public void start_Browser()
        {
            script.Init_fulfilment();
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
        public void test_StartScriptDAPTransferDAPCustomerErrorTest()
        {

            ExtentStart();
            var test = extent.CreateTest("HMPO - Start Script - Fulfillment - AMS Data Capture Form Test").Info("Test Started");

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
            driver.FindElement(By.Id("CallReasonCheckBoxes_10__isSelected")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the check box in the Call Reason Capture page");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Clicking the continue button
            driver.FindElement(By.CssSelector("p:nth-child(1) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
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
            driver.FindElement(By.Id("Firstname")).SendKeys("Name");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Firstname");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Entering the Lastname
            driver.FindElement(By.Id("Lastname")).Clear();
            driver.FindElement(By.Id("Lastname")).SendKeys("First");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Lastname");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Entering the Postcode
            driver.FindElement(By.Id("Postcode")).Clear();
            driver.FindElement(By.Id("Postcode")).SendKeys("BS3 3LG");

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
            // Clicking the Fulfilment button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(6) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Fulfilment button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the Create New button
            driver.FindElement(By.LinkText("Create New")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create New button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            //  Entering the telephone number
            driver.FindElement(By.Id("TelephoneNumberViewModel_TelephoneNumber")).Click();
            driver.FindElement(By.Id("TelephoneNumberViewModel_TelephoneNumber")).SendKeys("07982871086");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the telephone number");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Entering the email adddress
            driver.FindElement(By.Id("EmailAddressViewModel_EmailAddress")).Click();
            driver.FindElement(By.Id("EmailAddressViewModel_EmailAddress")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the email adddress");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Clicking the continue button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Clicking the continue button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Selecitng the address
            driver.FindElement(By.CssSelector("tr:nth-child(11) > td")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecitng the address");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Clicking the continue button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Selecting the amount for the AMS Upgrade
            driver.FindElement(By.Name("FulfilmentItems[5].AmountRequested")).Clear();
            driver.FindElement(By.Name("FulfilmentItems[5].AmountRequested")).SendKeys("1");
            driver.FindElement(By.Name("FulfilmentItems[5].AmountRequested")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the amount for the AMS Upgrade");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Selecting the Application Type
            driver.FindElement(By.Id("f68f6808-8c18-45dd-8740-02c46d60d489")).Click();

            dropdown = driver.FindElement(By.Id("f68f6808-8c18-45dd-8740-02c46d60d489"));
            dropdown.FindElement(By.XPath("//option[. = 'Adult Changes']")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Application Type");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Selecting the Application Date
            driver.FindElement(By.Id("fb3987cb-6e5d-4274-bf25-e9a983ce0901")).Click();
            driver.FindElement(By.LinkText("6")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Application Date");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Selecting NO for Is there an application in AMS?
            dropdown = driver.FindElement(By.Id("0ff03200-7007-4dc1-9ac1-8821a3085f3f"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("NO");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes for Is passport needed within 2 weeks?");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Selecting YES for Is there an application in AMS?
            dropdown = driver.FindElement(By.Id("0ff03200-7007-4dc1-9ac1-8821a3085f3f"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting YES for Is passport needed within 2 weeks?");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Selecting YES for Is passport needed within 2 weeks?
            dropdown = driver.FindElement(By.Id("157e3c3b-8a47-4e3a-b544-1d3bb692143f"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting YES for Is passport needed within 2 weeks?");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Selecting Application date more than 10 weeks? - YES and Submitted Online
            dropdown = driver.FindElement(By.Id("f3474e59-1d62-459c-b5cf-ea0e9c16a756"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES and Submitted Online");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Application date more than 10 weeks? - YES and Submitted Online");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24 
            // Selecting Application date more than 10 weeks? - YES and Submitted Paper
            dropdown = driver.FindElement(By.Id("f3474e59-1d62-459c-b5cf-ea0e9c16a756"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES and Submitted Paper");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Application date more than 10 weeks? - YES and Submitted Paper");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Selecting Application date more than 10 weeks? - YES and Submitted Paper
            dropdown = driver.FindElement(By.Id("f3474e59-1d62-459c-b5cf-ea0e9c16a756"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("NO");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Application date more than 10 weeks? - YES and Submitted Paper");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Selecting YES for Happy to continue?
            dropdown = driver.FindElement(By.Id("311bb43e-e86b-4390-b729-e487a3b98d07"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting YES for Happy to continue?");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Entering the Customer's name
            driver.FindElement(By.Id("00fee1c0-a968-4f3f-9c38-34a2d1f4a41d")).Click();
            driver.FindElement(By.Id("00fee1c0-a968-4f3f-9c38-34a2d1f4a41d")).SendKeys("Name First");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Customer's name");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Entering the Customer Contact Number
            driver.FindElement(By.Id("0b15743f-342a-4751-a2c8-27bc8232798f")).Click();
            driver.FindElement(By.Id("0b15743f-342a-4751-a2c8-27bc8232798f")).SendKeys("07982871086");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Customer Contact Number");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Entering the Customer Email Address
            driver.FindElement(By.Id("33ce33fd-b6e5-458c-ab4e-00b639861c84")).Click();
            driver.FindElement(By.Id("33ce33fd-b6e5-458c-ab4e-00b639861c84")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Customer Email Address");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();

            // Test 30
            // Selecting the Regional Office
            dropdown = driver.FindElement(By.Id("c2078dc7-8418-4fca-ad5f-e948e0ec470f"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Belfast");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Regional Office");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Entering the Application Reference Number
            driver.FindElement(By.Id("0dd39804-b4f1-4ddd-96cf-3921307355ba")).Click();
            driver.FindElement(By.Id("0dd39804-b4f1-4ddd-96cf-3921307355ba")).SendKeys("4");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Application Reference Number");
            test.Log(Status.Pass, "Test 31 Passed");
            extent.Flush();

            // Test 32
            // Selecting the Date Of TRavel
            driver.FindElement(By.Id("14a9aedb-8b68-4a74-9990-d6c7102737bd")).Click();
            driver.FindElement(By.LinkText("21")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Application Reference Number");
            test.Log(Status.Pass, "Test 32 Passed");
            extent.Flush();

            // Test 33
            // Entering the Notes
            driver.FindElement(By.Id("aac9eba7-826f-41f2-923a-58c16ab3abd2")).Click();
            driver.FindElement(By.Id("aac9eba7-826f-41f2-923a-58c16ab3abd2")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Notes");
            test.Log(Status.Pass, "Test 33 Passed");
            extent.Flush();

            // Test 34
            // Clicking the continue button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 34 Passed");
            extent.Flush();

            // Scrolling back into view and finding the element for the button to click on
            ScrollintoView(driver, By.CssSelector(".script-stage:nth-child(12) > .icon"));

            // Test 35
            // Clicking the Contact History button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(12) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Contact History button");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();

            // Test 36
            // Clicking the Fulfilments button
            driver.FindElement(By.LinkText("Fulfilments")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Fulfilments button");
            test.Log(Status.Pass, "Test 36 Passed");
            extent.Flush();

            // Test 37
            // Selecting a fulfilment
            driver.FindElement(By.CssSelector(".six-column > tbody > .initial-data > td:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a fulfilment");
            test.Log(Status.Pass, "Test 37 Passed");
            extent.Flush();

            // Test 38
            // Clicking the Finish button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(13) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Finish button");
            test.Log(Status.Pass, "Test 38 Passed");
            extent.Flush();

            // Test 39
            // Selecting the DAP Result
            dropdown = driver.FindElement(By.Id("SelectedDAPResult"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the DAP Result");
            test.Log(Status.Pass, "Test 39 Passed");
            extent.Flush();

            // Test 40
            // Selecting the PreApplicationResult
            dropdown = driver.FindElement(By.Id("SelectedPreApplicationResult"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("NO");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the PreApplicationResult");
            test.Log(Status.Pass, "Test 40 Passed");
            extent.Flush();

            // Test 41
            // Selecting the Outcome ID
            dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("UK DCS");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Outcome ID");
            test.Log(Status.Pass, "Test 41 Passed");
            extent.Flush();

            // Test 42
            // Selecting the Child Outcome ID
            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID1"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Error Message");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Child Outcome ID");
            test.Log(Status.Pass, "Test 42 Passed");
            extent.Flush();

            // Test 43
            // Selecting the Child Outcome ID2
            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID2"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Error Message");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Child Outcome ID2");
            test.Log(Status.Pass, "Test 43 Passed");
            extent.Flush();

            // Test 44
            // Entering the notes
            driver.FindElement(By.Id("Notes")).Click();
            driver.FindElement(By.Id("Notes")).SendKeys("This is a test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the notes");
            test.Log(Status.Pass, "Test 44 Passed");
            extent.Flush();

            // Test 45
            // Clicking the Finish button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Finish button");
            test.Log(Status.Pass, "Test 45 Passed");
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
