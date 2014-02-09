using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Santander.WebApiCalc.Models
{
    public class ResultModel
    {
        public double NumA { get; set; }
        public double NumB { get; set; }
        public string MathOp { get; set; }
        public double Result { get; set; }

        public ResultModel(double numA, double numB, string mathOp, double result)
        {
            NumA = numA;
            NumB = numB;
            MathOp = mathOp;
            Result = result;
        }
    }
}