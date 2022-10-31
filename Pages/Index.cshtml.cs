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

        public Steps LocalSteps { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public PageResult OnGet()
        {
            LocalSteps = new Steps(false, false,false);
            return Page();
        }

        public PageResult OnPost()
        {
            return Page();
        }

        public void OnPostStep1()
        {
            LocalSteps = new Steps(true, false, false);
        }
        public void OnPostStep2()
        {
            LocalSteps = new Steps(false, true, false);
        }

        public void OnPostStep3()
        {
            LocalSteps = new Steps(false, false, true);
        }

        public IActionResult OnPostTempDataSample()
        {
            return RedirectToPage("BindSandbox");
        }

    }
}
