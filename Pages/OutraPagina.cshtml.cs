using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class OutraPaginaModel : PageModel
    {
        public void OnGet()
        {
            if (TempData.Peek("ObjMovie") != null)
            {
                var resultado = TempData.ToList();
            }
        }
    }
}
