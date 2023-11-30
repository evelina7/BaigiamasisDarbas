namespace Framework.Pages
{
    public class TeliaPrekesUzsakymas
    {
        private static string buyProductButton = "(//*[@role='button'])[2]";
        private static string productName = "//*[@class='cart-box-product-card']//*[@class='cart-box-product-card__title cart-box-product-card__title--bold']";

        public static void ClickOnBuyButton()
        {
            Common.ClickElement(buyProductButton);
        }

        public static string GetBasketProductTitle()
        {
            return Common.GetElementText(productName);
        }
    }
}
