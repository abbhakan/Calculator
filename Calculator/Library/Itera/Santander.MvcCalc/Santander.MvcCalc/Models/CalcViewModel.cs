using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Santander.MvcCalc.Extensions;

namespace Santander.MvcCalc.Models
{
    public class CalcViewModel
    {        
        public double NumA { get; set; }
        public double NumB { get; set; }
        public EnumMath MathOp { get; set; }
        public double Result { get; set; }
    }
}