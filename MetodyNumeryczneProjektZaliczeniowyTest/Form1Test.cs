using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetodyNumeryczneProjektZaliczeniowy;

namespace MetodyNumeryczneProjektZaliczeniowyTest
{
    [TestClass]
    public class Form1Test
    {
        [TestMethod]
        public void TestCalculateFunctionValueAtXEqual0()
        {
            decimal[] functionParameters = new decimal[] { 2.0m, 1.0m };
            decimal x = 0.0m;
            Form1 form = new Form1();

            decimal result = form.CalculateFunctionValueAtX(functionParameters, x);

            Assert.AreEqual(1.0m, result);
        }

        [TestMethod]
        public void TestCalculateFunctionValueAtXEqual1()
        {
            decimal[] functionParameters = new decimal[] { 4.0m, 3.0m, 2.0m, 3.0m };
            decimal x = 1.0m;
            Form1 form = new Form1();

            decimal result = form.CalculateFunctionValueAtX(functionParameters, x);

            Assert.AreEqual(12.0m, result);
        }

        [TestMethod]
        public void TestCalculateFunctionValueAtXEqual2()
        {
            decimal[] functionParameters = new decimal[] { 2.0m, 4.0m, 6.0m };
            decimal x = 2.0m;
            Form1 form = new Form1();

            decimal result = form.CalculateFunctionValueAtX(functionParameters, x);

            Assert.AreEqual(22.0m, result);
        }

        [TestMethod]
        public void TestCalculateDerivative()
        {
            decimal[] functionParameters = new decimal[] { 4.0m, 2.0m, 5.0m };
            Form1 form = new Form1();

            decimal[] result = form.CalculateDerivative(functionParameters);

            decimal[] result1 = new decimal[] { 8.0m, 2.0m };

            CollectionAssert.AreEquivalent(result1,  result);
        }

        [TestMethod]
        public void TestCalculateDerivative1()
        {
            decimal[] functionParameters = new decimal[] { -3.0m, 2.0m, 6.0m, 5.0m };
            Form1 form = new Form1();

            decimal[] result = form.CalculateDerivative(functionParameters);

            decimal[] result1 = new decimal[] { 4.0m, -9.0m, 6.0m };

            CollectionAssert.AreEquivalent(result1,  result);
        }
        
        
        [TestMethod]
        public void TestCalculateZeroPlace()
        {
            decimal[] functionParameters = new decimal[] { -3.0m, 2.0m, 4.0m };
            decimal startPointX = 1.4m;
            decimal epsilon = 0.001m;
            decimal delta = 0.000001m;
            int iterations = 100;
            Form1 form = new Form1();

            decimal result = form.CalculateZeroPlace(functionParameters, startPointX, epsilon, delta, iterations);

            Assert.AreEqual(1.5351837588702392293401098083m, result);
        }

        [TestMethod]
        public void TestCalculateZeroPlace1()
        {
            decimal[] functionParameters = new decimal[] { -4.0m, 9.0m, 3.0m };
            decimal startPointX = 1.5m;
            decimal epsilon = 0.000001m;
            decimal delta = 0.001m;
            int iterations = 100;
            Form1 form = new Form1();

            decimal result = form.CalculateZeroPlace(functionParameters, startPointX, epsilon, delta, iterations);

            Assert.AreEqual(2.5447271722282598013745554193m, result);
        }
    }
}
