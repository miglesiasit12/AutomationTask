using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationTask.WebDriver
{
    public static class FireFoxWebDriver
    {
        public static IWebDriver GetFireFoxWebDriver()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver();
        }
    }
}