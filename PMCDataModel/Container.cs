using System;
using System.Collections;
using System.Collections.Generic;

namespace PMCDataModel
{
    /// <summary>
    /// Class for an indexed collection of matrices
    /// </summary>
    /// <typeparam name="T">Generic type of container</typeparam>
    public class Container<T> : IDataCollection<T>
    {
        ICollection<T> container;

        /// <summary>
        /// Property to return count of elements in container
        /// </summary>
        public int Count
        {
            get { return container.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Container()
        {
            container = new List<T>();
        }

        /// <summary>
        /// Method to add items in container
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException($"The input parametr is null");
            foreach (var matrix in container)
            {
                if (matrix.GetType() != item.GetType())
                {
                    throw new ArgumentException($"The type of matrix is not the same");
                }
            }
            container.Add(item);
        }

        /// <summary>
        /// Method for deleting all elements from container
        /// </summary>
        public void Clear()
        {
            container.Clear();
        }

        /// <summary>
        /// Method for checking is container contains specified item
        /// </summary>
        /// <param name="item">Item to  check</param>
        /// <returns>returns true if container contains item</returns>
        public bool Contains(T item)
        {
            return container.Contains(item);
        }

        /// <summary>
        /// Method to copy container to array
        /// </summary>
        /// <param name="array">Array to copy in</param>
        /// <param name="arrayIndex">start index</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            container.CopyTo(array, arrayIndex);
        }
               
        /// <summary>
        /// Method to delete specified element from container
        /// </summary>
        /// <param name="item">item to delete</param>
        /// <returns>returns true if item deleted</returns>
        public bool Remove(T item)
        {
            return container.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return container.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return container.GetEnumerator();
        }
    }
}
