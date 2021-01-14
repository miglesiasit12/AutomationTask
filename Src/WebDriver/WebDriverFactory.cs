using System;
using OpenQA.Selenium;

namespace AutomationTask.WebDriver
{
    public class WebDriverFactory
    {
        public static IWebDriver GetWebDriver(BrowserType browser)
        {
            IWebDriver driver;
            switch (browser)
            {
                case BrowserType.Chrome:
                    driver = ChromeWebDriver.GetChromeWebDrvier();
                    break;
                case BrowserType.FireFox:
                    driver = FireFoxWebDriver.GetFireFoxWebDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }

            return driver;
        }
        
        public static IWebDriver GetWebDriver(Uri remoteUrl, ICapabilities capabilities)
        {
            return RemoteWebDriver.GetRemoteWebDriver(remoteUrl, capabilities);;
        }
    }
}