using OpenQA.Selenium;

namespace SimpleCalculator.Scenarios.Helpers
{
    public static class WebDriverExtensions
    {
        public static IWebElement Find(this IWebDriver driver, string id)
        {
            IWebElement element = null;

            try
            {
                element = driver.FindElement(By.Id(id));
            }
            catch
            {
                element = new FailedToGetWebElement();
            }

            return element;
        }
    }
}