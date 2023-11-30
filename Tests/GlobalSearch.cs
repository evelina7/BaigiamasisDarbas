using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class GlobalSearch : BaseTests
    {
        [Test]
        public void SearchProductByCategoryName() 
        {
            string productCategory = "samsung";

            Telia.ClickButtonGlobalSearch();
            Telia.AddedValueToGlobalSearch(productCategory);
            TeliaPaieska.CheckIfSearchResultIsEqualToSearchValue();
            string actualInputFieldResult = TeliaPaieska.CheckIfSearchResultIsEqualToSearchValue();

            Assert.That(actualInputFieldResult, Is.EqualTo(productCategory));
        }
    }
}
