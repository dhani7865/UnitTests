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
    public class StartScriptFulfilmentExistingApplication
    {
        WebDriver webDriver;


        public void Init_StartScriptFulfilmentExistingApplicationTest()
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

    public class StartScriptFulfilmentExistingApplications
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

            string reportPath = projectPath + "TestReport\\HMPO - Start Script - Fulfilment Existing Application Test - Test Documentation - 27-04-2022.html";


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

        StartScriptFulfilmentExistingApplication script = new StartScriptFulfilmentExistingApplication();
        String test_url = "https://tpoxygen-hmpo-pal-qa/";
        IWebDriver driver;



        [SetUp]
        public void start_Browser()
        {
            script.Init_StartScriptFulfilmentExistingApplicationTest();
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
        public void test_StartScriptFulfilmentExistingApplication()
        {

            ExtentStart();
            var test = extent.CreateTest("HMPO - Start Script - Fulfilment Existing Application Test").Info("Test Started");

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
            // Clicking on the Start Script and PAL button
            IWebElement element = driver.FindElement(By.CssSelector("li:nth-child(1) img"));
            element.Click();

            element = driver.FindElement(By.CssSelector("li:nth-child(1) img"));
            element.Click();

            // Perform wait to check the output
            System.Threading.Thread.Sleep(3000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the Role Admin button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Selecting the check box in the Call Reason Capture page
            driver.FindElement(By.Id("CallReasonCheckBoxes_12__isSelected")).Click();

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
            driver.FindElement(By.Id("Firstname")).Click();
            driver.FindElement(By.Id("Firstname")).SendKeys("Tester");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Firstname");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();

            // Test 7
            // Entering the lastname
            driver.FindElement(By.Id("Lastname")).SendKeys("Last");
            driver.FindElement(By.Id("SelectedCountry_ID")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Lastname");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Selecting the Country
            driver.FindElement(By.Id("SelectedCountry_ID")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Country");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Entering the Postcode
            driver.FindElement(By.Id("Postcode")).Click();
            driver.FindElement(By.Id("Postcode")).SendKeys("BS1 3LG");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Postcode");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Clicking the continue button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Clicking the Fulfilment button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(6) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Fulfilment button");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Clicking the Create New button
            driver.FindElement(By.LinkText("Create New")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Create New button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            //  Entering the telephone number
            driver.FindElement(By.Id("TelephoneNumberViewModel_TelephoneNumber")).Click();
            driver.FindElement(By.Id("TelephoneNumberViewModel_TelephoneNumber")).SendKeys("078888888");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the telephone number");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Entering the email adddress
            driver.FindElement(By.Id("EmailAddressViewModel_EmailAddress")).Click();
            driver.FindElement(By.Id("EmailAddressViewModel_EmailAddress")).SendKeys("dhanyaal.rashid@teleperformance.co.uk");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the email adddress");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Clicking the continue button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Clicking the continue button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Selecitng the address
            driver.FindElement(By.CssSelector("tr:nth-child(11) > td")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecitng the address");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Clicking the continue button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Selecting the amount for the Emergency travel ETRA form
            driver.FindElement(By.Name("FulfilmentItems[10].AmountRequested")).Clear();
            driver.FindElement(By.Name("FulfilmentItems[10].AmountRequested")).SendKeys("1");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the amount for the Emergency travel ETRA form");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Scrolling back into view and finding the element for the button to click on
            ScrollintoView(driver, By.Id("987ece69-9205-4a12-a420-486c9c6258f0"));

            // Test 20
            // Selecting the Nearest Office
            dropdown = driver.FindElement(By.Id("979cdf83-c352-40e5-a710-ff3720653db5"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Liverpool");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Nearest Office");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Selecting Existing Application for Please select if this is for a new or existing application?
            dropdown = driver.FindElement(By.Id("987ece69-9205-4a12-a420-486c9c6258f0"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Existing Application");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Existing Application for Please select if this is for a new or existing application?");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();


            // Test 22
            // Entering the Callers DOB
            driver.FindElement(By.Id("42b5dc60-cf27-482d-af80-365529803392")).Click();
            driver.FindElement(By.Id("42b5dc60-cf27-482d-af80-365529803392")).SendKeys("02/02/1990");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Callers DOB");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Selecting the email address
            // driver.FindElement(By.Id("329371e5-734f-4b55-bf07-0e6f24cc307f")).Click();

            // Test 23
            // Selecting the Applicant Type
            dropdown = driver.FindElement(By.Id("7e65c531-fa84-4786-bd09-cc69ff9f6629"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("First");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Applicant Type");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Entering the Location of Emergency
            driver.FindElement(By.Id("2ae0926c-4201-4573-aad2-984dbc42f7b0")).Click();
            driver.FindElement(By.Id("2ae0926c-4201-4573-aad2-984dbc42f7b0")).SendKeys("Floor");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Location of Emergency");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Selecting the Emergency Type
            dropdown = driver.FindElement(By.Id("2bedc098-a3cd-4505-916b-ae8b2da12772"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Compassionate");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Emergency Type");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Selecting the U&C Evidence Email Provided
            dropdown = driver.FindElement(By.Id("1839b92c-412a-42c7-9edd-289c66ef4164"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the U&C Evidence Email Provided");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Selecting the Attend Next Working Day
            dropdown = driver.FindElement(By.Id("25cd4aea-28c1-416e-a340-9fe59cc565be"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Attend Next Working Day");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Entering the Details of Emergency
            driver.FindElement(By.Id("320aa8ff-64c0-49bb-bbb9-398296a583dd")).Click();
            driver.FindElement(By.Id("320aa8ff-64c0-49bb-bbb9-398296a583dd")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Details of Emergency");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Clicking the continue button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();

            // Test 30
            // Entering the DateOfBirth
            driver.FindElement(By.Id("DateOfBirth")).Click();
            driver.FindElement(By.Id("DateOfBirth")).SendKeys("02/02/1990");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the DateOfBirth");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Clicking on the background
            driver.FindElement(By.CssSelector(".field-holder:nth-child(2) > label")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the background");
            test.Log(Status.Pass, "Test 31 Passed");
            extent.Flush();

            // Test 32
            // Entering the Reference Number
            driver.FindElement(By.Id("ApplicantNumber")).Click();
            driver.FindElement(By.Id("ApplicantNumber")).SendKeys("4");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the ApplicantNumber");
            test.Log(Status.Pass, "Test 32 Passed");
            extent.Flush();

            // Test 33
            // Selecting the Processing Office
            dropdown = driver.FindElement(By.Id("ProcessingOfficeId"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Liverpool");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Processing Office");
            test.Log(Status.Pass, "Test 33 Passed");
            extent.Flush();

            // Test 34
            // Clicking the continue button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 34 Passed");
            extent.Flush();

            // Test 35
            // Selecting Would you like to send the customer the link?
            dropdown = driver.FindElement(By.Id("SelectedSendEvidenceLink"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Would you like to send the customer the link?");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();

            // Test 36
            // Clicking the continue button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(2000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 36 Passed");
            extent.Flush();

            // Test 37
            // Clicking the Finish button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(13) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 37 Passed");
            extent.Flush();

            // Test 38
            // Selecting the SelectedDAPResult
            dropdown = driver.FindElement(By.Id("SelectedDAPResult"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedDAPResult");
            test.Log(Status.Pass, "Test 38 Passed");
            extent.Flush();

            // Test 39
            // Selecting the SelectedPreApplicationResult
            dropdown = driver.FindElement(By.Id("SelectedPreApplicationResult"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedPreApplicationResult");
            test.Log(Status.Pass, "Test 39 Passed");
            extent.Flush();

            // Test 40
            // Selecting the SelectedOutcome_ID
            dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("INTL Advice");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedOutcome_ID");
            test.Log(Status.Pass, "Test 40 Passed");
            extent.Flush();

            // Test 41
            // Selecting the SelectedChildOutcome_ID1
            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID1"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("ABI - Interview Process Query");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedChildOutcome_ID1");
            test.Log(Status.Pass, "Test 41 Passed");
            extent.Flush();

            // Test 42
            // Selecting the SelectedChildOutcome_ID2
            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID2"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Appointment duration");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the SelectedChildOutcome_ID2");
            test.Log(Status.Pass, "Test 42 Passed");
            extent.Flush();

            // Test 43
            // Entering the notes
            driver.FindElement(By.Id("Notes")).Click();
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the notes");
            test.Log(Status.Pass, "Test 43 Passed");
            extent.Flush();

            // Test 44
            // Clicking the finish button to finish the script
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button to finish the script");
            test.Log(Status.Pass, "Test 44 Passed");
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
