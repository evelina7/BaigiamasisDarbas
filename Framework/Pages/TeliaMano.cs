namespace Framework.Pages
{
    public class TeliaMano
    {
        private static string privateClientLoginButton = "(//*[text()='Mobiliojo ryšio ir namų paslaugų savitarna'])[1]/..//button";
        private static string createAccountButton = "//*[@data-test='registration-button-b2c']";

        public static void ClickPrivateClientLoginButton()
        {
            Common.ClickElement(privateClientLoginButton);
        }

        public static void ClickCreateAccountButton()
        {
            Common.ClickElement(createAccountButton);
        }
    }
}
