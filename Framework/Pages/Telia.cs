
namespace Framework.Pages
{
    public class Telia
    {
        internal class Locators
        {
            internal static string rejectCookiesButton = "//*[@id=\"onetrust-reject-all-handler\"]";
            internal static string homepageLoginButton = "(//*[@type='submit'])[2]";
        }

        public static void ClickButtonRejectCookies()
        {
            Common.ClickElement(Locators.rejectCookiesButton);
        }

        public static void ClickHomepageLoginButton()
        {
            Common.ClickElement(Locators.homepageLoginButton);
        }
    }
}
