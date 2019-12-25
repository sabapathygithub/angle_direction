namespace AngleLib
{
    using System;

    /// <summary>
    /// Handles radian type of angular unit 
    /// </summary>
    public class Radian : Angle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Radian"/> class.
        /// </summary>
        /// <param name="angleValue">An angle, measured in degrees which values between 0 to 2PI </param>
        public Radian(double angleValue) : base(angleValue)
        {
            if (angleValue > (2 * Math.PI) || angleValue < 0)
            {
                throw new NotSupportedException("Given angle is not supported and the valid range is between 0 and 2PI degrees. Please provide a valid input.");
            }
        }

        #region Overrides
        /// <summary>
        /// Gives a way to override the addition logic between two angle operand.
        /// </summary>
        protected override Angle Add(Angle angleUnit)
        {
            return new Radian( Value + angleUnit.ToRadian());
        }

        /// <summary>
        /// Gives a way to override the subtraction logic between two angle operand.
        /// </summary>
        protected override Angle Divide(double d)
        {
            return new Radian(Value / d);
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified object represents the same value.
        /// </summary>
        public override bool Equals(object obj)
        {
            var angle = obj as Angle;
            return !object.ReferenceEquals(angle, null) && Value.Equals(angle.ToRadian());
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
            return Value > angleUnit.ToRadian();
        }

        /// <summary>
        /// Gives a way to override the logic to compare two angle value and returns two if the right hand side operand is less than other operand.
        /// </summary>
        protected override bool LessThan(Angle angleUnit)
        {
            return Value < angleUnit.ToRadian();
        }

        /// <summary>
        /// Gives a way to override the logic of modulo operatio between two angle operand.
        /// </summary>
        protected override Angle Modulo(Angle angleUnit)
        {
            return new Radian( Value % angleUnit.ToRadian());
        }

        /// <summary>
        /// Gives a way to override the multiplication logic between two angle operand.
        /// </summary>
        protected override Angle Multiply(double d)
        {
            return new Radian(Value * d);
        }

        /// <summary>
        /// Normalizes the angle between 0 to 2PI radians.
        /// </summary>
        protected override double NormalizeAngle(double d)
        {
            double aValue = d;
            if (aValue > (2 * Math.PI))
                aValue %= (2 * Math.PI);
            else if (aValue < 0)
                aValue = 2 * Math.PI - (Math.Abs(aValue) % (2 * Math.PI));
            return aValue;
        }

        /// <summary>
        /// Gives a way to override the subtraction logic between two angle operand.
        /// </summary>
        protected override Angle Subtract(Angle angleUnit)
        {
            return new Radian( Value - angleUnit.ToRadian());
        }

        /// <summary>
        /// Converts the given angle to degree value.
        /// </summary>
        internal override double ToDegree()
        {
            return ((Value * 180.0d) / Math.PI);
        }

        /// <summary>
        /// Converts the given angle to radian value.
        /// </summary>
        internal override double ToRadian()
        {
            return Value;
        }
        #endregion

        #region operators
        /// <summary>
        /// Implicit casting between Degree and Radian.
        /// </summary>
        public static implicit operator Radian(Degree v)
        {
            return new Radian(v.ToRadian());
        }

        /// <summary>
        /// Implicit casting between double and Radian.
        /// </summary>
        public static implicit operator Radian(double value)
        {
            return new Radian(value);
        }

        /// <summary>
        /// Explicit casting between double and Radian.
        /// </summary>
        /// <param name="rad"></param>
        public static explicit operator double(Radian rad)
        {
            return rad.Value;
        }
        #endregion
    }
}
