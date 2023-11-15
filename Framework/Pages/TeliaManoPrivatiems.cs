
namespace Framework.Pages
{
    public class TeliaManoPrivatiems
    {
        internal class Locators
        {
            internal static string byPasswordSelection = "//*[@href='/mano/privatiems/sso/prisijungti-el-pastu']";
            internal static string passwordInputField = "(//*[@type='password'])[2]";
            internal static string byBankAccountSelection = "//*[@href='/mano/privatiems/sso/prisijungti-banku']";
            internal static string chooseBankSwedbank = "//*[@alt='SWEDBANK']";
            internal static string loginButton = "(//*[@type='submit'])[1]";
        }

        public static bool CheckIfSelectedLoginMethodIsByPassword()
        {
            string expectedClassName = "link-icon link-icon--no-float";

            IWebElement element = Common.GetElement(Locators.byPasswordSelection);
            string actualClassName = element.GetAttribute("class");

            if (actualClassName == expectedClassName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckIfSelectedLoginMethodIsByBankAccount()
        {
            string expectedClassName = "link-icon link-icon--no-float";

            IWebElement element = Common.GetElement(Locators.byBankAccountSelection);
            string actualClassName = element.GetAttribute("class");

            if (actualClassName == expectedClassName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void SelectByPassword()
        {
            if (CheckIfSelectedLoginMethodIsByPassword() == false)
            {
                Common.ClickElement(Locators.byPasswordSelection);
            }
        }

        public static void SelectByBankAccount()
        {
            if (CheckIfSelectedLoginMethodIsByBankAccount() == false)
            {
                Common.ClickElement(Locators.byBankAccountSelection);
            }
        }

        public static bool CheckIfPasswordInputFieldExisting()
        {
            string expectedInputFieldPlaceholderValue = "Slaptažodis";

            IWebElement element = Common.GetElement(Locators.passwordInputField);
            string actualInputFieldPlaceholderValue = element.GetAttribute("placeholder");

            if (actualInputFieldPlaceholderValue == expectedInputFieldPlaceholderValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void SelectBankSwedbank()
        {
            Common.ClickElement(Locators.chooseBankSwedbank);
            Common.ClickElement(Locators.loginButton);
        }
    }
}
