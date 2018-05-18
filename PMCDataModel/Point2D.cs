using System;

namespace PMCDataModel
{
    /// <summary>
    /// Class for two-dimensional point
    /// </summary>
    /// <typeparam name="T">type of point</typeparam>
    public class Point2D<T> : IPoint<T> where T : struct, IComparable<T>, IEquatable<T>, IComparable, IFormattable, IConvertible
    {
        private readonly T x;
        private readonly T y;

        public T X => x;
        public T Y => y;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstCoordinate">coordinate x of point</param>
        /// <param name="secondCoordinate">coordinate y of point</param>
        public Point2D(T firstCoordinate, T secondCoordinate)
        {
            x = firstCoordinate;
            y = secondCoordinate;
        }

        public override string ToString()
        {
            return $"x:{x}; y: {y}";
        }
    }
}


