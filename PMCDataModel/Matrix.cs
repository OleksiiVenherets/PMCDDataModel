using System;
using System.Collections.Generic;
using System.Collections;

namespace PMCDataModel
{
    /// <summary>
    /// Class for an indexed collection of positions
    /// </summary>
    /// <typeparam name="T">Generic type of matrix</typeparam>
    public class Matrix<T> : IDataCollection<T>
    {
        ICollection<T> matrix;

        /// <summary>
        /// Property to return count of elements in container
        /// </summary>
        public int Count
        {
            get { return matrix.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Matrix()
        {
            matrix = new List<T>();
        }

        /// <summary>
        /// Method to add items in matrix
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException($"The input parametr is null");
            foreach (var position in matrix)
            {
                if (position.GetType() != item.GetType())
                {
                    throw new ArgumentException($"The type of position is not the same");
                }             
            }
            matrix.Add(item);
        }

        /// <summary>
        /// Method for deleting all elements from matrix
        /// </summary>
        public void Clear()
        {
            matrix.Clear();
        }

        /// <summary>
        /// Method for checking is matrix contains specified item
        /// </summary>
        /// <param name="item">Item to  check</param>
        /// <returns>returns true if matrix contains item</returns>
        public bool Contains(T item)
        {
            return matrix.Contains(item);
        }

        /// <summary>
        /// Method to copy matrix to array
        /// </summary>
        /// <param name="array">Array to copy in</param>
        /// <param name="arrayIndex">start index</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            matrix.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Method to delete specified element from matrix
        /// </summary>
        /// <param name="item">item to delete</param>
        /// <returns>returns true if item deleted</returns>
        public bool Remove(T item)
        {
            return matrix.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return matrix.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return matrix.GetEnumerator();
        }
    }
}
