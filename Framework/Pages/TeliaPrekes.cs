using System.Collections.Generic;

namespace Framework.Pages
{
    public class TeliaPrekes
    {
        private static string firstProduct = "//*[@class='js-product-compare-image']";
        private static string firstProductTitle = "(//*[@class='col-lg-4 col-sm-6 col-xs-12 ']//*[@class='mobiles-product-card__title js-open-product'])[1]";
        private static string firstProductComparisonCheckbox = "//*[@class='col-lg-4 col-sm-6 col-xs-12 ']//*[text()='Palyginti']";  
        private static string secondProductComparisonCheckbox = "(//*[@class='col-lg-4 col-sm-6 col-xs-12 ']//*[text()='Palyginti'])[2]";
        private static string productComparisonButton = "//*[@class='sticky-navigation-footer__button']";
        private static string openProductComparisonPageButton = "//*[@href='/palyginimas/prekes/mobilieji-telefonai']";
        private static string comparisonModalProduct_1 = "(//*[@class='compare-basket']//*[@class='col-sm-4'])[1]";
        private static string comparisonModalProduct_2 = "(//*[@class='compare-basket']//*[@class='col-sm-4'])[2]";
        private static string comparisonPageProduct_1 = "(//*[@class='product-compare__wrapper']//*[@class='col-lg-3 col-sm-4'])[1]";
        private static string comparisonPageProduct_2 = "(//*[@class='product-compare__wrapper']//*[@class='col-lg-3 col-sm-4'])[2]";
        private static string searchResultTitle = "//*[@data-type='PRODUCT']//*[contains(@class,'card__title')]";

        public static void ClickOnFirstProduct()
        {
            Common.ClickElement(firstProduct);
        }

        public static void SelectFirstProductComparisonCheckbox()
        {
            Common.ClickElement(firstProductComparisonCheckbox);
        }

        public static void SelectSecondProductComparisonCheckbox()
        {
            Common.ClickElement(secondProductComparisonCheckbox);
        }

        public static void ClickOnProductComparisonButton()
        {
            Common.WaitForElementToBeVisible(productComparisonButton);
            Common.ClickElement(productComparisonButton);
        }

        public static string GetTitleFromProductComparisonModal_1()
        {
            return Common.GetElementAttribute(comparisonModalProduct_1, "value");
        }

        public static string GetTitleFromProductComparisonModal_2()
        {
            return Common.GetElementAttribute(comparisonModalProduct_2, "value");
        }

        public static void ClickOnButtonToOpenProductComparisonPage()
        {
            Common.WaitForElementToBeVisible(openProductComparisonPageButton);
            Common.ClickElement(openProductComparisonPageButton);
        }

        public static string GetComparedProductTile_1()
        {
            return Common.GetElementAttribute(comparisonPageProduct_1, "value");
        }

        public static string GetComparedProductTile_2()
        {
            return Common.GetElementAttribute(comparisonPageProduct_2, "value");
        }

        public static string GetFirstProductTitle()
        {
            return Common.GetElementText(firstProductTitle);
        }

        public static void FilterByBrand(string brandName)
        {
            Common.ClickElement($"//*[@value='::eshop_brandTabletsPhones:{brandName}']/..//label");
        }

        public static List<string> GetTitlesOfSearchResults()
        {
            return Common.GetElementsText(searchResultTitle);
        }
    }
}
