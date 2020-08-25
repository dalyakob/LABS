using FinalCapstoneProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace FinalCapstoneProject.Services
{
    public class ApiCarService : ICarService
    {
        private readonly HttpClient _client;

        public ApiCarService(HttpClient client)
        {
            _client = client;
        }
        public async Task Create(Car car)
        {
            await _client.PostAsJsonAsync("Cars", car);
        }

        public async Task<Car> Get(int id)
        {
            return await _client.GetFromJsonAsync<Car>($"Cars/{id}");
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            return await _client.GetFromJsonAsync<IEnumerable<Car>>("Cars");
        }
        public async Task Edit(int id, Car car)
        {
            await _client.PutAsJsonAsync($"Cars/{id}", car);
        }

        public async Task Delete(int id)
        {
            await _client.DeleteAsync($"Cars/{id}");
        }

        public async Task<IEnumerable<Car>> Search(Car car)
        {

            var allCars = await _client.GetFromJsonAsync<IEnumerable<Car>>("Cars");
            var results = allCars.Where(x =>
                                    x.Color == car.Color ||
                                    x.Make == car.Make ||
                                    x.Year == car.Year ||
                                    x.Model == car.Model).ToList();

            return results;
        }
    }
}
