using System;

namespace PMCDataModel
{
    /// <summary>
    /// Class for one-dimensional point
    /// </summary>
    /// <typeparam name="T">type of point</typeparam>
    public class Point3D<T> : IPoint<T> where T : struct, IComparable<T>, IEquatable<T>, IComparable, IFormattable, IConvertible
    {
        private readonly T x;
        private readonly T y;
        private readonly T z;

        public T X => x;
        public T Y => y;
        public T Z => z;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstCoordinate">Coordiante x of point</param>
        /// <param name="secondCoordiante">Coordiante y of point</param>
        /// <param name="thirdCoordinate">Coordiante z of point</param>
        public Point3D(T firstCoordinate, T secondCoordiante, T thirdCoordinate)
        {
            x = firstCoordinate;
            y = secondCoordiante;
            z = thirdCoordinate;
        }

        public override string ToString()
        {
            return $"x:{x}; y: {y}; z:{z}";
        }
    }
}
