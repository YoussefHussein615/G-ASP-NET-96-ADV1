using System;
using System.Collections.Generic;

namespace AdvancedCSharp
{
    // Q20: Complete Exercise - Cache<TKey, TValue> with Add, Get, Remove,
    // Contains, and expiration support.
    public class Cache<TKey, TValue>
    {
        private class CacheEntry
        {
            public TValue Value;
            public DateTime ExpiresAt;
        }

        private readonly Dictionary<TKey, CacheEntry> _store = new Dictionary<TKey, CacheEntry>();
        private readonly TimeSpan _defaultTtl;

        public Cache(TimeSpan? defaultTtl = null)
        {
            _defaultTtl = defaultTtl ?? TimeSpan.FromMinutes(5);
        }

        public void Add(TKey key, TValue value, TimeSpan? ttl = null)
        {
            _store[key] = new CacheEntry
            {
                Value = value,
                ExpiresAt = DateTime.UtcNow.Add(ttl ?? _defaultTtl)
            };
        }

        public bool TryGet(TKey key, out TValue value)
        {
            if (_store.TryGetValue(key, out CacheEntry entry))
            {
                if (entry.ExpiresAt > DateTime.UtcNow)
                {
                    value = entry.Value;
                    return true;
                }

                // Expired: clean it up.
                _store.Remove(key);
            }

            value = default;
            return false;
        }

        public bool Contains(TKey key)
        {
            return TryGet(key, out _);
        }

        public void Remove(TKey key)
        {
            _store.Remove(key);
        }

        public int Count => _store.Count;
    }
}
