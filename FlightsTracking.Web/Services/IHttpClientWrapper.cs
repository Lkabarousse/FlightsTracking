namespace FlightsTracking.Web.Services
{
    public interface IHttpClientWrapper<T>
    {
        Task<List<T>> GetAllAsync(string endpoint);
        Task<T> GetAsync(string endpoint);
    }
}
