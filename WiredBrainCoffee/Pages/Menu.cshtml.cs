using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WiredBrainCoffee.Pages
{
    public class MenuModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
        }
    }
}
