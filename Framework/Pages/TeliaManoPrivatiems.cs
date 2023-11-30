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

        public static void SelectByPassword()
        {
            if (Common.GetElementAttribute(byPasswordSelection, "class").Contains("c-black"))
            {
                Common.ClickElement(byPasswordSelection);
            }
        }

        public static void SelectByBankAccount()
        {
            if (Common.GetElementAttribute(byBankAccountSelection, "class").Contains("c-black"))
            {
                Common.ClickElement(byBankAccountSelection);
            }
        }

        public static void SelectBankSwedbank()
        {
            Common.ClickElement(chooseBankSwedbank);
        }

        public static void ClickLogin()
        {
            Common.ClickElement(loginButton);
        }

        public static string GetUsernameFieldPlaceholder()
        {
            return Common.GetElementAttribute(emailOrUsernameInputField, "placeholder");
        }

        public static string GetPasswordFieldPlaceholder()
        {
            return Common.GetElementAttribute(passwordInputField, "placeholder");
        }
    }
}
