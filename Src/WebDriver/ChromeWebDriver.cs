using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationTask.WebDriver
{
    public static class ChromeWebDriver
    {
        public static IWebDriver GetChromeWebDrvier()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }
    }
}