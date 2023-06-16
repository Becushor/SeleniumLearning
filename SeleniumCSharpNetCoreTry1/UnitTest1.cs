using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCoreTry1.Pages;
using System;

namespace SeleniumCSharpNetCoreTry1
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            CustomControl.EnterText(driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Tomato");

            CustomControl.Click(driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));

            CustomControl.SelectByText(driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Broccoli");

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();

            Assert.That(homePage.IsLogOffExist(), Is.True);
        }
    }
}