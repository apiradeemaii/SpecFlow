using Salween.Specs.Base;
using OpenQA.Selenium;

namespace Salween.Specs.Pages
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url
        {
            get
            {
                return "http://www.metric-conversions.org/";
            }
        }
    }
    public partial class HomePage
    {
        public IWebElement EnergyAndPowerAnchor
        {
            get
            {
                return Driver.FindElement(By.XPath("//a[contains(@title,'Energy Conversion')]"));
            }
        }

        public IWebElement KilowattHours
        {
            get
            {
                return Driver.FindElement(By.XPath("//a[contains(text(),'Kilowatt-hours')]"));
            }
        }
    }
}
