using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Driver
    {
        public static IWebDriver driver;

        public static void InitializeMaximizedDriver()
        {
            ChromeOptions MyOptions = new ChromeOptions();
            MyOptions.AddArgument("--start-maximized");
            driver = new ChromeDriver(MyOptions);
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenPage(string url)
        {
            driver.Url = url;
        }

        public static string GetPageTitle()
        {
            return driver.Title;
        }

        public static string GetCurrentUrl()
        {
            return driver.Url;
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}

