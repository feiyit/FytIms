using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FytIms.Pages.OA.Sys
{
    public class CodesValModifyModel : PageModel
    {
        private readonly ISysCodeService _sysCodeService;
        public CodesValModifyModel(ISysCodeService sysCodeService)
        {
            _sysCodeService = sysCodeService;
        }

        [BindProperty]
        public SysCodeDto CodeModel { get; set; }
        public void OnGet(ByGuidPost parm)
        {
            CodeModel = _sysCodeService.GetByGuidAsync(parm).Result.data;
            if (string.IsNullOrEmpty(CodeModel.guid))
            {
                CodeModel.parentguid = parm.guid;
            }
        }
    }
}