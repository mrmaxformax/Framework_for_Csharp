﻿using OpenQA.Selenium;

namespace WPAutomation
{

    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                var h2s = Driver.Instance.FindElements(By.TagName("h1"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "Dashboard";
                return false;
            }
        }
    }
}

