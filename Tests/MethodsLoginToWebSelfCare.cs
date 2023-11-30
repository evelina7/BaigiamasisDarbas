using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class MethodsLoginToWebSelfCare : BaseTests
    {
        [Test]
        public void ByUsernameAndPassword()
        {
            string expectedUsernamePlaceholder = "El. pašto adresas (Telia ID)";
            string expectedPasswordPlaceholder = "Slaptažodis";

            Telia.ClickHomepageLoginButton();
            TeliaMano.ClickPrivateClientLoginButton();
            TeliaManoPrivatiems.SelectByPassword();
            string actualUsernamePlaceholder = TeliaManoPrivatiems.GetUsernameFieldPlaceholder();
            string actualPasswordPlaceholder = TeliaManoPrivatiems.GetPasswordFieldPlaceholder();

            Assert.That(actualUsernamePlaceholder, Is.EqualTo(expectedUsernamePlaceholder));
            Assert.That(actualPasswordPlaceholder, Is.EqualTo(expectedPasswordPlaceholder));
        }

        [Test]
        public void ByBankAccount()
        {
            string expectedPageTitle = "Login";

            Telia.ClickHomepageLoginButton();
            TeliaMano.ClickPrivateClientLoginButton();
            TeliaManoPrivatiems.SelectByBankAccount();
            TeliaManoPrivatiems.SelectBankSwedbank();
            TeliaManoPrivatiems.ClickLogin();
            string actualPageTitle = Driver.GetPageTitle();

            Assert.That(actualPageTitle, Is.EqualTo(expectedPageTitle));
        }
    }
}
