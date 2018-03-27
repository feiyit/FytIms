using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.PostModel;
using FytIms.Service.Model.DtoModel;

namespace FytIms.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/codetype")]
    public class CodeTypeController : Controller
    {
        private readonly ISysCodeTypeService _sysCodeTypeService;
        public CodeTypeController(ISysCodeTypeService sysCodeTypeService)
        {
            _sysCodeTypeService = sysCodeTypeService;
        }

        /// <summary>
        /// 获得字典栏目Tree列表
        /// </summary>
        /// <returns></returns>
        [HttpPost("gettree")]
        public List<SysCodeTypeTree> GetListPage()
        {
            return _sysCodeTypeService.GetListTreeAsync().Result.data;
        }

        /// <summary>
        /// 获得字典栏目Tree列表
        /// </summary>
        /// <returns></returns>
        [HttpPost("add")]
        public async Task<ApiResult<string>> AddCodeType(SysCodeTypeDto parm)
        {
            return await _sysCodeTypeService.AddAsync(parm);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost("delete")]
        public async Task<ApiResult<string>> DeleteCode(DeletePost parm)
        {
            return await _sysCodeTypeService.DeleteAsync(parm);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost("edit")]
        public async Task<ApiResult<string>> EditCode(SysCodeTypeDto parm)
        {
            return await _sysCodeTypeService.ModifyAsync(parm);
        }
    }
}