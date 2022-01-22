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
    public class HomePageSteps
    {
        public HomePage _home;
        public EnvironmentFixture _environmentFixture;
        public HomePageSteps(HomePage home, ScenarioContext scenarioContext, EnvironmentFixture environmentFixture)

        {
            _home = home;
            _environmentFixture = environmentFixture;
        }

        [Given(@"User lands on Leesa Website")]
        public void GivenUserLandsOnLeesaWebsite()
        {
            _home.NavigateToURL(_environmentFixture.Environment.HomeUrl);
        }

        [Then(@"Verify Leesa Logo is displaying")]
        public void ThenVerifyLeesaLogoIsDisplaying()
        {
            Assert.IsTrue(_home.VerifyLogoIsDisplayed(), "Verify Logo Is Displayed");
        }

        [Then(@"Verify Navigation Menu is displaying")]
        public void ThenVerifyNavigationMenuIsDisplaying()
        {
            Assert.IsTrue(_home.VerifyNavigationMenuesIsDisplayed(), "Verify Navigation Menues Are Displayed");
        }

        [Then(@"Verify Store Icon is displaying")]
        public void ThenVerifyStoreIconIsDisplaying()
        {
            Assert.IsTrue(_home.VerifyStoreIconIsDisplayed(), "Verify Store Icon Is Displayed");
        }

        [Then(@"Verify Account Icon is displaying")]
        public void ThenVerifyAccountIconIsDisplaying()
        {
            Assert.IsTrue(_home.VerifyAccountIconIsDisplayed(), "Verify Account Icon Is Displayed");
        }

        [Then(@"Verify Cart Icon is displaying")]
        public void ThenVerifyCartIconIsDisplaying()
        {
            Assert.IsTrue(_home.VerifyCartIconIsDisplayed(), "Verify Cart Icon Is Displayed");
        }

        [Then(@"Verify Slider image is displaying")]
        public void ThenVerifySliderImageIsDisplaying()
        {
            Assert.IsTrue(_home.VerifySliderIsDisplayed(), "Verify Slider Is Displayed");
        }

        [Then(@"Verify Financing with Affirm is displaying")]
        public void ThenVerifyFinancingWithAffirmIsDisplaying()
        {
            Assert.IsTrue(_home.VerifyAffirmIsDisplayed(), "Verify Financing with Affirm Is Displayed");
        }

        [Then(@"Verify Mattress List is displaying")]
        public void ThenVerifyMattressListIsDisplaying()
        {
            Assert.IsTrue(_home.VerifyMattressListIsDisplayed(), "Verify Mattress List Is Displayed");
        }

        [Then(@"Verify other Products are displaying")]
        public void ThenVerifyOtherProductsAreDisplaying()
        {
            Assert.IsTrue(_home.VerifyOtherProductListIsDisplayed(), "Verify Other Products List Is Displayed");
        }

        [Then(@"Verify for Menus and validate TopMenus  are showing")]
        public void ThenVerifyForMenusAndValidateTopMenusAreShowing()
        {
            List<string> menus = _home.GetNavigationMenus();
            foreach (var menu in menus)
            {
                Assert.IsTrue(_home.VerifyMenusHaveWorkingLinks(menu));
                List<string> subMenus = _home.GetSubMenus(menu);
                foreach(var subMenu in subMenus)
                {
                    Assert.IsTrue(_home.VerifyMenusHaveWorkingLinks(subMenu));
                }
            }
        }

    }
}