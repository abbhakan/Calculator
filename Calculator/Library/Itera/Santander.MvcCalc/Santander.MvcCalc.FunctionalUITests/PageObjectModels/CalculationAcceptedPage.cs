using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace Santander.MvcCalc.FunctionalUITests.PageObjectModels
{
    public class CalculationAcceptedPage : Page
    {
        public string CalcAcceptedResult
        {
            get
            {
                return Find.Element(By.Id("Result")).GetAttribute("innerHTML");
            }
        }
    }
}
