using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Santander.MvcCalc.Models;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Santander.MvcCalc.FunctionalUITests.PageObjectModels
{
    public class CalculationPage : Page<CalcViewModel>
    {
        public T Calculate<T>(CalcViewModel calculationViewModel) where T : UiComponent, new()
        {
            Input.Model(calculationViewModel);
            return Navigate.To<T>(By.ClassName("btn btn-primary"));
        }
    }
}
