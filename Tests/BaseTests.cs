using Framework;
using Framework.Pages;
using NUnit.Framework;

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
            Driver.QuitDriver();
        }
    }
}
