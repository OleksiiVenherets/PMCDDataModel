using System;

namespace PMCDataModel
{
    /// <summary>
    /// Interface for points
    /// </summary>
    /// <typeparam name="T">Generic type of points</typeparam>
    public interface IPoint<T> where T : struct, IComparable<T>, IEquatable<T>, IComparable, IFormattable, IConvertible
    {
    }
}
