namespace AngleLib_Test.Angle
{
    using AngleLib;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    /// <summary>
    /// Contains test methods with different case to test the functionalities of type Radian.
    /// </summary>
    [TestClass]
    public class RadianTest : IAngleTest
    {
        /// <summary>
        /// Contains test case to check the addition of radian type is equals to expected output.
        /// </summary>
        [TestMethod]
        public void Add_Angles()
        {
            double expected = Math.PI + (Math.PI / 2);
            Radian radian1 = new Radian(Math.PI);
            Radian radian2 = new Radian(Math.PI / 2);
            var result = radian1 + radian2;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the subtraction of radian type is equals to expected output.
        /// </summary>
        [TestMethod]
        public void Subtract_Angles()
        {
            double expected = Math.PI - (Math.PI / 2);
            Radian radian1 = new Radian(Math.PI);
            Radian radian2 = new Radian(Math.PI / 2);
            var result = radian1 - radian2;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the multiplication of a radian type and a double type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Multiply_AngleAndDouble()
        {
            double expected = Math.PI * (Math.PI / 2);
            Radian radian1 = new Radian(Math.PI);
            var result = radian1 * (Math.PI / 2);
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the division of a radian type and a double type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Divide_AngleAndDouble()
        {
            double expected = 2;
            Radian radian1 = new Radian(Math.PI);
            var result = radian1 / (Math.PI / 2);
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the remainder of two radian types are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Modulo_Angles()
        {
            double expected = 2;
            Radian radian1 = new Radian(Math.PI + 2);
            Radian radian2 = new Radian(Math.PI);
            var result = radian1 % radian2;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check whether the given radian values are equal.
        /// </summary>
        [TestMethod]
        public void Angles_Equals()
        {
            Radian radian1 = new Radian(Math.PI);
            Radian radian2 = new Radian(Math.PI);
            var result = radian1 == radian2;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Contains test case to check whether the given different radian values are not equal and the expected output is true.
        /// </summary>
        [TestMethod]
        public void Angles_NotEquals()
        {
            Radian radian1 = new Radian(Math.PI);
            Radian radian2 = new Radian(Math.PI + 0.5);
            var result = radian1 != radian2;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Contains test case to check whether left hand side operand is greater than right hand side operand.
        /// </summary>
        [TestMethod]
        public void Angles_GreaterThan()
        {
            Radian radian1 = new Radian(Math.PI);
            Radian radian2 = new Radian(Math.PI / 2);
            var result = radian1 > radian2;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Contains test case to check whether left hand side operand is less than right hand side operand.
        /// </summary>
        [TestMethod]
        public void Angles_LessThan()
        {
            Radian radian1 = new Radian(Math.PI / 2);
            Radian radian2 = new Radian(Math.PI);
            var result = radian1 < radian2;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Contains test case to check the type casting between radian and radian.
        /// </summary>
        [TestMethod]
        public void TypeCasting_DegreeToRadian()
        {
            double expected = Math.PI * 1.5;
            Degree degree = new Degree(270.0d);
            Radian radian = (Radian)degree;
            Assert.AreEqual(expected, radian.Value);
        }

        /// <summary>
        /// Contains test case to check the sine value of given angle.
        /// </summary>
        [TestMethod]
        public void Sin_Angle()
        {
            double expected = 1.0d;
            Radian radian = new Radian(Math.PI / 2);
            double actual = radian.Sin();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Contains test case to check the cosine value of given angle.
        /// </summary>
        [TestMethod]
        public void Cos_Angle()
        {
            double expected = 0.50000000000000011d;
            Radian radian = new Radian(Math.PI / 3);
            double actual = radian.Cos();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Contains test case to check the tangent value of given angle.
        /// </summary>
        [TestMethod]
        public void Tan_Angle()
        {
            Radian radian = new Radian(Math.PI * 1.5);
            double expected = radian.Sin() / radian.Cos();
            double actual = radian.Tan();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Contains test case to check arcsine value of given angle.
        /// </summary>
        [TestMethod]
        public void ArcSin_Angle()
        {
            double expected = Math.PI / 2;
            Radian radian = new Radian(Math.PI / 2);
            double actual = radian.ArcSin();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Contains test case to check arccosine value of given angle.
        /// </summary>
        [TestMethod]
        public void ArcCos_Angle()
        {
            double expected = Math.PI / 3;
            Radian radian = new Radian(Math.PI / 3);
            double actual = radian.ArcCos();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Contains test case to check inverse tangent value of given angle.
        /// </summary>
        [TestMethod]
        public void ArcTan_Angle()
        {
            Radian radian = new Radian(Math.PI * 1.5);
            double expected = 1.5707963267948963;
            double actual = radian.ArcTan();
            Assert.AreEqual(expected, actual);
        }
    }
}
