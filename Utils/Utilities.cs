using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Data.SqlClient;
using ShovelQA_Pro.Pages;
using System.IO;
using ShovelQA_Pro.Config;
using System.Data;
using System.Drawing;
using GroupDocs.Comparison;
using GroupDocs.Comparison.Options;
using GroupDocs.Comparison.Result;
using FileInfo = System.IO.FileInfo;

namespace ShovelQA_Pro.Utils
{
    class Utilities
    {
        private IWebDriver driver;

        public String DBResultCount = "";
        public StyleSettings InsertedItemStyle { get; set; }
        public StyleSettings DeletedItemStyle { get; set; }
        public StyleSettings ChangedItemStyle { get; set; }

        public Utilities(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TakeScreenshot(String TestFixtureName, String TestNameFolder, String SSName)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));

            try
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                XMLReader reader = new XMLReader(driver);
                reader.SetFrameSettings();

                String Screenshots = reader.Screenshots;
                String AbsScreenshotsPath = Path.Combine(Screenshots, TestFixtureName);
                String FinalScreenshotsPath = Path.Combine(AbsScreenshotsPath, TestNameFolder);

                /*
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                */

                Directory.CreateDirectory(FinalScreenshotsPath);
                System.IO.DirectoryInfo di = new DirectoryInfo(FinalScreenshotsPath);

                String ActualLocation = FinalScreenshotsPath + "/" + SSName + DateTime.Now.ToString("_dd-MM-yyyy hh.mm.ss") + ".jpg";
                ss.SaveAsFile(ActualLocation);

                /*
                using (Comparer comparer = new Comparer(BaseLocation))
                {
                    CompareOptions options = new CompareOptions();
                    options.GenerateSummaryPage = true; // To get the difference summary, set it 'true'

                    comparer.Add(ActualLocation);
                    comparer.Compare(FinalActualPath + "/" + input + DateTime.Now.ToString("_dd- MM-yyyy hh.mm.ss") + "_diff" + ".jpg", options);
                }
                */

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }


        public void DoVisualRegression(String TestFixtureName, String TestNameFolder, String SSName)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));

            try
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                XMLReader reader = new XMLReader(driver);
                reader.SetFrameSettings();

                String Base = reader.BaseSS;
                String Actual = reader.ActualSS;
                String AbsBasePath = Path.Combine(Base, TestFixtureName);
                String FinalBasePath = Path.Combine(AbsBasePath, TestNameFolder);
                String AbsActualPath = Path.Combine(Actual, TestFixtureName);
                String FinalActualPath = Path.Combine(AbsActualPath, TestNameFolder);

                Directory.CreateDirectory(FinalActualPath);
                System.IO.DirectoryInfo di = new DirectoryInfo(FinalActualPath);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }

                Directory.CreateDirectory(FinalBasePath);
                String BaseLocation = FinalBasePath + "/" + SSName + ".PNG";


                if (Directory.GetFiles(FinalBasePath).Length == 0)
                {

                    ss.SaveAsFile(BaseLocation);
                }



                String ActualLocation = FinalActualPath + "/" + SSName + DateTime.Now.ToString("_dd-MM-yyyy hh.mm.ss") + ".PNG";
                String DiffLocation = FinalActualPath + "/" + SSName + DateTime.Now.ToString("_dd-MM-yyyy hh.mm.ss") + "_diff" + ".PNG";

                ss.SaveAsFile(ActualLocation);



                // Compare JPG, PNG, GIF, BMP image formats using .NET Image Comparison API in C#
                using (Comparer comparer = new Comparer(BaseLocation))
                {
                    comparer.Add(ActualLocation);

                    CompareOptions compareOptions = new CompareOptions()
                    {
                        /*
                        InsertedItemStyle = new StyleSettings()
                        {
                            HighlightColor = System.Drawing.Color.Yellow,
                            FontColor = System.Drawing.Color.Yellow,
                            IsUnderline = true,
                            IsBold = true,
                            IsStrikethrough = true,
                            IsItalic = true
                        },

                        DeletedItemStyle = new StyleSettings()
                        {
                            HighlightColor = System.Drawing.Color.Orange,
                            FontColor = System.Drawing.Color.Orange,
                            IsUnderline = true,
                            IsBold = true,
                            IsStrikethrough = true,
                            IsItalic = true
                        },
                        */

                        ChangedItemStyle = new StyleSettings()
                        {
                            HighlightColor = System.Drawing.Color.Red,
                            FontColor = System.Drawing.Color.Red,
                            IsUnderline = true,
                            IsBold = true,
                            IsStrikethrough = true,
                            IsItalic = true
                        }

                    };
                    compareOptions.GenerateSummaryPage = false; // To get the difference summary, set it 'true'
                    comparer.Compare(DiffLocation, compareOptions);
                    ChangeInfo[] changes = comparer.GetChanges();

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void DoCaptureBaseSS(String TestFixtureName, String TestNameFolder, String SSName)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));

            try
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                XMLReader reader = new XMLReader(driver);
                reader.SetFrameSettings();

                String Base = reader.BaseSS;
                String Actual = reader.ActualSS;
                String AbsBasePath = Path.Combine(Base, TestFixtureName);
                String FinalBasePath = Path.Combine(AbsBasePath, TestNameFolder);
                String AbsActualPath = Path.Combine(Actual, TestFixtureName);
                String FinalActualPath = Path.Combine(AbsActualPath, TestNameFolder);


                Directory.CreateDirectory(FinalBasePath);
                System.IO.DirectoryInfo di = new DirectoryInfo(FinalBasePath);

                //foreach (FileInfo file in di.GetFiles())
                //{
                //    file.Delete();
                //}
                String BaseLocation = FinalBasePath + "/" + SSName + ".PNG";

                if (Directory.GetFiles(FinalBasePath).Length == 0)
                {

                    ss.SaveAsFile(BaseLocation);
                }
                //ss.SaveAsFile(BaseLocation);
                //Console.WriteLine(BaseLocation);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void DoCaptureActualAndCompareBaseSS(String TestFixtureName, String TestNameBaseFolder, String TestNameFolder, String SSBaseName, String SSName)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));

            try
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                XMLReader reader = new XMLReader(driver);
                reader.SetFrameSettings();

                String Base = reader.BaseSS;
                String Actual = reader.ActualSS;
                String AbsBasePath = Path.Combine(Base, TestFixtureName);
                String FinalBasePath = Path.Combine(AbsBasePath, TestNameBaseFolder);
                String AbsActualPath = Path.Combine(Actual, TestFixtureName);
                String FinalActualPath = Path.Combine(AbsActualPath, TestNameFolder);

                Directory.CreateDirectory(FinalActualPath);
                System.IO.DirectoryInfo di = new DirectoryInfo(FinalActualPath);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }

                String BaseLocation = FinalBasePath + "/" + SSBaseName + ".PNG";
                //Console.WriteLine("Path for Base SS to do Actual Comparison: "+ BaseLocation);

                String ActualLocation = FinalActualPath + "/" + SSName + DateTime.Now.ToString("_dd-MM-yyyy hh.mm.ss") + ".PNG";
                String DiffLocation = FinalActualPath + "/" + SSName + DateTime.Now.ToString("_dd-MM-yyyy hh.mm.ss") + "_diff" + ".PNG";

                ss.SaveAsFile(ActualLocation);



                // Compare JPG, PNG, GIF, BMP image formats using .NET Image Comparison API in C#
                using (Comparer comparer = new Comparer(BaseLocation))
                {
                    comparer.Add(ActualLocation);

                    CompareOptions compareOptions = new CompareOptions()
                    {
                        /*
                        InsertedItemStyle = new StyleSettings()
                        {
                            HighlightColor = System.Drawing.Color.Yellow,
                            FontColor = System.Drawing.Color.Yellow,
                            IsUnderline = true,
                            IsBold = true,
                            IsStrikethrough = true,
                            IsItalic = true
                        },

                        DeletedItemStyle = new StyleSettings()
                        {
                            HighlightColor = System.Drawing.Color.Orange,
                            FontColor = System.Drawing.Color.Orange,
                            IsUnderline = true,
                            IsBold = true,
                            IsStrikethrough = true,
                            IsItalic = true
                        },
                        */

                        ChangedItemStyle = new StyleSettings()
                        {
                            HighlightColor = System.Drawing.Color.Red,
                            FontColor = System.Drawing.Color.Red,
                            IsUnderline = true,
                            IsBold = true,
                            IsStrikethrough = true,
                            IsItalic = true
                        }

                    };
                    compareOptions.GenerateSummaryPage = false; // To get the difference summary, set it 'true'
                    comparer.Compare(DiffLocation, compareOptions);
                    ChangeInfo[] changes = comparer.GetChanges();

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public void MeasurePerformance()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Stopwatch stopwatch = Stopwatch.StartNew();
            var startime = Convert.ToInt64(js.ExecuteScript("window.performance.timing.navigationStart"));
            var endtime = Convert.ToInt64(js.ExecuteScript("return window.performance.timing.domContentLoadedEventEnd"));
            var ResponseTime = startime - endtime;
            //Console.WriteLine("Search loading time in Secs", +ResponseTime);
            stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
        public IWebElement WaitAndFindElement(By by)
        {
            var webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
        }

        /*
        public void ConnectDB(String sql)
        {
            string connetionString;
            XMLReader reader = new XMLReader(driver);
            reader.SetFrameSettings();

            SqlConnection cnn;
            connetionString = @"Data Source= " + reader.DataSource + ";Initial Catalog=" + reader.DBName + ";User ID=" + reader.DBUserID + ";Password=" + reader.DBPassWord + "";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader datareader;

            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                DBResultCount = datareader[0].ToString();

            }
            cnn.Close();
        }
        */

        public void WaitBeforeClick(int millisecondsToWait)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (true)
            {
                if (stopwatch.ElapsedMilliseconds >= millisecondsToWait)
                {
                    break;
                }
            }
        }

        /*public void WaitForSearchComplete()
        {
            SearchPage search_page = new SearchPage(driver);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
                wait.Until(d => Int16.Parse(search_page.CounterText.Text, System.Globalization.NumberStyles.AllowThousands) < 20_031);
            }

            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }


        }
        */

        public void GImgComp1(String BaseLocation, String ActualLocation, String DiffLocation)
        {
            // Compare JPG, PNG, GIF, BMP image formats using .NET Image Comparison API in C#
            using (Comparer comparer = new Comparer(BaseLocation))
            {
                CompareOptions options = new CompareOptions();
                options.GenerateSummaryPage = false; // To get the difference summary, set it 'true'

                comparer.Add(ActualLocation);
                comparer.Compare(DiffLocation, options);

            }

        }

    }

}
