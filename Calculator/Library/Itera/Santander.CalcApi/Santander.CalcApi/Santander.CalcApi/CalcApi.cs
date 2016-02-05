using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santander.CalcApi
{
    public class CalcApi : ICalcApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Add(double x, double y)
        {
            double result;
            try
            {
                result = x + y;
                return result;
                
            }
            catch (Exception ex)
            {                    
                throw;
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Subtract(double x, double y)
        {
            double result;
            try
            {
                var a = "a";
                result = x - y;
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }         

        }

        public double Divide(double x, double y)
        {
            double result;
            try
            {
                result = x/y;
                return result;
            }
            catch (Exception ex)
            {                    
                throw;
            }
        }

        public double Multiply(double x, double y)
        {
            double result;
            try
            {
                result = x * y;
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public double Modulo(double x, double y)
        {
            double result;
            try
            {
                result = x % y;
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
