using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class EimantasModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Midse mirs 2021 04 22.";
        }
    }
}
