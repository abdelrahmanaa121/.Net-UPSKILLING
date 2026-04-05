using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Cache<TKey, TValue>
    {
        private readonly int _maxSize;
        private readonly Dictionary<TKey,LinkedListNode<CacheItem>> _map;
        private readonly LinkedList<CacheItem> _list;
        public Cache(int maxsize)
        {
            _maxSize = maxsize;
            _map = new Dictionary<TKey, LinkedListNode<CacheItem>>();
            _list = new LinkedList<CacheItem>();
        }

        //Add or Update
        public void Add(TKey key , TValue value)
        {
            if (_map.ContainsKey(key))
            {
                Remove(key);
            }
            else if (_map.Count >= _maxSize)
            {
                Evict();
            }
            var newnode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
            _list.AddFirst(newnode);
            _map[key] = newnode;
        }

        //Retrieve
        public TValue Get(TKey key)
        {
            if (!_map.TryGetValue(key,out var node))
            {
                throw new KeyNotFoundException("Key not found in cache.");
            }
            _list.Remove(node);
            _list.AddFirst(node);
            return node.Value.Value;
        }

        //Methods
        public void Remove(TKey key)
        {
            if (_map.TryGetValue(key, out var node))
            {
                _list.Remove(node);
                _map.Remove(key);
            }
        }
        public void Evict()
        {
            var last = _list.Last;
            if (last != null)
            {
                _map.Remove(last.Value.Key);
                _list.RemoveLast();
            }
        }
        //helper class
        private class CacheItem
        {
            public TKey Key { get; }
            public TValue Value { get; }
            public CacheItem(TKey key,TValue value)
            {
                Key = key;
                Value = value;
            }
        }
    }

}
