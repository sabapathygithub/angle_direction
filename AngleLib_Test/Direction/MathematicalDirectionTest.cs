using AngleLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AngleLib_Test.Direction
{
    /// <summary>
    /// Contains test methods with different case to test the functionalities of type MathematicalDirection
    /// </summary>
    [TestClass]
    public class MathematicalDirectionTest: IDirectionTest
    {
        /// <summary>
        /// Checks the quadrant value with type casting between mathematical direction and compasss direction. 
        /// </summary>
        [TestMethod]
        public void CastingMathAndCompassDirection()
        {
            int expected = 4;
            //130 belongs to quadrant 2 in mathemetical direction which must be in quadrant 4 in compass direction.
            MathematicalDirection direction = new MathematicalDirection(new Degree(130));
            CompassDirection cd = (CompassDirection)direction;
            int actualValue = cd.GetQuadrant();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        ///Checks the direction of given degree is equals to North East.
        /// </summary>
        [TestMethod]
        public void GetDirection_Degree_NorthEast()
        {
            string expected = "NE";
            MathematicalDirection direction = new MathematicalDirection(new Degree(45));
            string actualValue = direction.GetDirection();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the direction of given degree is equals to South East.
        /// </summary>
        [TestMethod]
        public void GetDirection_Degree_SouthEast()
        {
            string expected = "SE";
            MathematicalDirection direction = new MathematicalDirection(new Degree(308d));
            string actualValue = direction.GetDirection();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the direction of given degree is equals to South West.
        /// </summary>
        [TestMethod]
        public void GetDirection_Degree_SouthWest()
        {
            string expected = "SW";
            MathematicalDirection direction = new MathematicalDirection(new Degree(210));
            string actualValue = direction.GetDirection();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the direction of given degree is equals to North West.
        /// </summary>
        [TestMethod]
        public void GetDirection_Degree_NorthWest()
        {
            string expected = "NW";
            MathematicalDirection direction = new MathematicalDirection(new Degree(115.6d));
            string actualValue = direction.GetDirection();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the direction of given radian is equals to North East.
        /// </summary>
        [TestMethod]
        public void GetDirection_Radian_NorthEast()
        {
            string expected = "NE";
            MathematicalDirection direction = new MathematicalDirection(new Radian(Math.PI / 5));
            string actualValue = direction.GetDirection();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the direction of given radian is equals to South East.
        /// </summary>
        [TestMethod]
        public void GetDirection_Radian_SouthEast()
        {
            string expected = "SE";
            MathematicalDirection direction = new MathematicalDirection(new Radian(2 * Math.PI / 3));
            string actualValue = direction.GetDirection();
            Assert.AreNotEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the direction of given radian is equals to South West.
        /// </summary>
        [TestMethod]
        public void GetDirection_Radian_SouthWest()
        {
            string expected = "SW";
            MathematicalDirection direction = new MathematicalDirection(new Radian(Math.PI * 1.2));
            string actualValue = direction.GetDirection();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the direction of given radian is equals to North West.
        /// </summary>
        [TestMethod]
        public void GetDirection_Radian_NorthWest()
        {
            string expected = "NW";
            MathematicalDirection direction = new MathematicalDirection(new Radian(Math.PI * 0.8));
            string actualValue = direction.GetDirection();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the quadrant for the given degree value.
        /// </summary>
        [TestMethod]
        public void GetQuadrant_Degree()
        {
            int expected = 2;
            MathematicalDirection direction = new MathematicalDirection(new Degree(130));
            int actualValue = direction.GetQuadrant();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the quadrant for the given degree radian.
        /// </summary>
        [TestMethod]
        public void GetQuadrant_Radian()
        {
            int expected = 3;
            MathematicalDirection direction = new MathematicalDirection(new Degree(265));
            int actualValue = direction.GetQuadrant();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the angle value after type casting between mathematical and compass directions.
        /// </summary>
        [TestMethod]
        public void TypeCasting_CompasssToMathematical_Angle_Check()
        {
            double expected = 304.5d;
            CompassDirection cd = new CompassDirection(new Degree(145.5));
            MathematicalDirection md = (MathematicalDirection)cd;
            Assert.AreEqual(expected, md.Angle.Value);
        }

        /// <summary>
        /// Checks the quadrant after type casting between compass and mathematical directions.
        /// </summary>
        [TestMethod]
        public void TypeCasting_CompasssToMathematical_Quadrant_Check()
        {
            int expected = 4;
            CompassDirection cd = new CompassDirection(new Degree(145.5));
            MathematicalDirection md = (MathematicalDirection)cd;
            int result = md.GetQuadrant();
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Checks the direction after type casting between compass and mathematical directions.
        /// </summary>
        [TestMethod]
        public void TypeCasting_CompasssToMathematical_Direction_Check()
        {
            string expected = "SE";
            CompassDirection cd = new CompassDirection(new Degree(145.5));
            MathematicalDirection md = (MathematicalDirection)cd;
            string result = md.GetDirection();
            Assert.AreEqual(expected, result);
        }
    }
}
