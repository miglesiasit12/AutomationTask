using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationTask.model
{
    public class OptionsPage : BasePage
    {
        public OptionsPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector,
            Using =
                "#CodeForm > div.main > div.sidebar.unselectable > div:nth-child(1) > button.btn.btn-default.btn-xs.btn-sidebar-toggle > span")]
        [CacheLookup]
        private IWebElement _hideArrow;

        [FindsBy(How = How.CssSelector,
            Using = "#CodeForm > div.main > div.sidebar.unselectable > div:nth-child(1) > div > strong")]
        [CacheLookup]
        private IWebElement _optionsHeader;

        [FindsBy(How = How.CssSelector, Using = "#CodeForm > div.main > div.sidebar.unselectable")] [CacheLookup]
        private IWebElement _optionsSideBar;


        public void ClickHideArrow()
        {
            var retryTimes = 0;
            _hideArrow.Click();
            do
            {
                retryTimes++;
            } while (_optionsSideBar.GetAttribute("style") != "left: -180px;" && retryTimes < 10000);
        }

        public bool IsOptionsHeaderDisplayed()
        {
            return _optionsHeader.Displayed;
        }
    }
}