namespace Framework.Pages
{
    public class TeliaPrekesUzsakymas
    {
        private static string buyProductButton = "(//*[@role='button'])[2]";
        private static string name = "//*[@name='name']";
        private static string email = "//*[@name='email']";
        private static string phoneNumber = "//*[@name='phone']";
        private static string consentCheckbox = "//*[@class='form-option__title form-option__title--checkbox']";
        private static string customerDataContinueButton = "//*[@class='btn btn-primary']";
        private static string productName = "//*[@class='cart-box-product-card']//*[@class='cart-box-product-card__title cart-box-product-card__title--bold']";

        public static void ClickOnBuyButton()
        {
            Common.ClickElement(buyProductButton);
        }

        public static string GetBasketProductTitle()
        {
           // string elementName = TeliaPrekes.GetProductTitle();
            string getBasketProductName = Common.GetElementText(productName);

                return getBasketProductName;
            
        }
    }
}
