using System;
using System.Collections;
using System.Collections.Generic;

namespace PMCDataModel
{
    /// <summary>
    /// Class for an indexed collection of points
    /// </summary>
    /// <typeparam name="T">Generic type of position</typeparam>
    public class Position<T> : IDataCollection<T>
    {
        ICollection<T> position;

        /// <summary>
        /// Property to return count of elements in container
        /// </summary>
        public int Count
        {
            get { return position.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Position()
        {
            position = new List<T>();
        }

        /// <summary>
        /// Method to add items in position
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException($"The input parametr is null");
            position.Add(item);
        }

        /// <summary>
        /// Method for deleting all elements from position
        /// </summary>
        public void Clear()
        {
            position.Clear();
        }

        /// <summary>
        /// Method for checking is position contains specified item
        /// </summary>
        /// <param name="item">Item to  check</param>
        /// <returns>returns true if position contains item</returns>
        public bool Contains(T item)
        {
            return position.Contains(item);
        }

        /// <summary>
        /// Method to copy position to array
        /// </summary>
        /// <param name="array">Array to copy in</param>
        /// <param name="arrayIndex">start index</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            position.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Method to delete specified element from position
        /// </summary>
        /// <param name="item">item to delete</param>
        /// <returns>returns true if item deleted</returns>
        public bool Remove(T item)
        {
            return position.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return position.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return position.GetEnumerator();
        }      
    }
}
