using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GiphyAPI.Models;

namespace GiphyAPI.Services
{
    public interface IGiphyService
    {
        Task<Giphy> GetAll();
    }
}
