using System;
using OpenQA.Selenium;

namespace AutomationDemoTest
{
    class LoginPage :CorePage
    {
        By usernameTxt=By.Id("username");
        By passwordTxt=By.Id("password");
        By loginBtn=By.Id("login");
        public void Login(string url, string username, string password)
        {
            
            // driver.Url = url;
            // driver.FindElement(usernameTxt).SendKeys(username);
            // driver.FindElement(By.Id("password")).SendKeys(password);
            // driver.FindElement(By.Id("login")).Click();
            step=test.CreateNode("LoginPage");
            openUrl(url);
            Write(usernameTxt,username);
            Write(passwordTxt,password);
            Click(loginBtn);

        }
    }
}