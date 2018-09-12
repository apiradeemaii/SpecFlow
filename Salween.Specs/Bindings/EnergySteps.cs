using System;
using TechTalk.SpecFlow;
using Salween.Specs.Core;
using Salween.Specs.Pages;

namespace Salween.Specs.Bindings
{
    [Binding]
    public class EnergySteps
    {
        private HomePage _homePage;
        private KilowattHoursPage _kilowattHoursPage;

        [Given(@"Web browser is opened")]
        public void GivenWebBrowserIsOpened()
        {
            Driver.StartBrowser(BrowserTypes.Chrome);
        }

        [When(@"I navigate to Matric conversions\.")]
        public void WhenINavigateToMatricConversions_()
        {
            _homePage = new HomePage(Driver.Browser);
            _homePage.Open();
        }

        [When(@"I navigate to Energy and power section")]
        public void WhenINavigateToEnergyAndPowerSection()
        {
            _homePage.EnergyAndPowerAnchor.Click();
        }

        [When(@"I navigate to Kilowatt-hours")]
        public void WhenINavigateToKilowatt_Hours()
        {
            _homePage.KilowattHours.Click();
        }

        [When(@"choose conversions to Newton-meters")]
        public void WhenChooseConversionsToNewton_Meters()
        {
            _kilowattHoursPage = new KilowattHoursPage(Driver.Browser);
            _kilowattHoursPage.KilowatHoursToNewtonMetersAnchor.Click();
        }

        [When(@"type (.*) KWh")]
        public void WhenTypeKWh(int kWh)
        {
            _kilowattHoursPage.ConvertKilowattHoursToNewtonMeters(kWh);
        }
 
        [Then(@"Close web browser")]
        public void ThenCloseWebBrowser()
        {
            Driver.StopBrowser();
        }
 
        [Then(@"assert that (.*) Nm are displayed as answer")]
        public void ThenAssertThatENmAreDisplayedAsAnswer(string expectedNewtonMeters)
        {
            _kilowattHoursPage.AssertFahrenheit(expectedNewtonMeters);
        }
    }
}
