using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Dto;
using RazorPagesMovie.Models;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages.SamplePages
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        [BindProperty]
        public Sample Sample { get; set; }

        public CreateModel(Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //--- usado com entity
            _context.Samples.Add(Sample);
            await _context.SaveChangesAsync();

            //SampleDto - funciona
            //var info = Sample;

            await Task.Delay(1);
            return Page();
        }


    }
}
