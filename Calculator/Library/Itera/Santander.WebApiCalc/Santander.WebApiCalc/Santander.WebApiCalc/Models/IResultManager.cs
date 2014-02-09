using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Santander.WebApiCalc.Models
{
    public interface IResultManager
    {
        ResultModel Execute(double numA, double numB, string mathOp);
    }
}