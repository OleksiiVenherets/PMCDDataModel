using System;

namespace PMCDataModel
{
    /// <summary>
    /// Class to create instance ContainerCollection
    /// </summary>
    /// <typeparam name="T">Generic type for point</typeparam>
    /// <typeparam name="T1">Generic type for container collection</typeparam>
    public class ContainerCollectionCreator<T, T1> : DataCreator<T, T1> where T : struct, IComparable<T>, IEquatable<T>, IComparable, IFormattable, IConvertible
    {
        /// <summary>
        /// Factory method to create instance ContainerCollection
        /// </summary>
        /// <returns></returns>
        public override IDataCollection<T1> Create()
        {
            return new ContainerCollection<T1>();
        }
    }
}
