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

       
        public Movie ObjMovie { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public PageResult OnGet()
        {
            var obj = new Movie { ID = 1234, Genre = "xxxx", Price = 12, Rating = "ab", ReleaseDate = DateTime.Now, Title = "abcdef" };
            TempData["ObjMovie"] = JsonConvert.SerializeObject(obj);
            //HttpContext.Session.
            return Page();
        }

        public void OnPostSave()
        {
            ViewData["Message"] = "You clicked Save!";
        }

        public void Person(int valor)
        {

        }
    }
}
