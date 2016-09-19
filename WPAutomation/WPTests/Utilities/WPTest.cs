using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPAutomation;

namespace WPTests
{
    public class WPTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            PostCreator.Initialize();

            LoginPage.GoTo();
            LoginPage.LoginAs("mrmax").WithPassword("vfrcbvrf").Login();
        }

        [TestCleanup]
        public void Cleanup()
        {
            PostCreator.CleanUp();
            Driver.Close();
        }
    }
}
