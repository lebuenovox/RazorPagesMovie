using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;
using System;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages
{
    public class BindSandboxModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }

        public void OnGet()
        {
            Movie = new Movie();
            Movie.ID = 147852;
            Movie.Title = "Star Wars 1";
            Movie.Genre = "Scyfi";
            Movie.Price = 111;
            Movie.ReleaseDate = DateTime.Now;
            
        }

        public async Task<IActionResult> OnPostValidar([FromForm] Movie dto)
        {
            var filme = dto;

            await Task.Delay(1);

            return Page();
        }

        public async Task<IActionResult> OnPostLogar([FromBody] Movie dto)
        {
            var filme = dto;

            await Task.Delay(1);

            return Page();
        }

    }
}
