using AventStack.ExtentReports.Model;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using QAWebTests.Framework.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebTests.Base
{
    public class TestBase
    {
        public TestBase()
        {


            // string className = TestContext.CurrentContext.Test.ClassName.Substring(17);

            // ExtentReportManager.LogInformation($"{className} started1");

        }

        [OneTimeSetUp]
        public void TestStarted()
        {
            string fullClassName = TestContext.CurrentContext.Test.ClassName;

            //using reflection to find class name
            string className = Type.GetType(fullClassName)?.Name ?? fullClassName.Split('.').Last();

            //string className = fullClassName.Split('.').Last();

            ExtentReportManager.CreateClass(className);
        }

        [SetUp]
        public void Setup()
        {
            //Add Test under class in extent report
            ExtentReportManager.CreateTest($"{TestContext.CurrentContext.Test.Name}");

        }

        [TearDown]
        public void TearDown()
        {
           string status= TestContext.CurrentContext.Result.Outcome.Status.ToString();
            string testMessage = TestContext.CurrentContext.Result.Message;
            //TestContext.CurrentContext.Result.

            //TestStatus.Passed
        }
    }
}
