using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ShovelQA_Pro.Config
{
    public class XMLReader
    {
        IWebDriver driver;
        public XMLReader(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string SiteUrl { get; set; }
        public string DriverPath { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string BaseSS { get; set; }
        public string ActualSS { get; set; }
        public string Screenshots { get; set; }

        public void SetFrameSettings()

        {
            XPathItem siteUrl;
            XPathItem driverpath;
            XPathItem username;
            XPathItem password;
            XPathItem basess;
            XPathItem actualss;
            XPathItem screenshots;

            String strFileName = "C:\\Users\\arasheed\\Documents\\my-app\\Project\\ShovelQA_Pro\\Config\\SettingsFile.xml";
            //Environment.CurrentDirectory.ToString() + "\\Config\\SettingsFile.xml";

            //Read File Content
            FileStream stream = new FileStream(strFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator Navigator = document.CreateNavigator();

            siteUrl = Navigator.SelectSingleNode("ShovelQA_Pro/RunSettings/SiteUrl");
            driverpath = Navigator.SelectSingleNode("ShovelQA_Pro/RunSettings/DriverPath");
            username = Navigator.SelectSingleNode("ShovelQA_Pro/RunSettings/UserName");
            password = Navigator.SelectSingleNode("ShovelQA_Pro/RunSettings/PassWord");
            basess = Navigator.SelectSingleNode("ShovelQA_Pro/RunSettings/BaseSS");
            actualss = Navigator.SelectSingleNode("ShovelQA_Pro/RunSettings/ActualSS");
            screenshots = Navigator.SelectSingleNode("ShovelQA_Pro/RunSettings/Screenshots");

            SiteUrl = siteUrl.ToString();
            DriverPath = driverpath.ToString();
            UserName = username.ToString();
            PassWord = password.ToString();
            BaseSS = basess.ToString();
            ActualSS = actualss.ToString();
            Screenshots = screenshots.ToString();

        }
    }
 }
