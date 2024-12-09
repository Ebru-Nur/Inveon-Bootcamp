using LibraryApp.Entities;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace LibraryApp.Caching
{
    public class CachingService
    {
        private readonly IDistributedCache _cache;
        private const string CacheKey = "BooksCache";

        public CachingService(IDistributedCache cache)
        {
            _cache = cache;
        }

        public async Task<IEnumerable<Book>> GetCachedBooks()
        {
            var cachedData = await _cache.GetStringAsync(CacheKey);
            return cachedData == null ? null : JsonSerializer.Deserialize<IEnumerable<Book>>(cachedData);
        }

        public async Task SetCachedBooks(IEnumerable<Book> books)
        {
            var serializedData = JsonSerializer.Serialize(books);
            var options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30)
            };
            await _cache.SetStringAsync(CacheKey, serializedData, options);
        }
    }

}
