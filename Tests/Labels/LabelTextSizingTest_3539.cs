using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ShovelQA_Pro.Pages;
using ShovelQA_Pro.Config;
using ShovelQA_Pro.Utils;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System.Drawing;

namespace ShovelQA_Pro.Tests
{
    [TestClass]
    public class LabelTextSizingTest_3539
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
            //driver.Manage().Window.Maximize();
            driver.Manage().Window.Size = new Size(1024, 768);
            this.testName = testContext.TestName;

        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            testContext = context;
        }


        [TestMethod]
        public void ALabelsTextSizeSmallTest()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.LabelsTextSizeSmall();
            Utils.DoVisualRegression(CurrentTestFixtureName, "ALabelsTextSizeSmallTest", "SmallTextTest");
            Console.WriteLine("VisualRegression Compared: " + "Check Results at \\ActualSS\\LabelTextSizingTest_3539\\ALabelsTextSizeSmallTest");
        }


        [TestMethod]
        public void BLabelsTextSizeMediumTest()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.LabelsTextSizeMedium();
            Utils.DoVisualRegression(CurrentTestFixtureName, "BLabelsTextSizeMediumTest", "MediumTextTest");
            Console.WriteLine("VisualRegression Compared: " + "Check Results at \\ActualSS\\LabelTextSizingTest_3539\\BLabelsTextSizeMediumTest");
        }


        [TestMethod]
        public void CLabelsTextSizeLargeTest()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.LabelsTextSizeLarge();
            Utils.DoVisualRegression(CurrentTestFixtureName, "CLabelsTextSizeLargeTest", "LargeTextTest");
            Console.WriteLine("VisualRegression Compared: " + "Check Results at \\ActualSS\\LabelTextSizingTest_3539\\CLabelsTextSizeLargeTest");
        }

        [TestCleanup]
        public void TearDown()

        {
            driver.Quit();

        }
    }
}

