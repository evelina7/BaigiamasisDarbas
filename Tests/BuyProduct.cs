using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class BuyProduct : BaseTests
    {
        [Test]
        public void BuyProductWithoutUserLogin()
        {
            Telia.ClickEshopSelectionButton();
            Telia.SelectPhonesFromEshopSelection();

            string productName = TeliaPrekes.GetProductTitle();

            TeliaPrekes.ClickOnFirstProduct();
            TeliaPrekesPreke.SelectWithoutPricePlan();
            TeliaPrekesPreke.ClickOnBuyButton();
            string actualName = TeliaPrekesUzsakymas.GetBasketProductTitle();

            Assert.That(actualName, Is.EqualTo(productName));
        }
    }
}
