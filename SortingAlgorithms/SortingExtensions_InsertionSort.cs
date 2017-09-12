using System;
using System.Collections.Generic;

namespace SortingExtensions
{
    /// <summary>
    /// A static class providing sorting extension methods for <see cref="IList{T}"/> objects
    /// </summary>
    public static partial class SortingExtensions
    {
        /// <summary>
        /// An Insertion Sort extension method for classes that implement <see cref="IList{T}"/>
        /// </summary>
        /// <typeparam name="T">The type of item the provided <see cref="IList{T}"/> contains</typeparam>
        /// <param name="theList">The <see cref="IList{T}"/> being sorted</param>
        /// <returns>The now-sorted <see cref="IList{T}"/></returns>
        public static IList<T> InsertionSort<T>(this IList<T> theList) where T:IComparable<T>
        {
            IComparer<T> defaultComparer = Comparer<T>.Default;
            return theList.InsertionSort(defaultComparer);
        }

        /// <summary>
        /// An Insertion Sort extension method for classes that implement <see cref="IList{T}"/>
        /// </summary>
        /// <typeparam name="T">The type of item the provided <see cref="IList{T}"/> contains</typeparam>
        /// <param name="theList">The <see cref="IList{T}"/> being sorted</param>
        /// <param name="theComparer">A <see cref="IComparer{T}"/> that determines the ordering of the elements in the list</param>
        /// <returns>The now-sorted <see cref="IList{T}"/></returns>
        public static IList<T> InsertionSort<T>(this IList<T> theList, IComparer<T> theComparer)
        {
            for (int i=0; i<theList.Count; i++)
            {
                for (int j=0; j<i; j++)
                {
                    //If theList[i]<theList[j]
                    if (theComparer.Compare(theList[i], theList[j])<0)
                    {
                        //move the element at i to the position j and shift all the elements at j onwards down
                        theList.Move(i, j);
                        break;
                    }
                }
            }
            return theList;
        }
    }
}
