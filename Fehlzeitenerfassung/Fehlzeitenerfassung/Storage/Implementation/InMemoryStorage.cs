﻿using System;
using System.Collections.Generic;

namespace Fehlzeitenerfassung.Storage.Implementation
{
    internal class InMemoryStorage : IStorage
    {
        private Dictionary<string, object> _data;

        public InMemoryStorage()
        {
            _data = new Dictionary<string, object>();
        }

        public void Store(string key, object obj) => _data[key] = obj;

        public T Access<T>(string key)
        {
            if (!Exists(key))
                throw new ArgumentException($"An object stored by the key {key} was not found");
            return (T)_data[key];
        }

        public bool Exists(string key) => _data.ContainsKey(key);
    }
}