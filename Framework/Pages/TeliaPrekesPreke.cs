using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Framework.Pages
{
    public class TeliaPrekesPreke
    {
        private static string buyProductButton = "//*[@data-test='cart-box-action-button']";
        private static string forFullPriceRadioButton = "//*[@id=\"fullPayment\"]";
        private static string element = "//telia-col//*[text()='Visa kaina']";
        private static string withoutPricePlanSelection = "//telia-col//*[text()='Be plano']";
        private static string productPaymentBlock = "//telia-col//*[text()='Įrangos mokestis']";
        private static string productSummary = "//telia-col//*[text()='Užsakymo suvestinė']";

        public static void ClickOnBuyButton()
        {
            Common.ClickElement(buyProductButton);
        }

        public static void SelectWithoutPricePlan()
        {
            Common.WaitForElementToBeVisible(productPaymentBlock);
            new Actions(Driver.driver.Value).ScrollToElement(Common.GetElement(productPaymentBlock)).Perform();
            Common.ClickElement(withoutPricePlanSelection);
        }

        public static void SelectFullPriceRadioButton()
        {
            Common.WaitForElementToBeVisible(element);
            new Actions(Driver.driver.Value).ScrollToElement(Common.GetElement(element)).Perform();
        }
    }
}
