using System.Collections.Generic;

namespace AdvancedCSharp
{
    // Q13: The 'default' keyword returns the default value of a generic
    // type T: 0 / 0.0 / false for value types, and null for reference
    // types. It is used because you cannot write "null" or "0" directly
    // when you don't know if T is a value type or reference type.

    // Q14: SafeList<T> - returns default(T) instead of throwing when the
    // requested index is out of range.
    public class SafeList<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T GetSafe(int index)
        {
            if (index < 0 || index >= _items.Count)
                return default;

            return _items[index];
        }

        public int Count => _items.Count;
    }
}
