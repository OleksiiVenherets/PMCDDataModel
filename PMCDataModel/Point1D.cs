using System;

namespace PMCDataModel
{
    /// <summary>
    /// Class for one-dimensional point
    /// </summary>
    /// <typeparam name="T">type of point</typeparam>
    public class Point1D<T> : IPoint<T> where T : struct, IComparable<T>, IEquatable<T>, IComparable, IFormattable, IConvertible
    {
        private readonly T x;

        public T X => x;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="coordinate">coordinate of point</param>
        public Point1D(T coordinate)
        {
            x = coordinate;
        }


        public override string ToString()
        {
            return $"x:{x}";
        }
    }
}
