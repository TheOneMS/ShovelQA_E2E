using System;
using ShovelQA_Pro.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using ShovelQA_Pro.Utils;
using OpenQA.Selenium.Chrome;
using Org.BouncyCastle.Crypto.Tls;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using WindowsInput;
using WindowsInput.Native;

namespace ShovelQA_Pro.Pages
{
    class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        private IWebElement OPID => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div/div[2]/div/div[1]/input")));
        private IWebElement Tick => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div/div[2]/div/div[2]/div[4]/div[3]")));
        private IWebElement Password => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div/div[2]/div/div[1]/input")));
        //public IWebElement GuideViewOptionsIcon => driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div/div/div/div[3]/button"));
        //private IWebElement TopDownIcon => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[6]/div[1]/div/div/div/div[1]/div[1]/div/button/span[2]")));
        //private IWebElement ZoomInIcon => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[3]/div/div/div/div[1]/button/span[2]")));
        public void start_app()
        {
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            String test_url = reader.SiteUrl;
            driver.Url = test_url;
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void ValidLogin()
        {
            start_app();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();
            Utilities Utils = new Utilities(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            /*
            var sim = new InputSimulator();
            sim.Keyboard
               .TextEntry("GuidanceDemo")
               .Sleep(1000)
               .KeyPress(VirtualKeyCode.TAB)
               .Sleep(1000)
               .TextEntry("GDup#001")
               .Sleep(1000)
               .KeyPress(VirtualKeyCode.TAB)
               .Sleep(1000)
               .KeyPress(VirtualKeyCode.RETURN)
               .Sleep(1000);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            */
            OPID.SendKeys(reader.UserName);
            Utils.WaitBeforeClick(500);
            Tick.Click();
            Utils.WaitBeforeClick(2000);
            Password.SendKeys(reader.PassWord);
            Utils.WaitBeforeClick(500);
            Tick.Click();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            
        }

    }
}
