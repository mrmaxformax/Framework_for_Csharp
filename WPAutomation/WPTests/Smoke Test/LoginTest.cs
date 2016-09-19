using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPAutomation;

namespace WPTests
{
    [TestClass]
    public class LoginTests : WPTest
    {
        [TestMethod]
        public void Admin_User_Can_Login()
        {
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }
        
    }
}

