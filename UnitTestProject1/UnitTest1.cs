using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using percentCalc;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class percent
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new Class1();
            double arg1 = 10000;
            double arg2 = 1.5;
            int arg3 = 1;

            int expected = 122;
            // act
            int result = Convert.ToInt32(calc.kreditden(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);


        }
        [TestMethod]
        public void TestMethod2()
        {
            var calc = new Class1();
            double arg1 = 10000;
            double arg2 = 1.5;
            int arg3 = 1;

            int expected = 1497;
            // act
            int result = Convert.ToInt32(calc.kreditmes(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var calc = new Class1();
            double arg1 = 10000;
            double arg2 = 1.5;
            int arg3 = 1;

            double expected = 2671;
            // act
            double result = Convert.ToInt32(calc.kreditkvart(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var calc = new Class1();
            double arg1 = 10000;
            double arg2 = 1.5;
            int arg3 = 1;

            double expected = 5083;
            // act
            double result = Convert.ToInt32(calc.kredithalfyear(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var calc = new Class1();
            double arg1 = 10000;
            double arg2 = 1.5;
            int arg3 = 1;

            double expected = 10041;
            // act
            double result = Convert.ToInt32(calc.kredityear(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var calc = new Class1();
            double arg1 = 100000000;
            double arg2 = 1.5;
            int arg3 = 1;

            double expected = 100410959;
            // act
            double result = Convert.ToInt32(calc.kredityear(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var calc = new Class1();
            double arg1 = 100000000;
            double arg2 = 365;
            int arg3 = 1;

            double expected = 2.0589962369524E+115;
            // act
            double result = Convert.ToDouble(calc.kreditden(arg1, arg2, arg3));
            // assert            

        }
        [TestMethod]
        public void TestMethod18()
        {
            var calc = new Class1();
            double arg1 = 5000;
            double arg2 = 1.5;
            int arg3 = 1;

            int expected = 122;
            // act
            int result = Convert.ToInt32(calc.kreditden(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);


        }
        [TestMethod]
        public void TestMethod9()
        {
            var calc = new Class1();
            double arg1 = 9999;
            double arg2 = 1.5;
            int arg3 = 1;

            int expected = 122;
            // act
            int result = Convert.ToInt32(calc.kreditden(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);


        }
        [TestMethod]
        public void TestMethod10()
        {
            var calc = new Class1();
            double arg1 = 1000000000;
            double arg2 = 1.5;
            int arg3 = 1;

            int expected = 12240917;
            // act
            int result = Convert.ToInt32(calc.kreditden(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);


        }
        [TestMethod]
        public void TestMethod11()
        {
            var calc = new Class1();
            double arg1 = 1000000001;
            double arg2 = 1.5;
            int arg3 = 1;

            int expected = 122;
            // act
            int result = Convert.ToInt32(calc.kreditden(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);


        }
        [TestMethod]
        public void TestMethod12()
        {
            var calc = new Class1();
            double arg1 = 1005000000;
            double arg2 = 1.5;
            int arg3 = 1;

            int expected = 122;
            // act
            int result = Convert.ToInt32(calc.kreditden(arg1, arg2, arg3));
            // assert            
            Assert.AreEqual(expected, result);


        }
        [TestClass]
        public class percent2
        {
            [TestMethod]
            public void TestMethod12()
            {
                var calc = new Class1();
                double arg1 = 1005000000;
                double arg2 = 1.5;
                int arg3 = 1;

                int expected = 122;
                // act
                int result = Convert.ToInt32(calc.kreditden(arg1, arg2, arg3));
                // assert            
                Assert.AreEqual(expected, result);

            }
        }
    }
}