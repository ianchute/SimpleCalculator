using OpenQA.Selenium;

namespace SimpleCalculator.Scenarios.Models
{
    public interface INavigator
    {
        void GoToHomePage();
    }

    public class Navigator : BaseWebModel, INavigator
    {
        public Navigator(IWebDriver driver) : base(driver) { }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost:8888/");
        }
    }
}