using OpenQA.Selenium;
using SimpleCalculator.Scenarios.Helpers;
using System;

namespace SimpleCalculator.Scenarios.Models
{
    public interface IButtonsModel
    {
        IWebElement Exponent { get; }
        IWebElement Multiply { get; }
        IWebElement Divide { get; }
        IWebElement Add { get; }
        IWebElement Subtract { get; }
        IWebElement OpenParenthesis { get; }
        IWebElement ClosedParenthesis { get; }
        IWebElement Equal { get; }
        IWebElement DecimalPoint { get; }
        IWebElement GetDigit(int n);
    }


    public class ButtonsModel : BaseWebModel, IButtonsModel
    {
        public ButtonsModel(IWebDriver driver) : base(driver) { }

        public IWebElement Add
        {
            get
            {
                return driver.Find("button_add");
            }
        }

        public IWebElement ClosedParenthesis
        {
            get
            {
                return driver.Find("button_closed_parenthesis");
            }
        }

        public IWebElement DecimalPoint
        {
            get
            {
                return driver.Find("button_decimal_point");
            }
        }

        public IWebElement Divide
        {
            get
            {
                return driver.Find("button_divide");
            }
        }

        public IWebElement Exponent
        {
            get
            {
                return driver.Find("button_exponent");
            }
        }

        public IWebElement Multiply
        {
            get
            {
                return driver.Find("button_multiply");
            }
        }

        public IWebElement OpenParenthesis
        {
            get
            {
                return driver.Find("button_open_parenthesis");
            }
        }

        public IWebElement Subtract
        {
            get
            {
                return driver.Find("button_subtract");
            }
        }

        public IWebElement Equal
        {
            get
            {
                return driver.Find("button_equal");
            }
        }

        public IWebElement GetDigit(int n)
        {
            if (n < 0 || n > 9)
                throw new ArgumentOutOfRangeException("n", n, "Digit should be within the range 0-9!");

            string digitId = string.Format("button_digit_{0}", n);
            return driver.Find(digitId);
        }
    }
}