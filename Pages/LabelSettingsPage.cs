using System;
using ShovelQA_Pro.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using ShovelQA_Pro.Utils;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;

namespace ShovelQA_Pro.Pages
{
    class LabelSettingsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;


        public LabelSettingsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
        public IWebElement LabelsBtn => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[4]/button")));
        public IWebElement TextSizeBtn => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/aside/button[2]")));
        public IWebElement SmallBtn => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/aside/button[1]")));
        public IWebElement MediumBtn => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/aside/button[2]")));
        public IWebElement LargeBtn => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/aside/button[3]")));
        public IWebElement frame => driver.FindElement(By.Id("iframe"));
        public IWebElement GuideViewOptionsIcon => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[3]/div/div/div/div[3]/button/span[2]")));
        //public IWebElement GuideViewOptionsIcon => (IWebElement)driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div/div/div/div[3]/button/span[2]")));
        //public IWebElement GuideViewOptionsIcon => driver.FindElement(By.Id("viewOptions"));

        public IWebElement TopDownIcon => driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[1]/div/div/div/div[1]/div[1]/div/button"));
        public IWebElement SideViewIcon => driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[1]/div/div/div/div[2]/div[1]/div/button"));
        public IWebElement ThreeDIcon => driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[1]/div/div/div/div[2]/div[2]/div/button"));
        public IWebElement ZoomInIcon => driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div/div/div/div[1]/button"));
        public IWebElement ZoomOutIcon => driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div/div/div/div[2]/button"));
        public IWebElement LayerSettingsToolIcon => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/button")));
        public IWebElement DisplaySettingsSection => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/div/div/div[3]/div/div[1]/h4")));
        public IWebElement MachLabelsChkBox => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/div/div/div[4]/div/div[3]/div/label/span[2]")));
        public IWebElement LayerSettingsToolCloseIcon => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/header/div/button/span[2]")));
        public IWebElement MaterialsSettingsSection => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/div/div/div[5]/div/div[1]/h4")));
        public IWebElement BlockOutlineChkBoxFarAway => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/div/div/div[5]/div/div[3]/div[1]/label/span[2]")));
        public IWebElement MatLabelsChkBoxFarAway => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/div/div/div[5]/div/div[3]/div[3]/label/span[2]")));
        public IWebElement BlockOutlineChkBoxNearby => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/div/div/div[5]/div/div[3]/div[2]/label/span[2]")));
        public IWebElement MatLabelsChkBoxNearby => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/div/div/div[5]/div/div[3]/div[4]/label/span[2]")));
        public IWebElement TerrainSurfaceSettingsSection => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/div/div/div[6]/div/div[1]/h4")));

        public void LabelsTextSizeSmall()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Assert.IsTrue(LabelsBtn.Displayed);
            Console.WriteLine("LabelsBtn Displayed?: " + LabelsBtn.Displayed);
            LabelsBtn.Click();
            Utils.WaitBeforeClick(3000);
            Assert.IsTrue(TextSizeBtn.Displayed);
            Console.WriteLine("TextSizeBtn Displayed?: " + TextSizeBtn.Displayed);
            TextSizeBtn.Click();
            Utils.WaitBeforeClick(3000);
            Assert.IsTrue(SmallBtn.Displayed);
            Console.WriteLine("SmallBtn Displayed?: " + SmallBtn.Displayed);
            SmallBtn.Click();
        }
        public void LabelsTextSizeMedium()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Assert.IsTrue(LabelsBtn.Displayed);
            Console.WriteLine("LabelsBtn Displayed?: " + LabelsBtn.Displayed);
            LabelsBtn.Click();
            Utils.WaitBeforeClick(3000);
            Assert.IsTrue(TextSizeBtn.Displayed);
            Console.WriteLine("TextSizeBtn Displayed?: " + TextSizeBtn.Displayed);
            TextSizeBtn.Click();
            Utils.WaitBeforeClick(3000);
            Assert.IsTrue(MediumBtn.Displayed);
            Console.WriteLine("MediumBtn Displayed?: " + MediumBtn.Displayed);
            MediumBtn.Click();
        }
        public void LabelsTextSizeLarge()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Assert.IsTrue(LabelsBtn.Displayed);
            Console.WriteLine("LabelsBtn Displayed?: " + LabelsBtn.Displayed);
            LabelsBtn.Click();
            Utils.WaitBeforeClick(3000);
            Assert.IsTrue(TextSizeBtn.Displayed);
            Console.WriteLine("TextSizeBtn Displayed?: " + TextSizeBtn.Displayed);
            TextSizeBtn.Click();
            Utils.WaitBeforeClick(3000);
            Assert.IsTrue(LargeBtn.Displayed);
            Console.WriteLine("LargeBtn Displayed?: " + LargeBtn.Displayed);
            LargeBtn.Click();

        }


        public void GuidanceViewLabelLargeTopZoomIn()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Utils.WaitBeforeClick(1000);
            LabelsBtn.Click();
            Utils.WaitBeforeClick(1000);
            TextSizeBtn.Click();
            Utils.WaitBeforeClick(2000);
            LargeBtn.Click();
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(GuideViewOptionsIcon.Displayed);
            Console.WriteLine("GuideViewOptionsIcon Displayed?: " + GuideViewOptionsIcon.Displayed);
            GuideViewOptionsIcon.Click();
            Utils.WaitBeforeClick(1000);
            Assert.IsTrue(TopDownIcon.Displayed);
            Console.WriteLine("TopDownIcon Displayed?: " + TopDownIcon.Displayed);
            TopDownIcon.Click();
            //Utils.WaitBeforeClick(3000);
            Assert.IsTrue(ZoomInIcon.Displayed);
            Console.WriteLine("ZoomInIcon Displayed?: " + ZoomInIcon.Displayed);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
        }
        public void GuidanceViewLabelSmallTopZoomIn()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Utils.WaitBeforeClick(1000);
            LabelsBtn.Click();
            Utils.WaitBeforeClick(1000);
            TextSizeBtn.Click();
            Utils.WaitBeforeClick(2000);
            SmallBtn.Click();
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(GuideViewOptionsIcon.Displayed);
            Console.WriteLine("GuideViewOptionsIcon Displayed?: " + GuideViewOptionsIcon.Displayed);
            GuideViewOptionsIcon.Click();
            Utils.WaitBeforeClick(1000);
            Assert.IsTrue(TopDownIcon.Displayed);
            Console.WriteLine("TopDownIcon Displayed?: " + TopDownIcon.Displayed);
            TopDownIcon.Click();
            //Utils.WaitBeforeClick(3000);
            Assert.IsTrue(ZoomInIcon.Displayed);
            Console.WriteLine("ZoomInIcon Displayed?: " + ZoomInIcon.Displayed);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
        }
        public void GuidanceViewLabelZoomOut()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Utils.WaitBeforeClick(1000);
            ZoomOutIcon.Click();
            ZoomOutIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomOutIcon.Click();
            Assert.IsTrue(ZoomOutIcon.Displayed);
            Console.WriteLine("ZoomOutIcon Displayed?: " + ZoomOutIcon.Displayed);
            Utils.WaitBeforeClick(1000);
            ZoomOutIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomOutIcon.Click();
            ZoomOutIcon.Click();

        }
        public void GuidanceViewLabelLargeSideZoomIn()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Utils.WaitBeforeClick(1000);
            LabelsBtn.Click();
            Utils.WaitBeforeClick(1000);
            TextSizeBtn.Click();
            Utils.WaitBeforeClick(2000);
            LargeBtn.Click();
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(GuideViewOptionsIcon.Displayed);
            Console.WriteLine("GuideViewOptionsIcon Displayed?: " + GuideViewOptionsIcon.Displayed);
            GuideViewOptionsIcon.Click();
            Utils.WaitBeforeClick(1000);
            Assert.IsTrue(SideViewIcon.Displayed);
            Console.WriteLine("SideViewIcon Displayed?: " + SideViewIcon.Displayed);
            SideViewIcon.Click();
            //Utils.WaitBeforeClick(3000);
            Assert.IsTrue(ZoomInIcon.Displayed);
            Console.WriteLine("ZoomInIcon Displayed?: " + ZoomInIcon.Displayed);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            ZoomInIcon.Click();
        }
        public void GuidanceViewLabelSmallSideZoomIn()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Utils.WaitBeforeClick(1000);
            LabelsBtn.Click();
            Utils.WaitBeforeClick(1000);
            TextSizeBtn.Click();
            Utils.WaitBeforeClick(2000);
            SmallBtn.Click();
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(GuideViewOptionsIcon.Displayed);
            Console.WriteLine("GuideViewOptionsIcon Displayed?: " + GuideViewOptionsIcon.Displayed);
            GuideViewOptionsIcon.Click();
            Utils.WaitBeforeClick(1000);
            Assert.IsTrue(SideViewIcon.Displayed);
            Console.WriteLine("SideViewIcon Displayed?: " + SideViewIcon.Displayed);
            SideViewIcon.Click();
            //Utils.WaitBeforeClick(3000);
            //Following 7 lines were used to check whether the proper label size is set while doing side pane zoom
            //driver.SwitchTo().DefaultContent();
            //LargeBtn.Click();
            //Utils.WaitBeforeClick(2000);
            //SmallBtn.Click();
            //SmallBtn.Click();
            //Console.WriteLine("SmallBtn Displayed?: " + SmallBtn.Displayed);
            //driver.SwitchTo().Frame(frame);
            Assert.IsTrue(ZoomInIcon.Displayed);
            Console.WriteLine("ZoomInIcon Displayed?: " + ZoomInIcon.Displayed);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            ZoomInIcon.Click();
        }
        public void GuidanceViewLabelLarge3DZoomIn()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Utils.WaitBeforeClick(1000);
            LabelsBtn.Click();
            Utils.WaitBeforeClick(1000);
            TextSizeBtn.Click();
            Utils.WaitBeforeClick(2000);
            LargeBtn.Click();
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(GuideViewOptionsIcon.Displayed);
            Console.WriteLine("GuideViewOptionsIcon Displayed?: " + GuideViewOptionsIcon.Displayed);
            GuideViewOptionsIcon.Click();
            Utils.WaitBeforeClick(1000);
            Assert.IsTrue(ThreeDIcon.Displayed);
            Console.WriteLine("ThreeDIcon Displayed?: " + ThreeDIcon.Displayed);
            ThreeDIcon.Click();
            //Utils.WaitBeforeClick(3000);
            Assert.IsTrue(ZoomInIcon.Displayed);
            Console.WriteLine("ZoomInIcon Displayed?: " + ZoomInIcon.Displayed);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            ZoomInIcon.Click();
        }
        public void GuidanceViewLabelSmall3DZoomIn()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Utils.WaitBeforeClick(1000);
            LabelsBtn.Click();
            Utils.WaitBeforeClick(1000);
            TextSizeBtn.Click();
            Utils.WaitBeforeClick(2000);
            SmallBtn.Click();
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(GuideViewOptionsIcon.Displayed);
            Console.WriteLine("GuideViewOptionsIcon Displayed?: " + GuideViewOptionsIcon.Displayed);
            GuideViewOptionsIcon.Click();
            Utils.WaitBeforeClick(1000);
            Assert.IsTrue(ThreeDIcon.Displayed);
            Console.WriteLine("ThreeDIcon Displayed?: " + ThreeDIcon.Displayed);
            ThreeDIcon.Click();
            Assert.IsTrue(ZoomInIcon.Displayed);
            Console.WriteLine("ZoomInIcon Displayed?: " + ZoomInIcon.Displayed);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            Utils.WaitBeforeClick(1000);
            ZoomInIcon.Click();
            ZoomInIcon.Click();
        }


        public void LayerSettingsMachLabelEnabled()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(LayerSettingsToolIcon.Displayed);
            Console.WriteLine("LayerSettingsToolIcon Displayed?: " + LayerSettingsToolIcon.Displayed);
            LayerSettingsToolIcon.Click();
            Utils.WaitBeforeClick(500);
            Assert.IsTrue(DisplaySettingsSection.Displayed);
            Console.WriteLine("DisplaySettingsSection Displayed?: " + DisplaySettingsSection.Displayed);
            Assert.IsTrue(MachLabelsChkBox.Displayed);
            Console.WriteLine("MachLabelsChkBox Displayed?: " + MachLabelsChkBox.Displayed);
            MachLabelsChkBox.Click();
            Utils.WaitBeforeClick(1000);
            LayerSettingsToolCloseIcon.Click();
            Utils.WaitBeforeClick(1000);
            Assert.IsFalse(DisplaySettingsSection.Displayed);
            Console.WriteLine("DisplaySettingsSection Displayed?: " + DisplaySettingsSection.Displayed);
        }


        public void MaterialLabelsFarAwayDefaultSetting()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(LayerSettingsToolIcon.Displayed);
            Console.WriteLine("LayerSettingsToolIcon Displayed?: " + LayerSettingsToolIcon.Displayed);
            LayerSettingsToolIcon.Click();
            Utils.WaitBeforeClick(500);
            Assert.IsTrue(MaterialsSettingsSection.Displayed);
            Console.WriteLine("MaterialsSettingsSection Displayed?: " + MaterialsSettingsSection.Displayed);
            Assert.IsFalse(BlockOutlineChkBoxFarAway.Selected);
            Console.WriteLine("Does the BlockOutlineFarAwayChkBox is Selected by Default?: " + BlockOutlineChkBoxFarAway.Selected);
            Assert.IsFalse(MatLabelsChkBoxFarAway.Selected);
            Console.WriteLine("Does the MaterialLabelsFarAwayChkBox is Selected by Default?: " + MatLabelsChkBoxFarAway.Selected);
        }

        public void MaterialOutlineLabelsFarAwayEnabled()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(LayerSettingsToolIcon.Displayed);
            Console.WriteLine("LayerSettingsToolIcon Displayed?: " + LayerSettingsToolIcon.Displayed);
            LayerSettingsToolIcon.Click();
            Utils.WaitBeforeClick(500);
            Assert.IsTrue(MaterialsSettingsSection.Displayed);
            Console.WriteLine("MaterialsSettingsSection Displayed?: " + MaterialsSettingsSection.Displayed);
            Assert.IsFalse(BlockOutlineChkBoxFarAway.Selected);
            Console.WriteLine("Does the BlockOutlineFarAwayChkBox is Selected by Default?: " + BlockOutlineChkBoxFarAway.Selected);
            BlockOutlineChkBoxFarAway.Click();
            Utils.WaitBeforeClick(500);
            Console.WriteLine("After Selection, BlockOutlineFarAwayChkBox is Now Selected ?: " + BlockOutlineChkBoxFarAway.Displayed);
            Assert.IsFalse(MatLabelsChkBoxFarAway.Selected);
            Console.WriteLine("Does the MaterialLabelsFarAwayChkBox is Selected by Default?: " + MatLabelsChkBoxFarAway.Selected);
            MatLabelsChkBoxFarAway.Click();
            Utils.WaitBeforeClick(500);
            Console.WriteLine("After Selection, MatLabelsChkBoxFarAway is Now Selected ?: " + MatLabelsChkBoxFarAway.Displayed);
            LayerSettingsToolCloseIcon.Click();
            Utils.WaitBeforeClick(1000);
            Console.WriteLine("LayerSettingsToolCloseIcon is Clicked to close the Menu: ");
            Assert.IsFalse(MaterialsSettingsSection.Displayed);
            Console.WriteLine("MaterialsSettingsSection Displayed?: " + MaterialsSettingsSection.Displayed);

        }
        public void MaterialOutlineLabelsNearbyDisable()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(LayerSettingsToolIcon.Displayed);
            Console.WriteLine("LayerSettingsToolIcon Displayed?: " + LayerSettingsToolIcon.Displayed);
            LayerSettingsToolIcon.Click();
            Utils.WaitBeforeClick(500);
            Assert.IsTrue(MaterialsSettingsSection.Displayed);
            Console.WriteLine("MaterialsSettingsSection Displayed?: " + MaterialsSettingsSection.Displayed);
            BlockOutlineChkBoxNearby.Click();
            Utils.WaitBeforeClick(500);
            Assert.IsFalse(BlockOutlineChkBoxNearby.Selected);
            Console.WriteLine("Does the BlockOutlineChkBoxNearby Selected?: " + BlockOutlineChkBoxNearby.Selected);
            MatLabelsChkBoxNearby.Click();
            Utils.WaitBeforeClick(500);
            Assert.IsFalse(MatLabelsChkBoxNearby.Selected);
            Console.WriteLine("Does the MatLabelsChkBoxFarNearby Selected?: " + MatLabelsChkBoxNearby.Selected);
            //Assert.IsTrue(MatLabelsChkBoxFarAway.Selected);
            //Console.WriteLine("Does the MaterialLabelsFarAwayChkBox is Selected Now?: " + MatLabelsChkBoxFarAway.Selected);
            LayerSettingsToolCloseIcon.Click();
            Utils.WaitBeforeClick(1000);
            Console.WriteLine("LayerSettingsToolCloseIcon is Clicked to close the Menu: ");
            Assert.IsFalse(MaterialsSettingsSection.Displayed);
            Console.WriteLine("MaterialsSettingsSection Displayed?: " + MaterialsSettingsSection.Displayed);

        }
        public void MaterialOutlineLabelsNearbyEnable()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(LayerSettingsToolIcon.Displayed);
            Console.WriteLine("LayerSettingsToolIcon Displayed?: " + LayerSettingsToolIcon.Displayed);
            LayerSettingsToolIcon.Click();
            Utils.WaitBeforeClick(500);
            Assert.IsTrue(MaterialsSettingsSection.Displayed);
            Console.WriteLine("MaterialsSettingsSection Displayed?: " + MaterialsSettingsSection.Displayed);
            Assert.IsTrue(BlockOutlineChkBoxNearby.Displayed);
            Console.WriteLine("Does the BlockOutlineChkBoxNearby Displayed by default?: " + BlockOutlineChkBoxNearby.Displayed);
            Assert.IsTrue(MatLabelsChkBoxNearby.Displayed);
            Console.WriteLine("Does the MatLabelsChkBoxFarNearby Displayed by default?: " + MatLabelsChkBoxNearby.Displayed);
            //Assert.IsTrue(MatLabelsChkBoxFarAway.Selected);
            //Console.WriteLine("Does the MaterialLabelsFarAwayChkBox is Selected Now?: " + MatLabelsChkBoxFarAway.Selected);
            LayerSettingsToolCloseIcon.Click();
            Utils.WaitBeforeClick(1000);
            Console.WriteLine("LayerSettingsToolCloseIcon is Clicked to close the Menu: ");
            Assert.IsFalse(MaterialsSettingsSection.Displayed);
            Console.WriteLine("MaterialsSettingsSection Displayed?: " + MaterialsSettingsSection.Displayed);

        }

        public void MaterialLabelsFarAwaySettingsCheck()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //XMLReader reader = new XMLReader(driver);
            //reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            driver.SwitchTo().DefaultContent();
            Utils.WaitBeforeClick(500);
            driver.SwitchTo().Frame(frame);
            Assert.IsTrue(LayerSettingsToolIcon.Displayed);
            Console.WriteLine("LayerSettingsToolIcon Displayed?: " + LayerSettingsToolIcon.Displayed);
            LayerSettingsToolIcon.Click();
            Utils.WaitBeforeClick(500);
            Assert.IsTrue(MaterialsSettingsSection.Displayed);
            Console.WriteLine("MaterialsSettingsSection Displayed?: " + MaterialsSettingsSection.Displayed);
            Assert.IsFalse(BlockOutlineChkBoxFarAway.Selected);
            Console.WriteLine("Does the BlockOutlineFarAwayChkBox is Selected by Default?: " + BlockOutlineChkBoxFarAway.Selected);
            Assert.IsFalse(MatLabelsChkBoxFarAway.Selected);
            Console.WriteLine("Does the MaterialLabelsFarAwayChkBox is Selected by Default?: " + MatLabelsChkBoxFarAway.Selected);
            Actions actions = new Actions(driver);
            actions.MoveToElement(TerrainSurfaceSettingsSection);
            //moving the focus to TerrainSurfaceSettings to have a clear screenshot for the above 2 settings
            actions.Perform();
            Utils.WaitBeforeClick(500);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Using javascript executor to highlight the element to confirm the default settings for the 2 buttons.
            js.ExecuteScript("arguments[0].setAttribute('style', 'background: yellow; border: 2px solid red;');", BlockOutlineChkBoxFarAway);
            js.ExecuteScript("arguments[0].setAttribute('style', 'background: yellow; border: 2px solid red;');", MatLabelsChkBoxFarAway);
        }

        public void MaterialOutlineLabelsFarAwayEnabledAndVerified()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //XMLReader reader = new XMLReader(driver);
            //reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            //driver.SwitchTo().Frame(frame);
            BlockOutlineChkBoxFarAway.Click();
            Utils.WaitBeforeClick(500);
            Console.WriteLine("After Selection, BlockOutlineFarAwayChkBox is Now Selected ?: " + BlockOutlineChkBoxFarAway.Displayed);
            MatLabelsChkBoxFarAway.Click();
            Utils.WaitBeforeClick(500);
            Console.WriteLine("After Selection, MatLabelsChkBoxFarAway is Now Selected ?: " + MatLabelsChkBoxFarAway.Displayed);
            LayerSettingsToolCloseIcon.Click();
            Utils.WaitBeforeClick(1000);
            Console.WriteLine("LayerSettingsToolCloseIcon is Clicked to close the Menu: ");
            Assert.IsFalse(MaterialsSettingsSection.Displayed);
            Console.WriteLine("MaterialsSettingsSection Displayed?: " + MaterialsSettingsSection.Displayed);

        }
    }
}
