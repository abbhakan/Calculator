using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Santander.MvcCalc.Controllers;
using Santander.MvcCalc.FunctionalUITests.PageObjectModels;
using Santander.MvcCalc.Models;
using NUnit.Framework;
using Santander.MvcCalc.Extensions;

namespace Santander.MvcCalc.FunctionalUITests
{
    [TestFixture]
    class CalculateTests
    {
        [Test]
        public void ValidInputShouldGiveResult()
        {
            // Arrange            
            var calcDetails = new CalcViewModel
            {
                MathOp = EnumMath.Add,
                NumB = 1,
                NumA = 2,
                Result = 3
            };

            // Act
            var calcPage = BrowserHost.Instance.NavigateToInitialPage<CalcController, CalculationPage>(x => x.Index());
            var acceptPage = calcPage.Calculate<CalculationAcceptedPage>(calcDetails);

            // Assert
            var calcSuccessfulResult = acceptPage.CalcAcceptedResult;
            Assert.That(calcSuccessfulResult.Equals(calcDetails.Result));
        }
    }
}
