using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ShovelQA_Pro.Pages;
using ShovelQA_Pro.Config;
using ShovelQA_Pro.Utils;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace ShovelQA_Pro.Tests
{
        [TestClass]
        public class LoginTest
        {

            IWebDriver driver;
            private static TestContext testContext;
            private string testName;

            [TestInitialize]
            public void Setup()

            {
                XMLReader reader = new XMLReader(driver);
                reader.SetFrameSettings();
                String driverpath = reader.DriverPath;
                driver = new ChromeDriver(driverpath);
                driver.Manage().Window.Maximize();
                this.testName = testContext.TestName;

            }

            [ClassInitialize]
            public static void ClassInit(TestContext context)
            {
                testContext = context;
            }

            [TestMethod]
            public void AValidLoginTest()

            {
                LoginPage login_page = new LoginPage(driver);
                login_page.ValidLogin();
                Utilities Utils = new Utilities(driver);
                String CurrentTestMethodName = this.testName;
                String CurrentTestFixtureName = this.GetType().Name;
                Utils.WaitBeforeClick(1000);
                Utils.TakeScreenshot(CurrentTestFixtureName, "ValidLoginTest", "ValidLogin");
               
            }

            [TestCleanup]
            public void TearDown()

            {
                driver.Quit();

            }
        }
}
