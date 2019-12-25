namespace AngleLib
{
    /// <summary>
    /// This class handles mathematical direction which is measure from X-axis in counter clockwise direction. 
    /// </summary>
    public class MathematicalDirection : Direction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MathematicalDirection"/> class.
        /// </summary>
        /// <param name="angleValue">An angle type</param>
        public MathematicalDirection(Angle angleValue) : base(angleValue)
        {
        }

        #region Overrides
        /// <summary>
        /// Gives the direction of given angle.
        /// </summary>
        /// <returns>Direction</returns>
        public override string GetDirection()
        {
            string[] directions = { "E", "NE", "N", "NW", "W", "SW", "S", "SE", "E" };
            int directionIndex = GetDirectionIndex();
            return directions[directionIndex];
        }

        /// <summary>
        /// Returns mathematical direction for casting.
        /// </summary>
        /// <returns></returns>
        internal override Angle ToMathematicalDirection()
        {
            return new Degree(Angle.ToDegree());
        }

        /// <summary>
        /// Converts mathematical direction to compass direction
        /// </summary>
        internal override Angle ToCompassDirection()
        {
            double aValue = (90 - Angle.ToDegree()) + 360.0d;
            return new Degree(aValue);
        }
        #endregion

        #region
        /// <summary>
        /// Provides logic for casting between different direction types.
        /// </summary>
        /// <param name="cd"></param>
        public static explicit operator MathematicalDirection(CompassDirection cd)
        {
            return new MathematicalDirection(cd.ToMathematicalDirection());
        }
        #endregion
    }
}
