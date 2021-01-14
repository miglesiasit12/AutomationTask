using System;
using AutomationTask.model;
using AutomationTask.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTask
{
    [TestFixture(BrowserType.Chrome, "https://dotnetfiddle.net/")]
    [TestFixture(BrowserType.FireFox, "https://dotnetfiddle.net/")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class TestSuite1
    {
        private IWebDriver _driver;
        private ToolBarPage _toolBarPage;
        private MainWindowPage _mainWindowPage;
        private OptionsPage _optionsPage;
        private readonly BrowserType _browserType;
        private readonly string _url;

        public TestSuite1(BrowserType browserType, string url)
        {
            _browserType = browserType;
            _url = url;
        }

        [SetUp]
        public void OpenWebpage()
        {
            _driver = WebDriverFactory.GetWebDriver(_browserType);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Url = _url;
        }

        [Test]
        public void RunDefaultCommand()
        {
            _toolBarPage = new ToolBarPage(_driver);
            _mainWindowPage = new MainWindowPage(_driver);

            _toolBarPage.ClickRunButton();
            Assert.AreEqual("Hello World", _mainWindowPage.GetOutputTextBoxText());
        }

        [Test]
        public void HideOptionsPanel()
        {
            _optionsPage = new OptionsPage(_driver);

            _optionsPage.ClickHideArrow();
            Assert.AreEqual(false, _optionsPage.IsOptionsHeaderDisplayed());
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}