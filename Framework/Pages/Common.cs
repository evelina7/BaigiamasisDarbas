using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Pages
{
    public class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static string GetElementText(string locator)
        {
            IWebElement element = Common.GetElement(locator);
            string locatorText = element.Text;
            return locatorText;
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        public static void ClickButtonSubmit(string locator)
        {
            string script = "arguments[0].scrollIntoView(true);";
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript(script, locator);
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        public static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)));
        }

        internal static string GetElementCssPropertyValue(string locator, string propertyName)
        {
            IWebElement element = GetElement(locator);
            return element.GetCssValue(propertyName);
        }

        internal static string GetElementAttribute(string locator, string attributeName)
        {
            IWebElement element = GetElement(locator);
            return element.GetAttribute(attributeName);
        }



        internal static void SendKeysToElementAndPressEnter(string locator, string keys)
        {
            SendKeysToElement(locator, keys + Keys.Enter);
        }

        internal static List<string> GetElementsText(string locator)
        {
            List<string> texts = new List<string>();
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                texts.Add(element.Text);
            }

            return texts;
        }

        internal static List<string> GetElementsAttribute(string locator, string attributeName)
        {
            List<string> attributeValues = new List<string>();
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                attributeValues.Add(element.GetAttribute(attributeName));
            }

            return attributeValues;
        }

        internal static void ScrollToElement(string locator)
        {
            IWebElement element = GetElement(locator);

            Actions actions = new Actions(Driver.GetDriver());
            actions.ScrollToElement(element);
            actions.Perform();
        }
    }
}
