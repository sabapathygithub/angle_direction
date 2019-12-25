namespace AngleLib
{
    using System;

    /// <summary>
    /// An abstract class which provides base logic for different type of angular units.
    /// </summary>
    public abstract class Angle
    {
        /// <summary>
        /// Gets or sets the angle value.
        /// </summary>
        public double Value { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Angle"/> class.
        /// </summary>
        /// <param name="angleValue">An angle, measured in degrees which values between 0 to 360 degree or 0 to 2PI </param>
        protected Angle(double angle)
        {
            Value = angle;
        }

        #region Abstract methods
        /// <summary>
        /// Normalizes the angle value between the range 0 to 360 degree or 0 to 2PI radians.
        /// </summary>
        protected abstract double NormalizeAngle(double d);

        /// <summary>
        /// Gives a way to override the addition logic between two angle operand.
        /// </summary>
        protected abstract Angle Add(Angle angleUnit);

        /// <summary>
        /// Gives a way to override the subtraction logic between two angle operand.
        /// </summary>
        protected abstract Angle Subtract(Angle angleUnit);

        /// <summary>
        /// Gives a way to override the multiplication logic between two angle operand.
        /// </summary>
        protected abstract Angle Multiply(double d);

        /// <summary>
        /// Gives a way to override the division logic between two angle operand.
        /// </summary>
        protected abstract Angle Divide(double d);

        /// <summary>
        /// Gives a way to override the logic of modulo operatio between two angle operand.
        /// </summary>
        protected abstract Angle Modulo(Angle angleUnit);

        /// <summary>
        /// Gives a way to override the logic to compare two angle value and returns two if the right hand side operand is greater than other operand.
        /// </summary>
        protected abstract bool GreaterThan(Angle angleUnit);

        /// <summary>
        /// Gives a way to override the logic to compare two angle value and returns two if the right hand side operand is less than other operand.
        /// </summary>
        protected abstract bool LessThan(Angle angleUnit);

        /// <summary>
        /// Converts the given angle to degree value.
        /// </summary>
        internal abstract double ToDegree();

        /// <summary>
        /// Converts the given angle to radian value.
        /// </summary>
        internal abstract double ToRadian();
        #endregion

        #region Trigonometric methods
        /// <summary>
        /// Returns the sine of the specified angle.
        /// </summary>
        public double Sin()
        {
            return Math.Sin(ToRadian());
        }

        /// <summary>
        /// Returns the cosine of the specified angle.
        /// </summary>
        public double Cos()
        {
            return Math.Cos(ToRadian());
        }

        /// <summary>
        /// Returns the tangent of the specified angle.
        /// </summary>
        public double Tan()
        {
            return Math.Tan(ToRadian());
        } 

        /// <summary>
        /// Returns the angle whose sine is the specified value.
        /// </summary>
        public double ArcSin()
        {
            return Math.Asin(this.Sin());
        }

        /// <summary>
        /// Returns the angle whose cosine is the specified value.
        /// </summary>
        public double ArcCos()
        {
            return Math.Acos(this.Cos());
        }

        /// <summary>
        /// Returns the angle whose tangent is the specified value.
        /// </summary>
        public double ArcTan()
        {
            return Math.Atan(this.Tan());
        }
        #endregion

        #region Overrides

        /// <summary>
        /// Converts the given value into string.
        /// </summary>
        public override string ToString()
        {
            return Value.ToString();
        }

        /// <summary>
        /// Overrides the Equals method.
        /// </summary>
        public override bool Equals(object obj)
        {
            Angle angle = obj as Angle;
            return angle != null && Value.Equals(angle.Value);
        }

        /// <summary>
        /// Returns the hash code of this instance.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        #endregion

        #region Operators
        /// <summary>
        /// Performs addition between two operand of type Angle.
        /// </summary>
        public static Angle operator +(Angle a1, Angle a2)
        {
            return a1.Add(a2);
        }

        /// <summary>
        /// Performs subtraction between two operand of type Angle.
        /// </summary>
        public static Angle operator -(Angle a1, Angle a2)
        {
            return a1.Subtract(a2);
        }

        /// <summary>
        /// Performs multiplication between operand of type Angle and  type double.
        /// </summary>
        public static Angle operator *(Angle a, double d)
        {
            return a.Multiply(d);
        }

        /// <summary>
        /// Performs division between operand of type Angle and type double.
        /// </summary>
        public static Angle operator /(Angle a, double d)
        {
            return a.Divide(d);
        }

        /// <summary>
        /// Compares angles and returns true if left side operand are greater than right side operand.
        /// </summary>
        public static bool operator >(Angle a1, Angle a2)
        {
            return a1.GreaterThan(a2);
        }

        /// <summary>
        /// Compares angles and returns true if left side operand is less than right side operand.
        /// </summary>
        public static bool operator <(Angle a1, Angle a2)
        {
            return a1.LessThan(a2);
        }

        /// <summary>
        /// Compares angles and returns true if left side operand is equals to right side operand.
        /// </summary>
        public static bool operator ==(Angle a1, Angle a2)
        {
            if(object.ReferenceEquals(a1, null))
            {
                return object.ReferenceEquals(a2, null);
            }
            return a1.Equals(a2);
        }

        /// <summary>
        /// Compares angles and returns true if left side operand is not equals to right side operand.
        /// </summary>
        public static bool operator !=(Angle a1, Angle a2)
        {
            if (!object.ReferenceEquals(a1, null))
            {
                return !object.ReferenceEquals(a2, null);
            }
            return !a1.Equals(a2);
        }

        /// <summary>
        /// Calculates modulo between two angles and returns remainder.
        /// </summary>
        public static Angle operator %(Angle a1, Angle a2)
        {
            return a1.Modulo(a2);
        }
        #endregion
    }
}
