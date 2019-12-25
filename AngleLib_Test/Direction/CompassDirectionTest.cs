using AngleLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AngleLib_Test.Direction
{
    /// <summary>
    /// Contains test methods with different case to test the functionalities of type CompassDirection
    /// </summary>
    [TestClass]
    public class CompassDirectionTest : IDirectionTest
    {
        /// <summary>
        /// Checks the quadrant value with type casting between compass direction and mathematical direction. 
        /// </summary>
        [TestMethod]
        public void CastingMathAndCompassDirection()
        {
            int expected = 4;
            //130 belongs to quadrant 2 in compass direction which must be in quadrant 4 in mathematical direction.
            CompassDirection direction = new CompassDirection(new Degree(130));
            MathematicalDirection md = (MathematicalDirection)direction;
            int actualValue = md.GetQuadrant();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        ///Checks the direction of given degree is equals to North East.
        /// </summary>
        [TestMethod]
        public void GetDirection_Degree_NorthEast()
        {
            string expected = "NE";
            CompassDirection direction = new CompassDirection(new Degree(45));
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
            CompassDirection direction = new CompassDirection(new Degree(130));
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
            CompassDirection direction = new CompassDirection(new Degree(210));
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
            CompassDirection direction = new CompassDirection(new Degree(308.7d));
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
            CompassDirection direction = new CompassDirection(new Radian(Math.PI / 5));
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
            CompassDirection direction = new CompassDirection(new Radian(Math.PI * 0.8));
            string actualValue = direction.GetDirection();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the direction of given radian is equals to South West.
        /// </summary>
        [TestMethod]
        public void GetDirection_Radian_SouthWest()
        {
            string expected = "SW";
            CompassDirection direction = new CompassDirection(new Radian(Math.PI * 1.2));
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
            CompassDirection direction = new CompassDirection(new Radian(Math.PI * 1.8));
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
            CompassDirection direction = new CompassDirection(new Degree(130));
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
            CompassDirection direction = new CompassDirection(new Radian(Math.PI + 0.4));
            int actualValue = direction.GetQuadrant();
            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// Checks the angle value after type casting between mathematical and compass directions.
        /// </summary>
        [TestMethod]
        public void TypeCasting_MathematicalToCompasss_Angle_Check()
        {
            double expected = 180.0d;
            MathematicalDirection md = new MathematicalDirection(new Degree(270));
            CompassDirection cd = (CompassDirection)md;
            Assert.AreEqual(expected, cd.Angle.Value);
        }

        /// <summary>
        /// Checks the quadrant after type casting between mathematical and compass directions.
        /// </summary>
        [TestMethod]
        public void TypeCasting_MathematicalToCompasss_Quadrant_Check()
        {
            int expected = 4;
            MathematicalDirection md = new MathematicalDirection(new Degree(150));
            CompassDirection cd = (CompassDirection)md;
            int result = cd.GetQuadrant();
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Checks the direction after type casting between mathematical and compass directions.
        /// </summary>
        [TestMethod]
        public void TypeCasting_MathematicalToCompasss_Direction_Check()
        {
            string expected = "NW";
            MathematicalDirection md = new MathematicalDirection(new Degree(150));
            CompassDirection cd = (CompassDirection)md;
            string result = cd.GetDirection();
            Assert.AreEqual(expected, result);
        }
    }
}
