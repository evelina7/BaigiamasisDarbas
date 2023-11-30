using Framework.Pages;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    internal class GlobalSearch : BaseTests
    {
        [Test]
        public void SearchProductByCategoryName() 
        {
            string productCategory = "Samsung";

            Telia.ClickButtonGlobalSearch();
            Telia.AddedValueToGlobalSearch(productCategory);
            List<string> results = TeliaPrekes.GetTitlesOfSearchResults();

            foreach (string result in results)
            {
                Assert.That(result.Contains(productCategory));
            }
        }
    }
}
