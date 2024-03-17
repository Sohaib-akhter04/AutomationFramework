using System;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using AventStack.ExtentReports.Reporter;


namespace AutomationDemoTest
{
    
    public class CorePage
    {
       
        // static indicates that it can be accessed without getting initialized
        public static IWebDriver driver;
        public TestContext testContext;
        public static string pathWithFileNameExtension;
        public static string dirpath;
        public static ExtentReports extentreports;
        public static ExtentTest test;
        public static ExtentTest step;

      
        public static void SeleniumInit(string browser) 
        {
            // if(browser=="Chrome")
            // {
            //     var chromeOptions=new ChromeOptions();
            //     chromeOptions.AddArguments("--start-maximized");
            //     chromeOptions.AddArguments("--incognito");
            //     // chromeOptions.AddArguments("");
            //     IWebDriver chromeDriver=new ChromeDriver(chromeOptions);
            //     driver=chromeDriver;
            // }
            // else if(browser=="Firefox")
            // {
            //     FirefoxOptions options=new FirefoxOptions();
            //     options.AddArguments("");
            //     driver=new FirefoxDriver(options);
            // }
            driver=new ChromeDriver();
            
        }
        public static void ClassSelenium()
        {
            driver.Close();
            driver.Dispose();
            driver.Quit();
        }
        public static void Write(By by, string data)
        {
            try{
                driver.FindElement(by).SendKeys(data);
                TakeScreenshot(Status.Pass,data+"Data Entered Successfully");
            }
            catch(Exception e)
            {
                TakeScreenshot(Status.Fail,e.Message);
            }
            
        }
        public void Click(By by)
        {
            try{
                driver.FindElement(by).Click();
                TakeScreenshot(Status.Pass,"Clicked Successfully");
            }
            catch(Exception e){
                TakeScreenshot(Status.Fail,e.Message);
            }
        }
        public void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }
        public void openUrl(string url)
        {
            driver.Url=url;
        }
        public static void CreateReport(string path)
        {
            extentreports=new ExtentReports();
            var sparkReporter= new ExtentSparkReporter(path);
            extentreports.AttachReporter(sparkReporter);
        }
        public static void TakeScreenshot(Status status,string stepDetails)
        {
            string path=@"/home/sohaib/Desktop/Automation Framework/AutomationFramework/images/"+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".png";
            Screenshot screenshot=((ITakesScreenshot)driver).GetScreenshot();
            File.WriteAllBytes(path,screenshot.AsByteArray);
            step.Log(Status.Fail,MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
        }
       
        


    }
}