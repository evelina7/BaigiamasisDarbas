using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class BuyProduct : BaseTests
    {
        [Test]
        public void BuyProductWithoutUserLogin()
        {
            Telia.ClickEshopSelectionButton();
            Telia.SelectPhonesFromEshopSelection();

            string elementName = TeliaPrekes.GetProductTitle();

            TeliaPrekes.ClickOnFirstProduct();
            TeliaPrekesPreke.SelectWithoutPricePlan();
            TeliaPrekesPreke.SelectFullPriceRadioButton();
            TeliaPrekesPreke.ClickOnBuyButton();
            string actualName = TeliaPrekesUzsakymas.GetBasketProductTitle();

              Assert.That(actualName, Is.EqualTo(elementName));
        }
    }
}
