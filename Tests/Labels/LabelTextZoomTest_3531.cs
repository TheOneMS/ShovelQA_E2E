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
    public class LabelTextZoomTest_3531
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
        public void GuidanceViewTopViewZoomInLarge()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.GuidanceViewLabelLargeTopZoomIn();
            Utils.DoCaptureBaseSS(CurrentTestFixtureName, "GuidanceViewLargeTopViewZoomIn", "LabelLargeZoomIn");
            LabelSettings_page.GuidanceViewLabelZoomOut();
            Utils.DoCaptureActualAndCompareBaseSS(CurrentTestFixtureName, "GuidanceViewLargeTopViewZoomIn", "GuidanceViewLargeTopViewZoomOut", "LabelLargeZoomIn", "LabelLargeZoomOut");
            Console.WriteLine("LargeLabelText in Top View Zoom is Compared: " + "Check Results at \\ActualSS\\LabelTextZoomTest_3531\\GuidanceViewLargeTopViewZoomOut");

        }
        [TestMethod]
        public void GuidanceViewTopViewZoomInSmall()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.GuidanceViewLabelSmallTopZoomIn();
            Utils.DoCaptureBaseSS(CurrentTestFixtureName, "GuidanceViewSmallTopViewZoomIn", "LabelSmallZoomIn");
            LabelSettings_page.GuidanceViewLabelZoomOut();
            Utils.DoCaptureActualAndCompareBaseSS(CurrentTestFixtureName, "GuidanceViewSmallTopViewZoomIn", "GuidanceViewSmallTopViewZoomOut", "LabelSmallZoomIn", "LabelSmallZoomOut");
            Console.WriteLine("SmallLabelText in Top View Zoom is Compared: " + "Check Results at \\ActualSS\\LabelTextZoomTest_3531\\GuidanceViewSmallTopViewZoomOut");

        }
        [TestMethod]
        public void GuidanceViewSideViewZoomInLarge()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.GuidanceViewLabelLargeSideZoomIn();
            Utils.DoCaptureBaseSS(CurrentTestFixtureName, "GuidanceViewLargeSideViewZoomIn", "LabelLargeZoomIn");
            LabelSettings_page.GuidanceViewLabelZoomOut();
            Utils.DoCaptureActualAndCompareBaseSS(CurrentTestFixtureName, "GuidanceViewLargeSideViewZoomIn", "GuidanceViewLargeSideViewZoomOut", "LabelLargeZoomIn", "LabelLargeZoomOut");
            Console.WriteLine("LargeLabelText in Side View Zoom is Compared: " + "Check Results at \\ActualSS\\LabelTextZoomTest_3531\\GuidanceViewLargeSideViewZoomOut");

        }
        [TestMethod]
        public void GuidanceViewSideViewZoomInSmall()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.GuidanceViewLabelSmallSideZoomIn();
            Utils.DoCaptureBaseSS(CurrentTestFixtureName, "GuidanceViewSmallSideViewZoomIn", "LabelSmallZoomIn");
            LabelSettings_page.GuidanceViewLabelZoomOut();
            Utils.DoCaptureActualAndCompareBaseSS(CurrentTestFixtureName, "GuidanceViewSmallSideViewZoomIn", "GuidanceViewSmallSideViewZoomOut", "LabelSmallZoomIn", "LabelSmallZoomOut");
            Console.WriteLine("SmallLabelText in Side View Zoom is Compared: " + "Check Results at \\ActualSS\\LabelTextZoomTest_3531\\GuidanceViewSmallSideViewZoomOut");

        }
        [TestMethod]
        public void GuidanceView3DViewZoomInLarge()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.GuidanceViewLabelLarge3DZoomIn();
            Utils.DoCaptureBaseSS(CurrentTestFixtureName, "GuidanceViewLabelLarge3DZoomIn", "LabelLargeZoomIn");
            LabelSettings_page.GuidanceViewLabelZoomOut();
            Utils.DoCaptureActualAndCompareBaseSS(CurrentTestFixtureName, "GuidanceViewLabelLarge3DZoomIn", "GuidanceViewLabelLarge3DZoomOut", "LabelLargeZoomIn", "LabelLargeZoomOut");
            Console.WriteLine("LargeLabelText in 3D View Zoom is Compared: " + "Check Results at \\ActualSS\\LabelTextZoomTest_3531\\GuidanceViewLabelLarge3DZoomOut");

        }
        [TestMethod]
        public void GuidanceView3DViewZoomInSmall()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.GuidanceViewLabelSmall3DZoomIn();
            Utils.DoCaptureBaseSS(CurrentTestFixtureName, "GuidanceViewLabelSmall3DZoomIn", "LabelSmallZoomIn");
            LabelSettings_page.GuidanceViewLabelZoomOut();
            Utils.DoCaptureActualAndCompareBaseSS(CurrentTestFixtureName, "GuidanceViewLabelSmall3DZoomIn", "GuidanceViewLabelSmall3DZoomOut", "LabelSmallZoomIn", "LabelSmallZoomOut");
            Console.WriteLine("SmallLabelText in 3D View Zoom is Compared: " + "Check Results at \\ActualSS\\LabelTextZoomTest_3531\\GuidanceViewLabelSmall3DZoomOut");

        }
        [TestMethod]
        public void GuidanceViewEquipmentLabelPos()

        {
            LoginPage login_page = new LoginPage(driver);
            login_page.ValidLogin();
            LabelSettingsPage LabelSettings_page = new LabelSettingsPage(driver);
            Utilities Utils = new Utilities(driver);
            String CurrentTestMethodName = this.testName;
            String CurrentTestFixtureName = this.GetType().Name;
            LabelSettings_page.GuidanceViewLabelSmall3DZoomIn();
            Utils.DoCaptureBaseSS(CurrentTestFixtureName, "GuidanceViewLabelSmall3DZoomIn", "LabelSmallZoomIn");
            LabelSettings_page.GuidanceViewLabelZoomOut();
            Utils.DoCaptureActualAndCompareBaseSS(CurrentTestFixtureName, "GuidanceViewLabelSmall3DZoomIn", "GuidanceViewLabelSmall3DZoomOut", "LabelSmallZoomIn", "LabelSmallZoomOut");
            Console.WriteLine("SmallLabelText in 3D View Zoom is Compared: " + "Check Results at \\ActualSS\\LabelTextZoomTest_3531\\GuidanceViewLabelSmall3DZoomOut");

        }

        [TestCleanup]
        public void TearDown()

        {
            driver.Quit();

        }
    }
}

