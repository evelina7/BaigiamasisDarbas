using OpenQA.Selenium;

namespace Framework.Pages
{
    public class TeliaPaieska
    {
        private static string searchInputField = "(//*[@name='ieskoti'])[3]";

        public static string CheckIfSearchResultIsEqualToSearchValue()
        {
            string expectedInputFieldPlaceholderValue = "samsung";
            string actualInputFieldPlaceholderValue = Common.GetElementAttribute(searchInputField, "value");

            if (actualInputFieldPlaceholderValue == expectedInputFieldPlaceholderValue)
            {
                return actualInputFieldPlaceholderValue;
            }
            else
            {
                return actualInputFieldPlaceholderValue;
            }
        }
    }
}
