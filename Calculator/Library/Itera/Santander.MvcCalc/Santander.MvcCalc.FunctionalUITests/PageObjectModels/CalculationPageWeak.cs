using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using TestStack.Seleno.Extensions;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Controls;

namespace Santander.MvcCalc.FunctionalUITests.PageObjectModels
{
    public class CalculationPageWeak : Page
    {        

        public CalculationPageWeak SetMathOp(string mathOp)
        {
            HtmlControlFor<DropDown>("MathOp").SelectElementByText(mathOp);
            return this;
        }

        public CalculationPageWeak SetNumA(string numA)
        {
            Find.Element(By.Id("NumA")).SendKeys("");
            Find.Element(By.Id("NumA")).SendKeys(numA);
            return this;
        }

        public CalculationPageWeak SetNumB(string numA)
        {
            Find.Element(By.Id("NumB")).SendKeys("");
            Find.Element(By.Id("NumB")).SendKeys(numA);
            return this;
        }


        public T Calculate<T>() where T : UiComponent, new()
        {
            return Navigate.To<T>(By.Id("submit"));
        }



    }
}