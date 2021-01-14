using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace AutomationTask.WebDriver
{
    public class RemoteWebDriver
    {
        public static IWebDriver GetRemoteWebDriver(Uri url, ICapabilities options)
        {
            return new OpenQA.Selenium.Remote.RemoteWebDriver(url, options);
        }
    }
}