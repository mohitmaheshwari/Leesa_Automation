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
    public class CheckoutPage : BasePage
    {


        #region Locators
       
        #endregion

        #region Methods

        public bool VerifyLogoIsDisplayed()
        {
            return Logo.IsDisplayed();
        }

        public bool VerifyNavigationMenuesIsDisplayed()
        {
            return NavigationMenues.IsDisplayed();
        }

        public bool VerifyStoreIconIsDisplayed()
        {
            return StoreIcon.IsDisplayed();
        }

        public bool VerifyAccountIconIsDisplayed()
        {
            return AccountIcon.IsDisplayed();
        }

        public bool VerifyCartIconIsDisplayed()
        {
            return CartIcon.IsDisplayed();
        }

        public bool VerifySliderIsDisplayed()
        {
            return Slider.Any(x => x.IsDisplayed());
        }

        public bool VerifyAffirmIsDisplayed()
        {
            return Affirm.IsDisplayed();
        }

        public bool VerifyMattressListIsDisplayed()
        {
            return MattressList.All(x=>x.IsDisplayed());
        }

        public bool VerifyOtherProductListIsDisplayed()
        {
            return OtherProducts.All(x => x.IsDisplayed());
        }

        public void ClickLoginButton()
        {
            AccountIcon.Click();
        }

        #endregion
    }

}