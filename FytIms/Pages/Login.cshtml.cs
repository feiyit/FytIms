using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FytIms.Common;

namespace FytIms.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            ViewData["vsCode"] = Utils.GetCheckCode(6);
        }
    }
}