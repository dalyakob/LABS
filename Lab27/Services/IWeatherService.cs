using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lab27.Models;

namespace Lab27.Services
{
    public interface IWeatherService
    {
        Task<Weather> GetAll();
    }
}
