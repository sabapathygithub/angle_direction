namespace AngleLib_Test.Direction
{
    /// <summary>
    /// Contains decleration of test methods which can be used to derive test cases for classes that will be extended from type Direction.
    /// </summary>
    interface IDirectionTest
    {
        void GetQuadrant_Degree();

        void GetQuadrant_Radian();

        void CastingMathAndCompassDirection();

        void GetDirection_Degree_NorthEast();

        void GetDirection_Degree_SouthEast();

        void GetDirection_Degree_NorthWest();

        void GetDirection_Degree_SouthWest();

        void GetDirection_Radian_NorthEast();

        void GetDirection_Radian_SouthEast();

        void GetDirection_Radian_NorthWest();

        void GetDirection_Radian_SouthWest();

    }
}
