using System;
using System.Text;

using LeesaUITests.Fixtures;
using LeesaUITests.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using Vanuetti.Automation.Framework;

using System.Linq;
using System.Collections.Generic;

namespace LeesaUITests.Pages
{
    public class LoginPage : BasePage
    {
        #region Locators

        private By _newAccount = By.XPath("//a[contains(.,'Register New Account')]");
        private By _createAnAccount = By.XPath("//h1[contains(.,'Create an Account')]");
        private By _firstName = By.CssSelector("input[placeholder = 'First Name']");
        private By _lastName = By.CssSelector("input[placeholder = 'Last Name']");
        private By _emailAddress = By.CssSelector("input[placeholder = 'Email Address']");
        private By _password = By.CssSelector("input[placeholder = 'Password']");
        private By _rewardProgramCheckbox = By.CssSelector("input[type= 'checkbox']");
        private By _createButton = By.CssSelector("input[type= 'submit']");
        private By _accountLogin = By.XPath("//h1[contains(.,'Account Login')]");
        private By _orderHistory = By.XPath("//h1[contains(.,'Order History')]");

        #endregion

        #region PageElements

        private Element NewAccount => browser.FindWebElement(_newAccount);
        private Element CreateAnAccount => browser.FindWebElement(_createAnAccount);
        private TextBoxElement FirstName => browser.FindTextBox(_firstName);
        private TextBoxElement LastName => browser.FindTextBox(_lastName);
        private TextBoxElement EmailAddress => browser.FindTextBox(_emailAddress);
        private TextBoxElement Password => browser.FindTextBox(_password);
        private CheckboxElement RewardProgramCheckbox => browser.FindCheckBox(_rewardProgramCheckbox);
        private Element CreateButton => browser.FindWebElement(_createButton);
        private Element AccountLogin => browser.FindWebElement(_accountLogin);
        private Element OrderHistory => browser.FindWebElement(_orderHistory);

        #endregion

        #region Methods        

        public void ClickNewAccountButton()
        {
            NewAccount.Click();
        }

        public bool VerifyCreateAnAccountIsDisplayed()
        {
            return CreateAnAccount.IsDisplayed();
        }

        public void EnterFirstName(string firstName)
        {
            FirstName.EnterText(firstName);
        }

        public void EnterLastName(string lastName)
        {
            LastName.EnterText(lastName);
        }

        public void EnterEmailAddress(string email)
        {
            EmailAddress.EnterText(email);
        }

        public void EnterPassword(string password)
        {
            Password.EnterText(password);
        }

        public void ClickRewardProgramCheckbox()
        {
            RewardProgramCheckbox.Click();
        }

        public void ClickCreateButton()
        {
            CreateButton.Click();
        }

        public bool VerifyAccountLoginIsDisplayed()
        {
            return AccountLogin.IsDisplayed();
        }

        public bool VerifyOrderHistoryIsDisplayed()
        {
            return OrderHistory.IsDisplayed();
        }

        #endregion
    }
}