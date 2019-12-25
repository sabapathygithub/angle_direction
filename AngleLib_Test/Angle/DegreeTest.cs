namespace AngleLib_Test.Angle
{
    using AngleLib;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    /// <summary>
    /// Contains test methods with different cases to test the functionalities of type Degree.
    /// </summary>
    [TestClass]
    public class DegreeTest : IAngleTest
    {
        /// <summary>
        /// Contains test case to check the addition of degree type is equals to expected output.
        /// </summary>
        [TestMethod]
        public void Add_Angles()
        {
            double expected = 210d;
            Degree degree1 = new Degree(200);
            Degree degree2 = new Degree(10);
            var result = degree1 + degree2;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the subtraction of degree type is equals to expected output.
        /// </summary>
        [TestMethod]
        public void Subtract_Angles()
        {

            double expected = 190d;
            Degree degree1 = new Degree(200);
            Degree degree2 = new Degree(10);
            var result = degree1 - degree2;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the multiplication of a degree type and a double type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Multiply_AngleAndDouble()
        {
            double expected = 200d;
            Degree degree1 = new Degree(20);
            var result = degree1 * 10;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the division of a degree type and a double type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Divide_AngleAndDouble()
        {

            double expected = 20d;
            Degree degree1 = new Degree(200);
            var result = degree1 / 10;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the remainder of two degree types are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Modulo_Angles()
        {
            double expected = 2.7500000000000009d;
            Degree degree1 = new Degree(25.5d);
            Degree degree2 = new Degree(4.55d);
            var result = degree1 % degree2;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check whether the given degree values are equal.
        /// </summary>
        [TestMethod]
        public void Angles_Equals()
        {
            Degree degree1 = new Degree(200);
            Degree degree2 = new Degree(200);
            var result = degree1 == degree2;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Contains test case to check whether the given different degree values are not equal and the expected output is true.
        /// </summary>
        [TestMethod]
        public void Angles_NotEquals()
        {
            Degree degree1 = new Degree(200);
            Degree degree2 = new Degree(180);
            var result = degree1 != degree2;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Contains test case to check whether left hand side operand is greater than right hand side operand.
        /// </summary>
        [TestMethod]
        public void Angles_GreaterThan()
        {
            Degree degree1 = new Degree(200);
            Degree degree2 = new Degree(180);
            var result = degree1 > degree2;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Contains test case to check whether left hand side operand is less than right hand side operand.
        /// </summary>
        [TestMethod]
        public void Angles_LessThan()
        {
            Degree degree1 = new Degree(20);
            Degree degree2 = new Degree(180);
            var result = degree1 < degree2;
            Assert.AreEqual(true, result);
        }
        
        /// <summary>
        /// Contains test case to check the type casting between radian and degree.
        /// </summary>
        [TestMethod]
        public void TypeCasting_RadianToDegree()
        {
            double expected = 270.0d;
            Radian radian = new Radian(Math.PI * 1.5);
            Degree degree = (Degree)radian;
            Assert.AreEqual(expected, degree.Value);
        }

        /// <summary>
        /// Contains test case to check the sine value of given angle.
        /// </summary>
        [TestMethod]
        public void Sin_Angle()
        {
            double expected = 1.0d;
            Degree degree = new Degree(90);
            double actual = degree.Sin();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Contains test case to check the cosine value of given angle.
        /// </summary>
        [TestMethod]
        public void Cos_Angle()
        {
            double expected = -0.86602540378443871d;
            Degree degree = new Degree(150);
            double actual = degree.Cos();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Contains test case to check the tangent value of given angle.
        /// </summary>
        [TestMethod]
        public void Tan_Angle()
        {
            double expected = 1.19175359259421d;
            Degree degree = new Degree(50);
            double actual = degree.Tan();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Contains test case to check arcsine value of given angle.
        /// </summary>
        [TestMethod]
        public void ArcSin_Angle()
        {
            double expected = 1.5707963267948966d;
            Degree degree = new Degree(90);
            double actual = degree.ArcSin();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Contains test case to check arccosine value of given angle.
        /// </summary>
        [TestMethod]
        public void ArcCos_Angle()
        {
            double expected = 2.6179938779914944d;
            Degree degree = new Degree(150);
            double actual =  degree.ArcCos();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Contains test case to check inverse tangent value of given angle.
        /// </summary>
        [TestMethod]
        public void ArcTan_Angle()
        {
            double expected = 0.87266462599716477d;
            Degree degree = new Degree(50);
            double actual = degree.ArcTan();
            Assert.AreEqual(expected, actual);
        }
    }
}
