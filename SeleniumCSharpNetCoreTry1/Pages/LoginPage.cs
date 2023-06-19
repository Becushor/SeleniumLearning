using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCoreTry1.Pages
{
    class LoginPage
    {
        private IWebDriver Driver;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement textUserName => Driver.FindElement(By.Id("UserName"));
        IWebElement textPassword => Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => Driver.FindElement(By.CssSelector(".btn-default"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            textUserName.SendKeys(userName);
            textPassword.SendKeys(password);
        }

        public void ClickLogin() => btnLogin.Click();

    }
}
