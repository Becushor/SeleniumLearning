using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCoreTry1.Pages
{
    class LoginPage : DriverHelper
    {
        IWebElement textUserName => driver.FindElement(By.Id("UserName"));
        IWebElement textPassword => driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => driver.FindElement(By.CssSelector(".btn-default"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            textUserName.SendKeys(userName);
            textPassword.SendKeys(password);
        }

        public void ClickLogin() => btnLogin.Click();

    }
}
