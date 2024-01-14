namespace DAL.Cache
{
    public interface ICacheService
    {
        T GetData<T>(string key);
        Task<T> GetDataAsync<T>(string key);
        bool SetData<T>(string key, T value, DateTimeOffset expirationTime);
        bool RemoveData(string key);
    }
}
