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
            bool expectedInputField = true;

            Telia.ClickHomepageLoginButton();
            TeliaMano.ClickPrivateClientLoginButton();
            TeliaManoPrivatiems.CheckIfSelectedLoginMethodIsByPassword();
            TeliaManoPrivatiems.SelectByPassword();
            TeliaManoPrivatiems.CheckIfPasswordInputFieldExisting();
            bool actualInputField = TeliaManoPrivatiems.CheckIfPasswordInputFieldExisting();

            Assert.That(actualInputField, Is.EqualTo(expectedInputField));
        }

        [Test]
        public void ByBankAccount()
        {
            string expectedPageTitle = "Login";

            Telia.ClickHomepageLoginButton();
            TeliaMano.ClickPrivateClientLoginButton();
            TeliaManoPrivatiems.CheckIfSelectedLoginMethodIsByBankAccount();
            TeliaManoPrivatiems.SelectByBankAccount();
            TeliaManoPrivatiems.SelectBankSwedbank();
            string actualPageTitle = Driver.GetPageTitle();

            Assert.That(actualPageTitle, Is.EqualTo(expectedPageTitle));
        }

    }
}
