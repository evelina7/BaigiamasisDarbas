using OpenQA.Selenium;

namespace Framework.Pages
{
    internal class Common
    {
        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }
        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }
    }
}
