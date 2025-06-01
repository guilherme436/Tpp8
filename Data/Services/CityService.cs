using Microsoft.EntityFrameworkCore;
using Tp11.Data;
using Tp11.Models;
using Tpp8.Data.models;
using Tpp8.Data.Services;

namespace Tp11.Services
{
    public class CityService : ICityService
    {
        private readonly CityBreaksContext _context;

        public CityService(CityBreaksContext context)
        {
            _context = context;
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _context.Cities
                .Include(c => c.Country)
                .Include(c => c.Properties)
                .ToListAsync();
        }
    }
}