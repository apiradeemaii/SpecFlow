using OpenQA.Selenium;
using Salween.Specs.Base;

namespace Salween.Specs.Pages
{
    public partial class KilowattHoursPage : BasePage
    {
        public KilowattHoursPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url
        {
            get
            {
                return "http://www.metric-conversions.org/temperature/celsius-to-fahrenheit.htm";
            }
        }

        public void ConvertKilowattHoursToNewtonMeters(double kWh)
        {
            CelsiusInput.SendKeys(kWh.ToString());
            DriverWait.Until(drv => Answer != null);
        }
    }
    public partial class KilowattHoursPage
    {
        public IWebElement CelsiusInput
        {
            get
            {
                return Driver.FindElement(By.Id("argumentConv"));
            }
        }

        public IWebElement Answer
        {
            get
            {
                return Driver.FindElement(By.Id("answer"));
            }
        }

        public IWebElement KilowatHoursToNewtonMetersAnchor
        {
            get
            {
                return Driver.FindElement(By.XPath("//a[contains(text(),'Kilowatt-hours to Newton-meters')]"));
            }
        }
    }

}
