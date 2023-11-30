namespace Framework.Pages
{
    public class TeliaPrekesPreke
    {
        private static string buyProductButton = "//*[@class='desktop-sticky-summary__section']//*[@data-test='cart-box-action-button']";
        private static string withoutPricePlanSelection = "//telia-col//*[text()='Be plano']";
        private static string productPaymentBlock = "//telia-col//*[text()='Įrangos mokestis']";

        public static void ClickOnBuyButton()
        {
            Common.ScrollToElement(buyProductButton);
            Common.ClickElement(buyProductButton);
        }

        public static void SelectWithoutPricePlan()
        {
            Common.WaitForElementToBeVisible(productPaymentBlock);
            Common.ScrollToElement(productPaymentBlock);
            Common.ClickElement(withoutPricePlanSelection);
        }
    }
}
