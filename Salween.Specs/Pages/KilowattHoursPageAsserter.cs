using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Salween.Specs.Pages
{
    public static class KilowattHoursPageAsserter
    {
        public static void AssertFahrenheit(this KilowattHoursPage page, string expectedNewtonMeters)
        {
            Assert.IsTrue(page.Answer.Text.Contains(string.Format("{0}Nm", expectedNewtonMeters)));
        }
    }
}
