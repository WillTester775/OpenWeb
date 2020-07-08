using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using HP.LFT.SDK.Web;

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
            //Code starts here 

            var browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

            var enterYourSearchTermEditField = browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"q",
                Placeholder = string.Empty,
                TagName = @"INPUT",
                Type = @"search"
            });
            enterYourSearchTermEditField.SetValue("hello");

            var webSearchButton = browser.Describe<IButton>(new ButtonDescription
            {
                ButtonType = @"submit",
                Name = @"web search",
                TagName = @"BUTTON"
            });
            webSearchButton.Click();
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
