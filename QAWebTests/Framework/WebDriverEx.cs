using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebTests.Framework
{
    public static class WebDriverEx
    {
        public static Func<LogEntry, bool> IgnoreConsoleErrors { get; set; }

    }
}
