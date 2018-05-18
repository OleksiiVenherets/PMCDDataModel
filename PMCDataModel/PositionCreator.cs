using System;

namespace PMCDataModel
{
    /// <summary>
    /// Class to create instance POsition
    /// </summary>
    /// <typeparam name="T">Generic type for point</typeparam>
    /// <typeparam name="T1">Generic type for position</typeparam>
    public class PositionCreator<T, T1> : DataCreator<T, T1> where T : struct, IComparable<T>, IEquatable<T>, IComparable, IFormattable, IConvertible
    {
        /// <summary>
        /// Factory method to create instance Position
        /// </summary>
        /// <returns></returns>
        public override IDataCollection<T1> Create()
        {
            return new Position<T1>();
        }
    }
}
