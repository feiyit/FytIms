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
    public class ModifyWorkModel : PageModel
    {
        private readonly ISysPersonWorkService _sysPersonWorkService;
        public ModifyWorkModel(ISysPersonWorkService sysPersonWorkService)
        {
            _sysPersonWorkService = sysPersonWorkService;
        }

        [BindProperty]
        public SysPersonWorkDto Work { get; set; }
        public void OnGet(ByGuidPost parm)
        {
            Work = _sysPersonWorkService.GetByGuidAsync(parm).Result.data;
            if (Work == null)
            {
                Work = new SysPersonWorkDto() { PersonGuid = parm.guid };
            }
        }
    }
}