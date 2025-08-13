using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using Microsoft.Testing.Platform.Extensions.Messages;
using QAWebTests.Tests;

namespace QAWebTests.Framework.Reports
{
    public class ExtentReportManager
    {
        private static ExtentReports _report;
        private static ExtentTest _className;
        private static ExtentTest _test;

        private static ExtentSparkReporter _sparkReporter;
        private static string reportPath;

        public static void InitReport()
        {
            /*if (!Directory.Exists("Reports"))
                Directory.CreateDirectory("Reports");*/

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            //FileInfo file = new FileInfo(Directory.GetCurrentDirectory());

            /* DirectoryInfo debugDir = new DirectoryInfo(Directory.GetCurrentDirectory());
             string qAWebTestsFolder = debugDir?.Parent?.Parent?.Parent?.FullName;*/


            string binDir = AppDomain.CurrentDomain.BaseDirectory;
            string reportPath = binDir.Replace("bin\\Debug\\net8.0", "ReportOutput");

            reportPath = Path.Combine(reportPath, $"TestReport_{timestamp}.html");

            _sparkReporter = new ExtentSparkReporter(reportPath);
            _sparkReporter.Config.DocumentTitle = "Automation Test Report";
            _sparkReporter.Config.ReportName = "Regression Suite";


            _report = new ExtentReports();
            _report.AttachReporter(_sparkReporter);


        }

        public static void FlushReport()
        {
            _report.Flush();

        }


        public static void CreateClass(string className)
        {
            _className = _report.CreateTest(className);
        }

        public static void CreateTest(string testName)
        {
            _test =  _className.CreateNode(testName);

        }

        public static void TestStatus(string pass)
        { 
        //if(pass == "Passed")
            //_test;
        
        }

        public static void LogInformation(string message)
        {

           // _test.Info(message);
            _test.Log(Status.Info, message);
        }

    }
}
