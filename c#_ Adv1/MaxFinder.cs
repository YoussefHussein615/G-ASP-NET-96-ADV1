using System;
using System.Collections.Generic;

namespace AdvancedCSharp
{
    // Q5: Generic method FindMax<T> that finds the maximum value in a
    // collection. T is constrained to IComparable<T> so the elements can
    // be compared to each other.
    public static class MaxFinder
    {
        public static T FindMax<T>(IEnumerable<T> items) where T : IComparable<T>
        {
            IEnumerator<T> enumerator = items.GetEnumerator();

            if (!enumerator.MoveNext())
                throw new InvalidOperationException("Sequence contains no elements.");

            T max = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(max) > 0)
                    max = enumerator.Current;
            }

            return max;
        }
    }
}
