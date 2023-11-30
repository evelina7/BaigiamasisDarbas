using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class ProductComparison : BaseTests
    {
        [Test]
        public void CompareTwoMobilePhones()
        {
            Telia.ClickEshopSelectionButton();
            Telia.SelectPhonesFromEshopSelection();
            TeliaPrekes.SelectFirstProductComparisonCheckbox();
            TeliaPrekes.SelectSecondProductComparisonCheckbox();
            TeliaPrekes.ClickOnProductComparisonButton();

            string productFromComparisonModal_1 = TeliaPrekes.GetTitleFromProductComparisonModal_1();
            string productFromComparisonModal_2 = TeliaPrekes.GetTitleFromProductComparisonModal_2();

            TeliaPrekes.ClickOnButtonToOpenProductComparisonPage();

            string productFromComparisonPage_1 = TeliaPrekes.GetComparedProductTile_1();
            string productFromComparisonPage_2 = TeliaPrekes.GetComparedProductTile_2();

            Assert.That(productFromComparisonPage_1, Is.EqualTo(productFromComparisonModal_1));
            Assert.That(productFromComparisonPage_2, Is.EqualTo(productFromComparisonModal_2));
        }
    }
}
