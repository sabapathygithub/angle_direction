namespace AngleLib_Test
{
    using AngleLib;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    /// <summary>
    /// Contains test methods with different case to test the functionalities of type Radian with type Degree.
    /// </summary>
    [TestClass]
    public class DegreeAndRadianTest
    {
        /// <summary>
        /// Addition of a radian type and a degree type and checks output type which is radian.
        /// </summary>
        [TestMethod]
        public void Add_RadianDegree_OutputType()
        {

            Radian radian = new Radian(3.49066d);
            Degree degree = new Degree(10d);
            var result = radian + degree;
            Assert.IsInstanceOfType(result, typeof(Radian));
        }

        /// <summary>
        /// Addition of a degree type and a radian type and checks the output type which is degree.
        /// </summary>
        [TestMethod]
        public void Add_DegreeRadian_OutputType()
        {

            Radian radian = new Radian(3.49066d);
            Degree degree = new Degree(10d);
            var result = degree + radian;
            Assert.IsInstanceOfType(result, typeof(Degree));
        }

        /// <summary>
        /// Contains test case to check the addition of a radian type and a degree type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Add_RadianDegree()
        { 
            double expected = 3.6651929251994328d;
            Radian radian = new Radian(3.49066d);
            Degree degree = new Degree(10d);
            var result = radian + degree;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the addition of a degree type and a radian type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Add_DegreeRadian()
        {

            double expected = 210.00008571513595d;
            Radian radian = new Radian(3.49066d);
            Degree degree = new Degree(10d);
            var result = degree + radian;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the subraction of a radian type and a degree type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Subtract_RadianDegree()
        {

            double expected = Math.PI / 2;
            Radian radian = new Radian(Math.PI);
            Degree degree = new Degree(90.0d);
            var result = radian - degree;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the subraction of a degree type and a radian type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Subtract_DegreeRadian()
        {

            double expected = 110.0d;
            Radian radian = new Radian(Math.PI / 2);
            Degree degree = new Degree(200.0d);
            var result = degree - radian;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the modulo of a radian type and a degree type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Modulo_RadianDegree()
        {

            double expected = 0.5d;
            Radian radian = new Radian(Math.PI + 0.5);
            Degree degree = new Degree(90.0d);
            var result = radian % degree;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Contains test case to check the modulo of a degree type and a radian type are equals to expected output.
        /// </summary>
        [TestMethod]
        public void Modulo_DegreeRadian()
        {

            double expected = 20.0d;
            Radian radian = new Radian(Math.PI / 2);
            Degree degree = new Degree(200.0d);
            var result = degree % radian;
            Assert.AreEqual(expected, result.Value);
        }

        /// <summary>
        /// Checks whether the given radian type and degree type are equal.
        /// </summary>
        [TestMethod]
        public void Equals_RadianDegree()
        {
            Radian radian = new Radian(Math.PI / 2);
            Degree degree = new Degree(90.0d);
            var result = radian == degree;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Checks whether the given degree type and radian type are equal
        /// </summary>
        [TestMethod]
        public void Equals_DegreeRadian()
        {
            Radian radian = new Radian(Math.PI / 2);
            Degree degree = new Degree(90.0d);
            var result = degree == radian;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Checks whether the given radian type and degree type are not equal.
        /// </summary>
        [TestMethod]
        public void NotEquals_RadianDegree()
        {
            Radian radian = new Radian(Math.PI + 0.5);
            Degree degree = new Degree(90.0d);
            var result = radian != degree;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Checks whether the given degree type and radian type are not equal.
        /// </summary>
        [TestMethod]
        public void NotEquals_DegreeRadian()
        {
            Radian radian = new Radian(Math.PI / 2);
            Degree degree = new Degree(200.0d);
            var result = degree != radian;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Checks whether the given radian type is greater than the degree type.
        /// </summary>
        [TestMethod]
        public void GreaterThan_RadianDegree()
        {
            Radian radian = new Radian(Math.PI);
            Degree degree = new Degree(90.0d);
            var result = radian > degree;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Checks whether the given degree type is greater than the radian type.
        /// </summary>
        [TestMethod]
        public void GreaterThan_DegreeRadian()
        {
            Radian radian = new Radian(Math.PI / 2);
            Degree degree = new Degree(200.0d);
            var result = degree > radian;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Checks whether the given radian type is less than the degree type.
        /// </summary>
        [TestMethod]
        public void LessThan_RadianDegree()
        {
            Radian radian = new Radian(Math.PI / 4);
            Degree degree = new Degree(90.0d);
            var result = radian < degree;
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Checks whether the given degree type is less than the radian type.
        /// </summary>
        [TestMethod]
        public void LessThan_DegreeRadian()
        {
            Radian radian = new Radian(Math.PI / 2);
            Degree degree = new Degree(20.0d);
            var result = degree < radian;
            Assert.AreEqual(true, result);
        }
    }
}
