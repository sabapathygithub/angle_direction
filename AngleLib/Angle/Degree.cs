namespace AngleLib
{
    using System;

    /// <summary>
    /// Class which provides logic to handle angular unit degree. 
    /// </summary>
    public class Degree : Angle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Degree"/> class.
        /// </summary>
        /// <param name="angleValue">An angle value which is measured in degrees which values between 0 to 360.</param>
        public Degree(double angleValue) : base(angleValue)
        {
            if(angleValue > 360 || angleValue < 0)
            {
                throw new NotSupportedException("Given angle is not supported and the valid range is between 0 and 360 degrees. Please provide a valid input.");
            }
        }

        #region overrides
        /// <summary>
        /// Gives a way to override the addition logic between two angle operand.
        /// </summary>
        protected override Angle Add(Angle angleUnit)
        {
            return new Degree(Value + angleUnit.ToDegree());
        }

        /// <summary>
        /// Gives a way to override the division logic between two angle operand.
        /// </summary>
        protected override Angle Divide(double d)
        {
            return new Degree(Value / d);
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified object represents the same value.
        /// </summary>
        public override bool Equals(object obj)
        {
            var angle = obj as Angle;
            return !object.ReferenceEquals(angle, null) && Value.Equals(angle.ToDegree());
        }

        /// <summary>
        /// Returns hash code for the angle value.
        /// </summary>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// Gives a way to override the logic to compare two angle value and returns two if the right hand side operand is greater than other operand.
        /// </summary>
        protected override bool GreaterThan(Angle angleUnit)
        {
            return Value > angleUnit.ToDegree();
        }

        /// <summary>
        /// Gives a way to override the logic to compare two angle value and returns two if the right hand side operand is less than other operand.
        /// </summary>
        protected override bool LessThan(Angle angleUnit)
        {
            return Value < angleUnit.ToDegree();
        }

        /// <summary>
        /// Gives a way to override the logic of modulo operatio between two angle operand.
        /// </summary>
        protected override Angle Modulo(Angle angleUnit)
        {
            return new Degree(Value % angleUnit.ToDegree());
        }

        /// <summary>
        /// Gives a way to override the multiplication logic between two angle operand.
        /// </summary>
        protected override Angle Multiply(double d)
        {
            return new Degree(Value * d);
        }

        /// <summary>
        /// Gives a way to override the subtraction logic between two angle operand.
        /// </summary>
        protected override Angle Subtract(Angle angleUnit)
        {
            return new Degree(Value - angleUnit.ToDegree());
        }

        /// <summary>
        /// Normalizes the angle between 0 to 360 degrees.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        protected sealed override double NormalizeAngle(double d)
        {
            double aValue = d;
            if (aValue > 360)
                aValue %= 360;
            else if (aValue < 0)
                aValue += 360;
            return aValue;
        }

        /// <summary>
        /// Converts the given angle to degree value.
        /// </summary>
        internal override double ToDegree()
        {
            return Value;
        }

        /// <summary>
        /// Converts the given angle to radian value.
        /// </summary>
        internal override double ToRadian()
        {
            return (Value * Math.PI / 180.0d);
        }
        #endregion

        #region operators
        /// <summary>
        /// Implicit casting between Radian and Degree.
        /// </summary>
        public static implicit operator Degree(Radian v)
        {
            return new Degree(v.ToDegree());
        }

        /// <summary>
        /// Implicit casting between double and Degree.
        /// </summary>
        public static implicit operator Degree(double value)
        {
            return new Degree(value);
        }

        /// <summary>
        /// Explicit casting between double and Degree.
        /// </summary>
        public static explicit operator double(Degree v)
        {
            return v.Value;
        }
        #endregion
    }
}
