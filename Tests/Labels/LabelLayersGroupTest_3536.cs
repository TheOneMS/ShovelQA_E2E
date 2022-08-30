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
    public class LabelLayersGroupTest_3536
    {
        IWebDriver driver;
        private static TestContext testContext;
        private string testName;
        private WebDriverWait wait;


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
        public void GuidanceLabelMaterialLabel()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.MaterialOutlineLabelsNearbyEnable();
            Utils.DoVisualRegression(CurrentTestFixtureName, "GuidanceLabelMaterialLabel_NearbyEnabled", "MaterialOutlineLabelsNearbyEnable");
            Console.WriteLine("VisualRegression Compared: " + "Check Results at \\ActualSS\\LabelLayersGroupTest_3529\\GuidanceLabelMaterialLabel_NearbyEnabled");
            LabelSettings_page.MaterialLabelsFarAwaySettingsCheck();
            Utils.DoCaptureBaseSS(CurrentTestFixtureName, "MaterialLabelsFarAwaySettingsDefault", "LabelsFarAwayDefaultSettingsSnap");
            Console.WriteLine("MaterialLabels_FarAwaySettings is Captured at BaseSS Folder Only: " + "Check Results at \\BaseSS\\LabelLayersGroupTest_3529\\MaterialLabelsFarAwaySettingsDefault");
            LabelSettings_page.MaterialOutlineLabelsFarAwayEnabledAndVerified();
            Utils.DoVisualRegression(CurrentTestFixtureName, "GuidanceLabelMaterialLabel_FarAwayEnabled", "MaterialOutlineLabelsFarAwayEnable");
            Console.WriteLine("VisualRegression Compared: " + "Check Results at \\ActualSS\\LabelLayersGroupTest_3529\\GuidanceLabelMaterialLabel_FarAwayEnabled");
        }

        [TestCleanup]
        public void TearDown()

        {
            driver.Quit();

        }
    }
}

