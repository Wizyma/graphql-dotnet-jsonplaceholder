using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonPlaceholder.Api.Repositories
{
    public abstract class JsonPlaceholderProxy
    {
        private const string _host = "https://jsonplaceholder.typicode.com";

        private readonly string _resource;

        public JsonPlaceholderProxy(string ressource)
        {
            _resource = ressource;
        }

        protected async Task<T> Get<T>(string query = "") where T: new()
        {
            // when using something that use a stream we need to make sure we 
            // dispose of it (close it)
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"{_host}/{_resource}{query}");

                var content = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(content);
            }
        }

    }
}
