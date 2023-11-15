using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class TeliaMano
    {
        internal class Locators
        {
            internal static string privateClientLoginButton = "(//*[@type='submit'])[3]";
        }

        public static void ClickPrivateClientLoginButton()
        {
            Common.ClickElement(Locators.privateClientLoginButton);
        }
    }
}
