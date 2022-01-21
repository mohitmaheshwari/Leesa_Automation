using LeesaUITests.Models;
using LeesaUITests.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using Vanuetti.Automation.Framework;
using LeesaUITests.Fixtures;

namespace LeesaUITests.Steps
{
    [Binding]
    public class LoginPageSteps
    {
        public HomePage _home;
        public LoginPage _login;
        public EnvironmentFixture _environmentFixture;
        public LoginPageSteps(HomePage home, ScenarioContext scenarioContext, EnvironmentFixture environmentFixture, LoginPage loginPage)

        {
            _home = home;
            _login = loginPage; 
            _environmentFixture = environmentFixture;
        }

        [Then(@"User is on Login Page")]
        public void ThenUserIsOnLoginPage()
        {
            _home.ClickLoginButton();
        }

        [Then(@"User click on register new account")]
        public void ThenUserClickOnRegisterNewAccount()
        {
            _login.ClickNewAccountButton();
        }

        [Then(@"Verify Create an account is displayed")]
        public void ThenVerifyCreateAnAccountIsDisplayed()
        {
            Assert.IsTrue(_login.VerifyCreateAnAccountIsDisplayed(), "Verify Create An Account Is Displayed");
        }

        [Then(@"User enters registration details '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void ThenUserEntersRegistrationDetails(string firstname, string lastname, string email, string password)
        {
            _login.EnterFirstName(firstname);
            _login.EnterLastName(lastname);
            _login.EnterEmailAddress(email);
            _login.EnterPassword(password);
            _login.ClickRewardProgramCheckbox();
        }

        [Then(@"click on create button")]
        public void ThenClickOnCreateButton()
        {
            _login.ClickCreateButton();
        }

        [Then(@"verify account login is displayed")]
        public void ThenVerifyAccountLoginIsDisplayed()
        {
            Assert.IsTrue(_login.VerifyAccountLoginIsDisplayed(), "Verify Account Login Is Displayed");
        }

        [Then(@"User enters login details '(.*)', '(.*)'")]
        public void ThenUserEntersLoginDetails(string email, string password)
        {
            _login.EnterEmailAddress(email);
            _login.EnterPassword(password);
        }        

        [Then(@"verify user dashboard is displayed")]
        public void ThenVerifyUserDashboardIsDisplayed()
        {
            Assert.IsTrue(_login.VerifyOrderHistoryIsDisplayed(), "Verify Order History Is Displayed");
        }

    }
}