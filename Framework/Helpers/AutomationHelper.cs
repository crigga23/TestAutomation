using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helpers
{
    public class AutomationHelper
    {
        private static IWebDriver AutomationDriver { get; set; }

        private AutomationHelper()
        {
            if (AutomationDriver == null) {
                CreateAutomationDriver();
            }
        }

        public static IWebDriver CreateAutomationDriver()
        {
            AutomationDriver = new NgWebDriver(new ChromeDriver());

            //AutomationDriver = new ChromeDriver();
            return AutomationDriver;
        }
    }
}
