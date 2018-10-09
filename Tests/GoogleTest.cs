using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace dotnet_mstest
{
    [TestClass]
    public class GoogleTest : TestBase
    {

        GooglePage Google { get; set; }

        [TestInitialize]
        public void SetUpGoogle()
        {
            Google = GooglePage.At(Driver);
        }

        [TestMethod]
        [Ignore]
        public void ShouldLoadGooglePage()
        {
            Assert.AreEqual("Google", Driver.Title);
        }

        [TestMethod]
        public void ShouldSearchOnGoogle()
        {
            Google.Search(".NET Selenium Usage");
            Assert.AreEqual(".NET Selenium Usage - Google-keresés", Driver.Title);
        }
    }
}
