using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestStack.BDDfy;

namespace Santander.MvcCalc.FunctionalUITests.Stories
{
    [TestFixture]
    [Story(AsA = "As a user",
          IWant = "I want to do a price calculation",
          SoThat = "I can view the result")]
    public class CalculationStory
    {
        [Test]
        public void SuccessfulPriceCalculation()
        {            
            var calculationTestBuilder = new CalculationTestBuilder();
            
            new CalculationStory().Given(x => calculationTestBuilder.GivenIAmOnTheCalculationPage())
                .And(x => calculationTestBuilder.AndIEnterValidInformation())                                
                .When(x => calculationTestBuilder.WhenIDoPriceCalculation())
                .Then(x => calculationTestBuilder.ThenTheResultShouldBePresented())
                .BDDfy();
        }        

    }
}
