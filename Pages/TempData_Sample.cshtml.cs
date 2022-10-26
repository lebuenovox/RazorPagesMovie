using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RazorPagesMovie.Models;
using System;

namespace RazorPagesMovie.Pages
{
    public class TempData_SampleModel : PageModel
    {
        public void OnGet()
        {
            var obj = new Movie { ID = 1234, Genre = "xxxx", Price = 12, Rating = "ab", ReleaseDate = DateTime.Now, Title = "abcdef" };
            TempData["ObjMovie"] = JsonConvert.SerializeObject(obj);
            //HttpContext.Session.
        }
    }
}
