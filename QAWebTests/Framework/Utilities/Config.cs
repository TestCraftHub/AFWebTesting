using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebTests.Framework.Utilities
{
    public class Config
    {
        public string BaseUrl { get; set; }

        public string DriverName { get; set; }

        public Credentials Credentials { get; set; }

    }

    public class Credentials
    {
        public string UserName { set; get; }

        public string Password { get; set; }
    }
}
