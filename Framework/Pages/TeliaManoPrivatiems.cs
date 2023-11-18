using OpenQA.Selenium;

namespace Framework.Pages
{
    public class TeliaManoPrivatiems
    {
        private static string byPasswordSelection = "//*[@href='/mano/privatiems/sso/prisijungti-el-pastu']"; 
        private static string emailOrUsernameInputField = "//*[@placeholder='El. pašto adresas (Telia ID)']";
        private static string passwordInputField = "(//*[@type='password'])[2]";
        private static string byBankAccountSelection = "//*[@href='/mano/privatiems/sso/prisijungti-banku']";
        private static string chooseBankSwedbank = "//*[@alt='SWEDBANK']";
        private static string loginButton = "(//*[@type='submit'])[1]";
        

        public static bool CheckIfSelectedLoginMethodIsByPassword()
        {
            string expectedClassName = "link-icon link-icon--no-float";

            IWebElement element = Common.GetElement(byPasswordSelection);
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

            IWebElement element = Common.GetElement(byBankAccountSelection);
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
                Common.ClickElement(byPasswordSelection);
            }
        }

        public static void SelectByBankAccount()
        {
            if (CheckIfSelectedLoginMethodIsByBankAccount() == false)
            {
                Common.ClickElement(byBankAccountSelection);
            }
        }

        public static bool CheckIfPasswordInputFieldExisting()
        {
            string expectedInputFieldPlaceholderValue = "Slaptažodis";

            IWebElement element = Common.GetElement(passwordInputField);
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

        public static bool CheckIfUsernameInputFieldExisting()
        {
            string expectedInputFieldPlaceholderValue = "El. pašto adresas (Telia ID)";

            IWebElement element = Common.GetElement(emailOrUsernameInputField);
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

        public static void PlaceholderInPasswordInputField()
        {
            Common.ClickElement(passwordInputField);
        }

        public static void SelectBankSwedbank()
        {
            Common.ClickElement(chooseBankSwedbank);
            Common.ClickElement(loginButton);
        }
    }
}
