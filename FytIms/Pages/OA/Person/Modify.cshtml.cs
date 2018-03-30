using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FytIms.Common;
using FytIms.Common.ClientData;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FytIms.Pages.OA.Person
{
    public class ModifyModel : PageModel
    {
        private readonly ISysCodeService _sysCodeService;
        private readonly ISysPersonService _sysPersonService;        
        public ModifyModel(ISysCodeService sysCodeService, ISysPersonService sysPersonService)
        {
            _sysCodeService = sysCodeService;
            _sysPersonService = sysPersonService;
        }

        public SysPersonDto Person { get; private set; }

        [BindProperty]
        public List<SysCodeDto> codeList { get; private set; }
        public void OnGet(ByGuidPost parm)
        {
            codeList = _sysCodeService.GetPagesAsync(new SysCodePostPage() { limit = 1000, page = 1 }).Result.data.Items;
            Person = _sysPersonService.GetByGuidAsync(parm).Result.data??new SysPersonDto();
        }        
    }
}