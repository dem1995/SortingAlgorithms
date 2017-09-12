using System.Collections;
using System.Collections.Generic;

namespace SortingExtensions
{
    /// <summary>
    /// Extra extension methods for classes that implement <see cref="IList{T}"/>.
    /// </summary>
    public static class ExtraMethodExtensions
    {

        /// <summary>
        /// Swaps the /i/th and /j/th element of the provided <see cref="IList{T}"/>
        /// </summary>
        /// <typeparam name="T">The type of element that the provided <see cref="IList{T}"/> contains.</typeparam>
        /// <param name="theList">The <see cref="IList{T}"/> whose elements we are swapping</param>
        /// <param name="i">The index of one of the elements we are swapping with the other</param>
        /// <param name="j">The index of the other element with which we are swapping</param>
        public static void Swap<T>(this IList<T> theList, int i, int j)
        {
            T temp = theList[i];
            theList[i] = theList[j];
            theList[j] = temp;
        }

        /// <summary>
        /// Extension method for classes that implement <see cref="IList{T}"/>.
        /// Moves the element at the /from/ index of the provided <see cref="IList{T}"/> to the /to/ index and moves all elements at positions after the /to/ index down one.
        /// </summary>
        /// <typeparam name="T">The type of element the <see cref="IList{T}"/> being sorted contains</typeparam>
        /// <param name="theList">The <see cref="IList{T}"/> being sorted</param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static void Move<T>(this IList<T> theList, int from, int to)
        {
            if (!((IList)theList).IsFixedSize)
            {
                //If the list is resizable

                theList.Insert(to, theList[from]);
                theList.RemoveAt(from + 1);
            }

            else
            {
                //If the list has a static size
                T temp = theList[from];
                for (int intermediateIndex = from; intermediateIndex > to; intermediateIndex--)
                {
                    theList[intermediateIndex] = theList[intermediateIndex - 1];
                }
                theList[to] = temp;
            }
        }
    }
}
