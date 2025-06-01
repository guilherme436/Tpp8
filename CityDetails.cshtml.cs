using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tp11.Models;
using Tp11.Services;

namespace Tp11.Pages
{
    public class CityDetailsModel : PageModel
    {
        private readonly ICityService _cityService;

        public CityDetailsModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        public City? City { get; set; }

        public async Task<IActionResult> OnGetAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return NotFound();

            City = await _cityService.GetByNameAsync(name);

            if (City == null)
                return NotFound();

            return Page();
        }
    }
}
