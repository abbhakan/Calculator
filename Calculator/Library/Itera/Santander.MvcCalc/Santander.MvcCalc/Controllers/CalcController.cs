using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Santander.CalcApi;
using Santander.MvcCalc.Models;

namespace Santander.MvcCalc.Controllers
{    

    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {            
            return View(new CalcViewModel());
        }

        [HttpPost]        
        public ActionResult Index(CalcViewModel calcViewModel)
        {
            var a = "f";   
            double res = 0;
            try
            {
                var _calcApi = new CalcApi.CalcApi();
                var numA = calcViewModel.NumA;
                var numB = calcViewModel.NumB;

                switch (calcViewModel.MathOp.ToString())
                {
                    case "Add":
                        res = _calcApi.Add(numA, numB);
                        break;
                    case "Sub":
                        res = _calcApi.Subtract(numA, numB);
                        break;
                    case "Div":
                        res = _calcApi.Divide(numA, numB);
                        break;
                    case "Mult":
                        res = _calcApi.Multiply(numA, numB);
                        break;
                    case "Mod":
                        res = _calcApi.Modulo(numA, numB);
                        break;
                    default:
                        res = 0.0;
                        break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            calcViewModel.Result = res;
            return View("Result", calcViewModel);
        }

        
    }
}
