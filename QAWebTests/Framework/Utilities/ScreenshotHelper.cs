using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebTests.Framework.Utilities
{
    public static class ScreenshotHelper
    {

        private static readonly string runTimestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

        public static string SavePageScreenshot(IWebDriver driver, string fileName, ExtentTest extentTest = null)
        {
            //Get running class and Test Name
            string testClassName = string.IsNullOrWhiteSpace(TestContext.CurrentContext.Test.DisplayName) ? "Test_Screenot" : TestContext.CurrentContext.Test.DisplayName;
            string testName = TestContext.CurrentContext.Test.Name;

            // Create folder for current running class under base direactory
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots", testClassName);

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            //Screenshot file name format: Prefix_TestName_Timestamp.png
            string screenshotFileName = $"{fileName}_{testName}_{runTimestamp}.png";
            string fullPath = Path.Combine(folderPath, screenshotFileName);

            //Take screenshot and save it
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            //ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;

            screenshot.SaveAsFile(fullPath);

            //screenshot.SaveAsFile("screenshot.png", ScreenshotImageFormat.Png); // works only on older version selenium 3

            if (extentTest != null)
                extentTest.AddScreenCaptureFromPath(fullPath);

            return fullPath;
        }

        public static FileInfo GetElementScreenshot(IWebElement element, string fileName)
        {
            var fullpath = new FileInfo(Path.Combine("tempPath", fileName));

            Screenshot screenshot = ((ITakesScreenshot)element).GetScreenshot();

            screenshot.SaveAsFile(fullpath.FullName + ".png");
            return fullpath;
        }

    }
}
