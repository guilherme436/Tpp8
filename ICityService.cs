using Tp11.Models;
using Tpp8.Data.models;

namespace Tp11.Services
{
    public interface ICityService
    {
        Task<City?> GetByNameAsync(string name);

    }
}