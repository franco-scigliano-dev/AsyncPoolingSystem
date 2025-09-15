using System.Threading.Tasks;
using UnityEngine;
using com.fscigliano.AsyncInitialization;
using com.fscigliano.PoolingSystem;

namespace com.fscigliano.AsyncPoolingSystem
{
    public class AsyncPoolManager : PoolManager, IInitializable
    {
        [SerializeField] private bool _isEnabled = true;

        public bool IsEnabled => _isEnabled;

        public async Task InitAsync()
        {
            if (!IsEnabled)
            {
                Debug.LogWarning($"[AsyncPoolManager:{name}] Component is disabled, skipping initialization.");
                return;
            }

            await InitializePoolsAsync();
        }
    }
}