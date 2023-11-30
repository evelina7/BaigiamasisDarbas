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

            string actualClassName = Common.GetElementAttribute(byPasswordSelection, "class");

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

            string actualClassName = Common.GetElementAttribute(byBankAccountSelection, "class");

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

            string actualInputFieldPlaceholderValue = Common.GetElementAttribute(passwordInputField, "placeholder");

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

            string actualInputFieldPlaceholderValue = Common.GetElementAttribute(emailOrUsernameInputField, "placeholder");

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
