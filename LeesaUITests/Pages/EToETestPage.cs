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
    public class EToETestPage : BasePage
    {


        #region Locators

        private By _mattresses = By.XPath("//h1[contains(.,'Mattresses')]");
        private By _originalMattress = By.CssSelector("img[alt='Original Mattress']");
        private By _originalMattressText = By.XPath("//h1[contains(.,'Original Mattress')]");
        private By _twinSize = By.CssSelector("#radio-Twin");
        private By _addABase = By.XPath("//button[contains(.,'Add a base')]");
        private By _addToCart = By.CssSelector("#AddToCart");
        private By _base = By.CssSelector("#cross-sell-item-0");
        private By _checkoutBtn = By.XPath("//span[contains(.,'Checkout')]");

        #endregion

        #region PageElements

        private Element Mattresses => browser.FindWebElement(_mattresses);
        private Element OriginalMattress => browser.FindWebElement(_originalMattress);
        private Element OriginalMattressText => browser.FindWebElement(_originalMattressText);
        private Element TwinSize => browser.FindWebElement(_twinSize);
        private Element AddABase => browser.FindWebElement(_addABase);
        private Element AddToCart => browser.FindWebElement(_addToCart);
        private Element Base => browser.FindWebElement(_base);
        private Element CheckoutBtn => browser.FindWebElement(_checkoutBtn);

        #endregion

        #region Methods

        public bool VerifyMattressesIsDisplayed()
        {
            return Mattresses.IsDisplayed();
        }

        public void ClickOriginalMattress()
        {
            OriginalMattress.Click();
        }

        public bool VerifyOriginalMattressTextIsDisplayed()
        {
            return OriginalMattressText.IsDisplayed();
        }

        public void ClickTwinSize()
        {
            TwinSize.Click();
        }

        public void ClickAddABase()
        {
            AddABase.Click();
        }

        public void ClickAddToCart()
        {
            AddToCart.Click();
        }

        public void SelectBase()
        {
            Base.Click();
        }

        public void ClickCheckoutBtn()
        {
            CheckoutBtn.Click();
        }

        #endregion
    }

}