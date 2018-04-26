using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FytIms.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FytIms.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData["vsCode"] = Utils.GetCheckCode(6);
        }
    }
}