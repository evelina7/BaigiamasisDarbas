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
            TeliaManoPrivatiems.CheckIfUsernameInputFieldExisting();
            TeliaManoPrivatiems.CheckIfPasswordInputFieldExisting();
            TeliaManoPrivatiems.PlaceholderInPasswordInputField();
            bool actualPasswordInputField = TeliaManoPrivatiems.CheckIfPasswordInputFieldExisting();
            bool actualUsernameInputField = TeliaManoPrivatiems.CheckIfUsernameInputFieldExisting();


            Assert.That(actualUsernameInputField, Is.EqualTo(expectedInputField));
            Assert.That(actualPasswordInputField, Is.EqualTo(expectedInputField));
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
