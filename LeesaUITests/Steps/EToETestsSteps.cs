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
    public class EToETestsSteps
    {
        public HomePage _home;
        public EnvironmentFixture _environmentFixture;
        public EToETestsSteps(HomePage home, ScenarioContext scenarioContext, EnvironmentFixture environmentFixture)

        {
            _home = home;
            _environmentFixture = environmentFixture;
        }

        
    }
}