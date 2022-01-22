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
    public class HomePage : BasePage
    {


        #region Locators

        private By _logo = By.CssSelector("#logo-header");
        private By _navigationMenuBar = By.CssSelector("nav.header-menu.order-none");
        private By _storeIcon = By.CssSelector("a.header-support-button:not([href*='login'])");
        public By _accountIcon = By.CssSelector("a[title='Account Login']");
        private By _cartIcon = By.CssSelector("#shopping-cart-2-line");
        private By _slider = By.CssSelector("div.hero-slider-img");
        private By _affirm = By.CssSelector("div.bg-navy");
        private By _mattressList = By.CssSelector("div.product-list-detailed div.slick-slide");
        private By _otherProducts = By.CssSelector("section.simple-product-list div.slick-slide");
        private By _mattressesMenu = By.CssSelector("ul[aria-label='Desktop navigation'] li[aria-label='Mattresses']");
        private By _navigationMenus = By.CssSelector("nav.header-menu.order-none > ul[aria-label] > li > a");
        private By _navigationMenu(string menu) => By.XPath($"//nav[contains(@class,'header-menu')][contains(@class,'block')]//a[contains(.,'{menu}')]");
        private By _pageHeader(string header) => By.XPath($"//h1[contains(.,'{header}')]");
        private By _menuSubMenus(string menu) => By.XPath($"//nav[contains(@class,'header-menu')][contains(@class,'block')]//a[contains(.,'{menu}')]/following-sibling::div//li[@role='menuitem']");
        #endregion

        #region PageElements

        private Element Logo => browser.FindWebElement(_logo);
        private Element NavigationMenuBar => browser.FindWebElement(_navigationMenuBar);
        private Element StoreIcon => browser.FindWebElement(_storeIcon);
        public Element AccountIcon => browser.FindWebElement(_accountIcon);
        private Element CartIcon => browser.FindWebElement(_cartIcon);
        private MultiElements Slider => browser.FindWebElements(_slider);
        private Element Affirm => browser.FindWebElement(_affirm);
        private MultiElements MattressList => browser.FindWebElements(_mattressList);
        private MultiElements OtherProducts => browser.FindWebElements(_otherProducts);
        private Element MattressesMenu => browser.FindWebElement(_mattressesMenu);
        private MultiElements NavigationMenus => browser.FindWebElements(_navigationMenus);
        private Element NavigationMenu(string menu) => browser.FindWebElement(_navigationMenu(menu));
        private Element PageHeader(string header) => browser.FindWebElement(_pageHeader(header));
        private MultiElements MenuSubMenus(string menu) => browser.FindWebElements(_menuSubMenus(menu));

        #endregion

        #region Methods

        public bool VerifyLogoIsDisplayed()
        {
            return Logo.IsDisplayed();
        }

        public bool VerifyNavigationMenuesIsDisplayed()
        {
            return NavigationMenuBar.IsDisplayed();
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

        public void ClickMattressesMenu()
        {
            MattressesMenu.Click();
        }

        public bool VerifyNavigationMenusAreDisplayed(string menu)
        {
            return NavigationMenu(menu).IsDisplayed();
        }

        public bool VerifyMenusHaveWorkingLinks(string menu)
        {
            NavigationMenu(menu).Click();
            return PageHeader(menu).IsDisplayed();
        }

        public List<string> GetSubMenus(string menu)
        {
            return MenuSubMenus(menu).Text();
        }

     
        public List<string> GetNavigationMenus()
        {
            return NavigationMenus.Select(x => x.GetText()).ToList();
        }   



        #endregion
    }

}