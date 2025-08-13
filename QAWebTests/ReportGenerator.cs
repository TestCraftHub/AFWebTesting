using NUnit.Framework;
using QAWebTests.Framework.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebTests
{
    [SetUpFixture]
    public class ReportGenerator
    {
        [OneTimeSetUp]
        public void InitReport()
        {
            try
            {
                ExtentReportManager.InitReport();
            }
            catch(Exception ex) {

                throw new Exception($"Report initilization failed : {Environment.NewLine} {ex}");
            
            }

        }

        [OneTimeTearDown]
        public void FlushReport()
        {
            try
            {
                ExtentReportManager.FlushReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Flush failed: " + ex.Message);
            }

            Thread.Sleep(1000);
        }

        
       

        [Test]
        public void Test1()
        {
            Console.WriteLine("Defined in SetupFixtiure class");
        }
    }
}
