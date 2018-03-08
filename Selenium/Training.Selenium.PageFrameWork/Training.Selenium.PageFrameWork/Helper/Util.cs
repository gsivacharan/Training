using System.Collections.Generic;

namespace Training.Selenium.PageFrameWork.Helper
{
    public class Util : TestBase
    {
        public static long PAGE_LOAD_TIMEOUT = 10;
        public static long IMPLICIT_WAIT = 10;

        public void switchToMainFrame()
        {
            Driver.SwitchTo().Frame("mainpanel");
        }
        public void switchToLeftFrame()
        {
            Driver.SwitchTo().Frame("leftpanel");
        }
        

        public static Dictionary<string, string> Title()
        {
            Dictionary<string, string> Titles = new Dictionary<string, string>
                {
                    {"Mr", "Mr"}
                };
            return Titles;
        }
    }
}
