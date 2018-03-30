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
    public class ModifyEducateModel : PageModel
    {
        private readonly ISysCodeService _sysCodeService;
        private readonly ISysPersonEducateService _sysPersonEducateService;
        public ModifyEducateModel(ISysPersonEducateService sysPersonEducateService,
            ISysCodeService sysCodeService)
        {
            _sysPersonEducateService = sysPersonEducateService;
            _sysCodeService = sysCodeService;
        }

        [BindProperty]
        public SysPersonEducateDto Educate { get; set; }

        [BindProperty]
        public List<SysCodeDto> codeList { get; private set; }
        public void OnGet(ByGuidPost parm)
        {
            codeList = _sysCodeService.GetPagesAsync(new SysCodePostPage() { limit = 1000, page = 1 }).Result.data.Items.Where(m=>m.status).ToList();
            Educate = _sysPersonEducateService.GetByGuidAsync(parm).Result.data;
            if (Educate == null)
            {
                Educate = new SysPersonEducateDto() { PersonGuid=parm.guid,AdmissionTime=null,GraduateTime=null};
            }
        }
    }
}