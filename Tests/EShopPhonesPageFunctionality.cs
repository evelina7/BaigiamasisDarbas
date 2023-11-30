using Framework.Pages;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    internal class EShopPhonesPageFunctionality : BaseTests
    {
        [Test]
        public void FiltersFunctionality()
        {
            string expectedBrand = "Apple";

            Telia.ClickEshopSelectionButton();
            Telia.SelectPhonesFromEshopSelection();
            TeliaPrekes.FilterByBrand(expectedBrand);
            List<string> titles= TeliaPrekes.GetTitlesOfSearchResults();

            foreach (string title in titles)
            {
                Assert.That(title.Contains(expectedBrand));
            }
        }
    }
}