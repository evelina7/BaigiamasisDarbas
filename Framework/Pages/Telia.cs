using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.CSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class Telia  
    {
        internal class Locators 
        {
            internal static string rejectCookiesButton = "//*[@id=\"onetrust-reject-all-handler\"]";
            internal static string homepageLoginButton = "(//*[@type='submit'])[2]";
        }

        public static void ClickButtonRejectCookies()
        {
            Common.ClickElement(Locators.rejectCookiesButton);
        }

        public static void ClickHomepageLoginButton()
        {
            Common.ClickElement(Locators.homepageLoginButton);
        }
    }
}
