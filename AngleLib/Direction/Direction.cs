namespace AngleLib
{
    using System;
    /// <summary>
    /// An abstract class which provides base logic for different type of directions.
    /// </summary>
    public abstract class Direction
    {
        /// <summary>
        /// Gets or sets a value which is used to calculate direction
        /// </summary>
        public Angle Angle { get; set; }

        /// <summary>
        /// Initialize a new instance of type Direction
        /// </summary>
        protected Direction(Angle angle)
        {
            Angle = angle;
        }

        #region Virtual methods
        /// <summary>
        /// Calculates quadrant based on give angle.
        /// </summary>
        /// <returns>Quadrant value.</returns>
        public virtual int GetQuadrant()
        {
            if (double.IsNaN(Angle.Value) || double.IsPositiveInfinity(Angle.Value) || double.IsNegativeInfinity(Angle.Value))
            {
                throw new NotFiniteNumberException("Given angle is not a number");
            }
            double value = Angle.ToDegree();
            return Convert.ToInt32(Math.Ceiling((value / 90) % 4));
        }

        /// <summary>
        /// Calculates direction index based on given angle. For easy understanding, any type angular unit is converted to degree. 
        /// </summary>
        internal virtual int GetDirectionIndex()
        {
            return (int)Math.Round(((double)Angle.ToDegree() % 360) / 45);
        } 
        #endregion

        #region Abstracts
        /// <summary>
        /// Calculates direction based on given angle.
        /// </summary>
        /// <returns>Information about direction.</returns>
        public abstract string GetDirection();

        /// <summary>
        /// Converts the angle of given direction to it's equivalent angle in mathematical direction.
        /// </summary>
        /// <returns>Mathimatical direct angle value</returns>
        internal abstract Angle ToMathematicalDirection();

        /// <summary>
        /// Converts the angle of given direction to it's equivalent angle in compass direction.
        /// </summary>
        /// <returns>Compass direct angle value</returns>
        internal abstract Angle ToCompassDirection();
        #endregion
    }
}
