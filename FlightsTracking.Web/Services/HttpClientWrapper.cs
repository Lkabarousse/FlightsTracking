namespace FlightsTracking.Web.Services
{

    public class HttpClientWrapper<T> : IHttpClientWrapper<T>
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public HttpClientWrapper(string baseUrl)
        {
            _httpClient = new HttpClient();
            _baseUrl = baseUrl;
        }

        public async Task<T> GetAsync(string endpoint)
        {
            var url = _baseUrl.TrimEnd('/') + '/' + endpoint.TrimStart('/');
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                T? resultat = await response.Content.ReadFromJsonAsync<T>();
                return resultat;
            }
            else
            {
                return default;
            }
        }

        public async Task<List<T>> GetAllAsync(string endpoint)
        {

            var url = _baseUrl.TrimEnd('/') + '/' + endpoint.TrimStart('/');
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadFromJsonAsync<List<T>>();
                return res;
            }
            return null;
        }
    }

}
