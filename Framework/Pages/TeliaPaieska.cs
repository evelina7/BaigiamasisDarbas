using System.Collections.Generic;

namespace Framework.Pages
{
    public class TeliaPaieska
    {
        private static string searchResultTitle = "//*[@data-type='PRODUCT']//*[contains(@class,'card__title')]";

        public static List<string> GetTitlesOfSearchResults()
        {
            return Common.GetTextOfElements(searchResultTitle);
        }
    }
}
