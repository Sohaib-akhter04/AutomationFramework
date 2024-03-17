// dotnet new mstest -n MyUnitTestProject command to create the project
namespace AutomationFramework;
using System;
using AutomationDemoTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Xml;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class TestExecution : CorePage
{
   
    #region Setups and Cleanups
    public TestContext instance;
    public TestContext TestContext
    {
        set { instance = value; }
        get { return instance; }
    }
    [AssemblyInitialize()]
    public static void AssemblyInit(TestContext context)
    {
        string ResultFile=@"/home/sohaib/Desktop/Automation Framework/AutomationFramework/"+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".html";
        CreateReport(ResultFile);
    }
    [AssemblyCleanup()]
    public static void AssemblyCleanup()
    {
        extentreports.Flush();
    }
    [ClassInitialize()]
    public static void ClassInit(TestContext context)
    {

    }
    [ClassCleanup()]
    public static void ClassCleanup()
    {

    }
    [TestInitialize()]
    public void TestInit()
    {
        // var ExecutionBrowser=CorePage.SeleniumInit(ConfigurationManager.AppSettings["Browser"].ToString());
        CorePage.SeleniumInit("Chrome");
        test=extentreports.CreateTest(TestContext.TestName);


    }
    [TestCleanup()]
    public void TestCleanup()
    {
        CorePage.driver.Quit();
    }
    #endregion
    LoginPage loginPage = new LoginPage();
    SearchPage searchPage = new SearchPage();
    SelectPage selectPage = new SelectPage();
    BookPage bookpage = new BookPage();
    // IWebDriver driver = new ChromeDriver();
    [TestMethod]
    public void LoginWithValidCred_TC001()
    {

        loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
        string actualText = CorePage.driver.FindElement(By.ClassName("welcome_menu")).Text;
        Assert.AreEqual("Welcome to Adactin Group of Hotels", actualText);

    }
    [TestMethod]
    public void LoginWithInvalidCred_TC002()
    {

        loginPage.Login("https://adactinhotelapp.com/", "AmirTester123", "AmirTester123");
        string actualText = CorePage.driver.FindElement(By.ClassName("auth_error")).Text;
        Assert.AreEqual("Invalid Login details or Your Password might have expired. Click here to reset your password", actualText);

    }
    [TestMethod]
    public void SearchHotel_TC001()
    {

        loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
        searchPage.SearchHotel();

    }

    [TestMethod]
    public void SelectHotel_TC001()
    {

        loginPage.Login("https://adactinhotelapp.com/", "AmirTester", "AmirTester");
        searchPage.SearchHotel();
        selectPage.SelectHotel();

    }
    [TestMethod]
    // [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML","Data.xml","BookNow_TC001",DataAccessMethod.Sequential)]
    public void BookNow_TC001()
    {
        string filePath = "Data.xml";
        var xmlDoc = new XmlDocument();
        xmlDoc.Load(filePath);
        var executionNode = xmlDoc.SelectSingleNode("//Execution");
        foreach (XmlNode BookNow_TC001 in executionNode.SelectNodes("BookNow_TC001"))
        {
            var urlNode = BookNow_TC001.SelectSingleNode("url");
            var userNode = BookNow_TC001.SelectSingleNode("username");
            var passNode = BookNow_TC001.SelectSingleNode("password");
            string url = urlNode.InnerText;
            string user = userNode.InnerText;
            string pass = passNode.InnerText;
            loginPage.Login(url, user, pass);
            searchPage.SearchHotel();
            selectPage.SelectHotel();
            bookpage.Bookpage();
        }



    }

}