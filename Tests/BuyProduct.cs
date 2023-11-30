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

            string productName = TeliaPrekes.GetProductTitle();

            TeliaPrekes.ClickOnFirstProduct();
            TeliaPrekesPreke.SelectWithoutPricePlan();
            TeliaPrekesPreke.ClickOnBuyButton();
            string actualName = TeliaPrekesUzsakymas.GetBasketProductTitle();

            Assert.That(actualName, Is.EqualTo(productName));
        }
    }
}
