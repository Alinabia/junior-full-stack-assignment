using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeanTask.Application.Interfaces.Services;
using LeanTask.Application.Interfaces.Services.Storage.Provider;

namespace LeanTask.Infrastructure.Services.Storage.Provider
{
    internal class ServerStorageProvider : IStorageProvider
    {
        private Dictionary<string, string> _storage = new();

        private readonly ICurrentUserService _currentUserService;

        public ServerStorageProvider(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public ValueTask ClearAsync()
            => throw new NotImplementedException(); 

        public ValueTask<string> GetItemAsync(string key)
        {
            if (_storage.ContainsKey(key))
                return ValueTask.FromResult(_storage[key]);

            return ValueTask.FromResult(string.Empty);
        }

        public ValueTask SetItemAsync(string key, string data)
        {
            if (_storage.ContainsKey(key))
            {
                _storage[key] = data;
            }
            else
            {
                _storage.Add(key, data);
            }

            return ValueTask.CompletedTask; 
        }

        public ValueTask<string> KeyAsync(int index)
            => throw new NotImplementedException(); 

        public ValueTask<bool> ContainKeyAsync(string key)
            => throw new NotImplementedException(); 

        public ValueTask<int> LengthAsync()
            => throw new NotImplementedException(); 

        public ValueTask RemoveItemAsync(string key)
            => throw new NotImplementedException();//_jSRuntime.InvokeVoidAsync("localStorage.removeItem", key);

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public string GetItem(string key)
        {
            throw new NotImplementedException();
        }

        public string Key(int index)
        {
            throw new NotImplementedException();
        }

        public bool ContainKey(string key)
        {
            throw new NotImplementedException();
        }

        public int Length()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(string key)
        {
            throw new NotImplementedException();
        }

        public void SetItem(string key, string data)
        {
            throw new NotImplementedException();
        }

        private void CheckForInProcessRuntime()
        {
            throw new NotImplementedException();
        }
    }
}