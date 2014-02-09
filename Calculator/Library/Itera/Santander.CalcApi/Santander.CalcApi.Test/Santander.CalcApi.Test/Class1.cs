﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Santander.CalcApi.Test
{
    [TestFixture]
    public class UnitTest_CalcApi
    {
        [Test]
        public void AddTwoNumbers_ShouldReturnSum()
        {
            // Arrange
            var calcApi = new CalcApi();
            var x = 1;
            var y = 2;
            
            // Act
            var result = calcApi.Add(x, y);

            // Assert
            Assert.AreEqual(x+y, result);
        }

        [Test]
        public void SubractTwoNumbers_ShouldReturnDifference()
        {
            // Arrange
            var calcApi = new CalcApi();
            var x = 3;
            var y = 2;

            // Act
            var result = calcApi.Subtract(x, y);

            // Assert
            Assert.AreEqual(x - y, result);
        }

        [Test]
        public void DivideTwoNumbers_ShouldReturnQoutient()
        {
            // Arrange
            var calcApi = new CalcApi();
            double x = 3;
            double y = 2;

            // Act
            var result = calcApi.Divide(x, y);

            // Assert
            Assert.AreEqual(x/y, result);
        }

        [Test]
        public void DivideTwoNumbers_ShouldReturnException_GivenZeroDivisor()
        {
            // Arrange
            var calcApi = new CalcApi();
            var x = 3;
            var y = 0;

            // Act
            double result;
            try
            {
                result = calcApi.Divide(x, y);
            }
            catch (Exception ex)
            {
                // Assert                    
                Assert.Fail("Expected exception was thrown");
            }
                        
        }

        [Test]
        public void MultiplyTwoNumbers_ShouldReturnProduct()
        {
            // Arrange
            var calcApi = new CalcApi();
            double x = 3;
            double y = 2;

            // Act
            var result = calcApi.Multiply(x, y);

            // Assert
            Assert.AreEqual(x * y, result);
        }
        
    }
}
