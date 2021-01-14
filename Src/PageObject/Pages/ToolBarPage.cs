using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;


namespace AutomationTask.model
{
    public class ToolBarPage : BasePage
    {

        public ToolBarPage(IWebDriver driver) : base(driver)
        {
        }
        
        [FindsBy(How = How.CssSelector, Using = "#run-button")]
        [CacheLookup]
        private IWebElement _runButton;

        public void ClickRunButton()
        {
            _runButton.Click();
        }
    }
}