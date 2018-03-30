using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FytIms.Pages.OA.Person
{
    public class ModifyContactModel : PageModel
    {
        private readonly ISysPersonContactService _sysPersonContactService;
        public ModifyContactModel(ISysPersonContactService sysPersonContactService)
        {
            _sysPersonContactService = sysPersonContactService;
        }

        [BindProperty]
        public SysPersonContactDto Contact { get; set; }
        public void OnGet(ByGuidPost parm)
        {
            Contact = _sysPersonContactService.GetByGuidAsync(parm).Result.data;
            if (Contact==null)
            {
                Contact = new SysPersonContactDto() { PersonGuid = parm.guid };
            }
        }
    }
}