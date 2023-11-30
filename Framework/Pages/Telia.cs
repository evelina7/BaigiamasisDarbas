using OpenQA.Selenium;

namespace Framework.Pages

{
    public class Telia
    {
        private static string rejectCookiesButton = "//*[@id=\"onetrust-reject-all-handler\"]";
        private static string homepageLoginButton = "(//*[@type='submit'])[2]";
        private static string globalSearchButton = "//*[@role='search']";
        private static string globalSearchInputField = "//*[@role='searchbox']";
        private static string eshopSelection = "//*[@href='#Eparduotuvė']";
        private static string eshopSelectionPhones = "//*[@href='/prekes/mobilieji-telefonai']";

        public static void ClickButtonRejectCookies()
        {
            Common.ClickElement(rejectCookiesButton);
        }

        public static void ClickHomepageLoginButton()
        {
            Common.ClickElement(homepageLoginButton);
        }

        public static void ClickEshopSelectionButton()
        {
            Common.ClickElement(eshopSelection);
        }

        public static void SelectPhonesFromEshopSelection()
        {
            Common.WaitForElementToBeVisible(eshopSelectionPhones);
            Common.ClickElement(eshopSelectionPhones);
        }

        public static void ClickButtonGlobalSearch()
        {
            Common.ClickElement(globalSearchButton);
        }
        public static void AddedValueToGlobalSearch(string productCategory)
        {
            Common.SendKeysToElementAndPressEnter(globalSearchInputField, productCategory);
        }
    }
}
