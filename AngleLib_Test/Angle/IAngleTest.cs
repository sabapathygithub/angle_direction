namespace AngleLib_Test.Angle
{
    /// <summary>
    /// Contains decleration of test methods which can be used to derive test cases for classes that will be extended from type Angle.
    /// </summary>
    public interface IAngleTest
    {
        void Add_Angles();
        
        void Subtract_Angles();

        void Multiply_AngleAndDouble();
        
        void Divide_AngleAndDouble();

        void Modulo_Angles();
    
        void Angles_Equals();

        void Angles_NotEquals();
        
        void Angles_GreaterThan();
        
        void Angles_LessThan();

        void Sin_Angle();

        void Cos_Angle();

        void Tan_Angle();

        void ArcSin_Angle();

        void ArcCos_Angle();

        void ArcTan_Angle();
    }
}
