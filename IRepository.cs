using System.Collections.Generic;

namespace AdvancedCSharp
{
    // Q6: Generic interface IRepository<T> - defines a common contract
    // for storing and retrieving objects of type T, without knowing the
    // concrete type in advance.
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Remove(int id);
    }

    // A simple in-memory implementation used to demonstrate the interface.
    public class InMemoryRepository<T> : IRepository<T>
    {
        private readonly Dictionary<int, T> _store = new Dictionary<int, T>();
        private int _nextId = 1;

        public void Add(T entity)
        {
            _store[_nextId] = entity;
            _nextId++;
        }

        public T GetById(int id)
        {
            return _store.TryGetValue(id, out T value) ? value : default;
        }

        public IEnumerable<T> GetAll()
        {
            return _store.Values;
        }

        public void Remove(int id)
        {
            _store.Remove(id);
        }
    }
}
