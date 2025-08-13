using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebTests
{
    public abstract class QAWebTestBase
    {
        public static IWebDriver Driver { get; protected set; }

    }
}
