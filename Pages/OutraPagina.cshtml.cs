using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class OutraPaginaModel : PageModel
    {
        public Movie Movie { get; set; }

        public void OnGet()
        {
            if (TempData.Peek("ObjMovie") != null)
            {
                var resultado = TempData.ToList();
                //deserializando como objeto
                var objDeserializado = Newtonsoft.Json.JsonConvert.DeserializeObject(TempData.Peek("ObjMovie").ToString());
                //deserializando como objeto tipado Movie
                Movie = Newtonsoft.Json.JsonConvert.DeserializeObject<Movie>(TempData.Peek("ObjMovie").ToString());
                
            }
        }
    }
}
