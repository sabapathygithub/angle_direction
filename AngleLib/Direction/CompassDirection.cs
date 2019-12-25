namespace AngleLib
{
    /// <summary>
    /// This class handles compass direction which is measured from Y-axis in clockwise direction. 
    /// </summary>
    public class CompassDirection : Direction
    {
       

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassDirection"/> class.
        /// </summary>
        /// <param name="angleValue">An angle type</param>
        public CompassDirection(Angle angleValue):base(angleValue)
        {

        }

        #region Overrides
        /// <summary>
        /// Gives the direction of given angle.
        /// </summary>
        /// <returns>Direction</returns>
        public override string GetDirection()
        {
            string[] directions = { "N", "NE", "E", "SE", "S", "SW", "W", "NW", "N" };
            int directionIndex = GetDirectionIndex();
            return directions[directionIndex];
        }

        /// <summary>
        /// Converts compass direction to mathematical direction.
        /// </summary>
        internal override Angle ToMathematicalDirection()
        {
            double aValue = (90 - Angle.ToDegree()) + 360.0d;
            return new Degree(aValue);
        }

        /// <summary>
        /// Returns compass direction.
        /// </summary>
        internal override Angle ToCompassDirection()
        {
            return new Degree(Angle.ToDegree());
        }
        #endregion

        #region Operators
        /// <summary>
        /// Provides machanism for casting between different direction types.
        /// </summary>
        public static explicit operator CompassDirection(MathematicalDirection md)
        {
            return new CompassDirection(md.ToCompassDirection());
        }
        #endregion
    }
}
