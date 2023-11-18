using OpenQA.Selenium;

namespace Framework.Pages
{
    public class TeliaMano
    {
        private static string privateClientLoginButton = "(//*[text()='Mobiliojo ryšio ir namų paslaugų savitarna'])[1]/..//button";

        public static void ClickPrivateClientLoginButton()
        {
            Common.ClickElement(privateClientLoginButton);
        }
    }
}
