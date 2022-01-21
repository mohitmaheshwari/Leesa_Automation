using System;
using System.Diagnostics;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;

using LeesaUITests.Fixtures;
using LeesaUITests.Pages;
using Serilog.Core;
using TechTalk.SpecFlow;
using Vanuetti.Automation.Framework;
using Vanuetti.Automation.Framework.Report;
using Logger = Vanuetti.Automation.Framework.Logger;

namespace LeesaUITests
{
    [Binding]
    public sealed class Hooks
    {
        public static ExtentTest feature;
        public static ExtentTest scenario;
        private static EnvironmentFixture _environmentFixture;
        private static BasePage basePage;
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioInfo)
        {
            basePage = new BasePage();
            scenario = feature.CreateNode<Feature>(scenarioInfo.ScenarioInfo.Title);
            Report.test = scenario;
            Browser.Instance.InitDriver(_environmentFixture.Environment.Browser);            
            Thread thread = new Thread(() => basePage.HandlePopUp(true))
            {
                IsBackground = true
            };
            thread.Start();
        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureInfo)
        {
            feature = Report.Instance.CreateTest(featureInfo.FeatureInfo.Title);
        }

        [BeforeTestRun]
        public static void RunBeforeAllTests()
        {
            _environmentFixture = new EnvironmentFixture();
            Logger.InitLogging(_environmentFixture.Environment.LogFile);
            Report.Instance.Initialize(_environmentFixture.Environment.HomeUrl);
        }


        [AfterScenario]
        public void AfterScenario(ScenarioContext scenarioInfo)
        {
          //  basePage.HandlePopUp(false);
            Browser.Instance.CloseDriver();
            string status = scenarioInfo.TestError == null ? "Pass" : "Fail";
            Report.Instance.LogTestResult(status);
        }


        [AfterFeature]
        public static void AfterFeature(FeatureContext feature)
        {


        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Report.Instance.Close();
        }
    }
}