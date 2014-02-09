using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Santander.CalcApi;

namespace Santander.WebApiCalc.Models
{
    public class ResultManager : IResultManager
    {
        private ICalcApi _calcApi;

        public ResultManager()
        {
            this._calcApi = new CalcApi.CalcApi();
        }

        public ResultModel Execute(double numA, double numB, string mathOp)
        {
            try
            {
                double res;
                ResultModel resultModel;

                switch (mathOp)
                {
                    case "Add":
                        res = _calcApi.Add(numA, numB);                        
                        break;
                    case "Subtract":
                        res = _calcApi.Subtract(numA, numB);                        
                        break;
                    case "Divide":
                        res = _calcApi.Divide(numA, numB);                        
                        break;
                    case "Multiply":
                        res = _calcApi.Multiply(numA, numB);                        
                        break;
                    default:
                        res = 0.0;
                        break;
                }
                resultModel = new ResultModel(numA, numB, mathOp, res);

                return resultModel;
            }
            catch (Exception)
            {                  
                throw;
            }
            
        }
    }
}