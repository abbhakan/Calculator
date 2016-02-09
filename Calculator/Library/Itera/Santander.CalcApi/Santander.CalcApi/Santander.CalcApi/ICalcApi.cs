using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santander.CalcApi
{
    public interface ICalcApi
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Divide(double x, double y);
        double Multiply(double x, double y);
        double Modulo(double x, double y);
    }
}
