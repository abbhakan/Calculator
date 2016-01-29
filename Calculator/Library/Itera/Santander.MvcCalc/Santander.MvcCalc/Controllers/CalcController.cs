using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Santander.CalcApi;
using Santander.MvcCalc.Models;

namespace Santander.MvcCalc.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Exec(double numA, double numB, string mathOp)
        {
            string a = "";
            double res = 0;
            try
            {
                var _calcApi = new CalcApi.CalcApi();

                switch (mathOp)
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
                    default:
                        res = 0.0;
                        break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            var calcViewModel = new CalcViewModel();
            calcViewModel.Result = res;

            return View(calcViewModel);
        }

        
    }
}
