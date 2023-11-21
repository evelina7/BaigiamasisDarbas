using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace Framework
{
    public class Driver
    {
        public static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();   

        public static void InitializeMaximizedDriver()
        {
            ChromeOptions MyOptions = new ChromeOptions();
            MyOptions.AddArgument("--start-maximized");
            driver.Value = new ChromeDriver(MyOptions);
        }

        internal static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void OpenPage(string url)
        {
            driver.Value.Url = url;
        }

        public static string GetPageTitle()
        {
            return driver.Value.Title;
        }

        internal static string GetCurrentUrl()
        {
            return driver.Value.Url;
        }

        public static void QuitDriver()
        {
            driver.Value.Quit();
        }

        public static void TakeScreenshot(string name)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{name}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}.png";

            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);

            // Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);  //directorijos kelias
        }
    }
}

