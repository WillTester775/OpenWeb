using HP.LFT.SDK.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenWeb
{
    [TestClass]
    public class UftDeveloperTest : UnitTestClassBase<UftDeveloperTest>
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            GlobalSetup(context);
        }

        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestMethod]
        public void OpenBrowserMethod()
        {
            IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalTearDown();
        }
    }
}
