using System;

namespace PMCDataModel
{
    /// <summary>
    /// Abstract class for creators
    /// </summary>
    /// <typeparam name="T">Generic type for point</typeparam>
    /// <typeparam name="T1">Generic type for collection</typeparam>
    public abstract class DataCreator<T, T1> where T : struct, IComparable<T>, IEquatable<T>, IComparable, IFormattable, IConvertible
    {
        public abstract IDataCollection<T1> Create();
    }
}
