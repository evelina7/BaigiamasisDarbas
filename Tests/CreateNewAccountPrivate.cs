using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class CreateNewAccountPrivate : BaseTests
    {
        [Test]
        public void UnsuccessfulLoginWithWrongEmail()
        {
            string emailInputValue = "Test";
            string expectedEmailInputErrorMessage = "Neteisingai įvestas el. pašto adresas";
            string expectedEmailInputBorderColor = "rgb(228, 23, 92)";

            Telia.ClickHomepageLoginButton();
            TeliaMano.ClickCreateAccountButton();
            TeliaManoPrivatiemsSSO.AddValueToEmailInputField(emailInputValue);
            TeliaManoPrivatiemsSSO.ClickSubmitButton(); 
            string actualEmailInputBorderColor = TeliaManoPrivatiemsSSO.GetEmailInputBorderColor();
            string actualEmailInputErrorMessage = TeliaManoPrivatiemsSSO.GetEmailInputErrorMessage();

            Assert.That(actualEmailInputBorderColor, Is.EqualTo(expectedEmailInputBorderColor));
            Assert.That(actualEmailInputErrorMessage, Is.EqualTo(expectedEmailInputErrorMessage));
        }
    }
}
