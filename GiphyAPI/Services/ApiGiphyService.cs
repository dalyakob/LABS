using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using GiphyAPI.Models;

namespace GiphyAPI.Services
{
    public class ApiGiphyService : IGiphyService
    {
        
        private readonly HttpClient _client;

        public ApiGiphyService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Giphy> GetAll()
        {
            //var options = new JsonSerializerOptions
            //{
            //    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            //    PropertyNameCaseInsensitive = true
            //};
            var response = await _client.GetFromJsonAsync <Giphy>("search?q=funny%20cat&api_key=dc6zaTOxFJmzC");
            return response;
        }
    }
}
