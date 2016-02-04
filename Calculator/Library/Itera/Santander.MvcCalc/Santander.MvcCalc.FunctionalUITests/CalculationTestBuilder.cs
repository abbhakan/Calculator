using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Santander.MvcCalc.Controllers;
using Santander.MvcCalc.FunctionalUITests.PageObjectModels;
using TestStack.BDDfy;

namespace Santander.MvcCalc.FunctionalUITests
{
    public class CalculationTestBuilder
    {
        private CalculationPageWeak _priceCalculationPage;
        private CalculationAcceptedPage _priceCalculationAcceptedPage;

        public void GivenIAmOnTheCalculationPage()
        {
            _priceCalculationPage =
                BrowserHost.Instance.NavigateToInitialPage<CalcController, CalculationPageWeak>(
                    x => x.Index());
        }

        public void AndIEnterValidInformation()
        {
            _priceCalculationPage.SetNumA("1");
            _priceCalculationPage.SetNumB("2");
            _priceCalculationPage.SetMathOp("Mult");            
        }        

        public void WhenIDoPriceCalculation()
        {
            _priceCalculationAcceptedPage = _priceCalculationPage.Calculate<CalculationAcceptedPage>();
        }        

        public void ThenTheResultShouldBePresented()
        {
            var result = _priceCalculationAcceptedPage.CalcAcceptedResult;
            Assert.That(result.Equals("2"));
        }        
    }
}
