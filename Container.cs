using System;
using System.Collections.Generic;

namespace AdvancedCSharp
{
    // Q2: Generic class Container<T> with Add and Get methods.
    public class Container<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _items[index];
        }

        public int Count => _items.Count;
    }
}
