using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RazorPagesMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RazorPagesMovie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;              

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public PageResult OnGet()
        {
           return Page();
        }

        public PageResult OnPost()
        {
            return Page();
        }

        public void OnPostSave()
        {
            ViewData["Message"] = "You clicked Save!";

        }

        public async Task<IActionResult> OnPostTempDataSample()
        {
            return Page();            
        }

    }
}
