using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationTask.model
{
    public class MainWindowPage : BasePage
    {
        public MainWindowPage(IWebDriver driver) : base(driver)
        {
        }
        
        [FindsBy(How = How.CssSelector, Using = "#CodeForm > div.main.docked > div.content > div > div.output-container > div.output-pane.pane")]
        [CacheLookup]
        private IWebElement _outputTextBox;

        public string GetOutputTextBoxText()
        {
            return _outputTextBox.Text;
        }
    }
}