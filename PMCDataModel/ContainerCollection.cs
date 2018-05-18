using System;
using System.Collections;
using System.Collections.Generic;

namespace PMCDataModel
{
    /// <summary>
    /// Class for an indexed collection of containers
    /// </summary>
    /// <typeparam name="T">Generic type of container collection</typeparam>
    public class ContainerCollection<T> : IDataCollection<T>
    {
        ICollection<T> containerCollection;

        /// <summary>
        /// Property to return count of elements in container
        /// </summary>
        public int Count
        {
            get { return containerCollection.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public ContainerCollection()
        {
            containerCollection = new List<T>();
        }

        /// <summary>
        /// Method to add items in container collection
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException($"The input parametr is null");
            containerCollection.Add(item);
        }

        /// <summary>
        /// Method for deleting all elements from container collection
        /// </summary>
        public void Clear()
        {
            containerCollection.Clear();
        }

        /// <summary>
        /// Method for checking is container collection contains specified item
        /// </summary>
        /// <param name="item">Item to  check</param>
        /// <returns>returns true if container colection contains item</returns>
        public bool Contains(T item)
        {
            return containerCollection.Contains(item);
        }

        /// <summary>
        /// Method to copy container collection to array
        /// </summary>
        /// <param name="array">Array to copy in</param>
        /// <param name="arrayIndex">start index</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            containerCollection.CopyTo(array, arrayIndex);
        }          

        /// <summary>
        /// Method to delete specified element from container
        /// </summary>
        /// <param name="item">item to delete</param>
        /// <returns>returns true if item deleted</returns>
        public bool Remove(T item)
        {
            return containerCollection.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return containerCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return containerCollection.GetEnumerator();
        }
    }
}
