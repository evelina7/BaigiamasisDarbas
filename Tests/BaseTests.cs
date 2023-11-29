using Framework;
using Framework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests
{
    internal class BaseTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeMaximizedDriver();
            Driver.OpenPage("https://www.telia.lt/");
            Telia.ClickButtonRejectCookies();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string name = TestContext.CurrentContext.Test.MethodName;
                Driver.TakeScreenshot(name);
            }

            Driver.QuitDriver();
        }
    }
}
