using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace WPAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string BaseAdress {
            get { return "http://localhost:20596"; }
        }

        public static void Initialize()
        {
            Instance = new ChromeDriver("C:\\Users\\maxte\\Source\\Repos\\pft\\WPAutomation\\packages\\Selenium.WebDriver.ChromeDriver.2.23.0.1\\driver");
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static void Close()
        {
            Instance.Close();
        }

        internal static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int) timeSpan.TotalSeconds * 1000);
        }
    }
}