﻿using NUnit.Framework;
using SeleniumCSharpNetCoreTry1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCoreTry1.Steps
{
    [Binding]
    class LoginSteps
    {
        private DriverHelper _driverHelper;
        HomePage homePage;
        LoginPage loginPage;

        public LoginSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;

            homePage = new HomePage(_driverHelper.Driver);
            loginPage = new LoginPage(_driverHelper.Driver);
        }


        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driverHelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            homePage.ClickLogin();
        }


        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUserNameAndPassword(data.UserName, data.Password);

        }

        [Given(@"I click Login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Assert.That(homePage.IsLogOffExist(), Is.True);
        }
    }
}
