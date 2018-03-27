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
    public class CodesModifyModel : PageModel
    {
        private readonly ISysCodeTypeService _sysCodeTypeService;
        public CodesModifyModel(ISysCodeTypeService sysCodeTypeService)
        {
            _sysCodeTypeService = sysCodeTypeService;
        }

        [BindProperty]
        public SysCodeTypeDto CodeType { get; set; }

        [BindProperty]
        public List<SysCodeTypeDto> SelectList { get; private set; }

        public void OnGet(ByGuidPost parm)
        {
            CodeType = _sysCodeTypeService.GetByGuidAsync(parm).Result.data;
            //获得列表
            SelectList = _sysCodeTypeService.GetListAsync().Result.data;
        }

    }
}