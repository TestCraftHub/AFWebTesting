using AventStack.ExtentReports.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAWebTests.Base;
using QAWebTests.Framework.Reports;
using QAWebTests.Framework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebTests.Tests
{
    [TestFixture]
    public class LoginTest : TestBase
    {
        IWebDriver driver;
        public IWebElement test => driver.FindElement(By.Id("id"));

        [Test]
        public void Login()
        {
           // ExtentReportManager.CreateTest(TestContext.CurrentContext.Test.Name);
            ExtentReportManager.LogInformation("LOging test started");
            
            Console.WriteLine("sandeep");
            Console.WriteLine("sandeep");

            IWebDriver driver = new ChromeDriver();
            string tst = ScreenshotHelper.SavePageScreenshot(driver,"Sbdeep").ToString();
           // string tst1 = ScreenshotHelper.GetElementScreenshot(test, "Sbdeep1").ToString();
            driver.Quit();

        }

    }
}
