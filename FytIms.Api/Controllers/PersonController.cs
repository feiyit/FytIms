using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core.Model.Hr;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FytIms.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        private readonly ISysPersonService _sysPersonService;
        private readonly ISysPersonContactService _sysPersonContactService;
        private readonly ISysPersonEducateService _sysPersonEducateService;
        private readonly ISysPersonWorkService _sysPersonWorkService;
        public PersonController(ISysPersonService sysPersonService,
            ISysPersonContactService sysPersonContactService,
            ISysPersonEducateService sysPersonEducateService,
            ISysPersonWorkService sysPersonWorkService)
        {
            _sysPersonService = sysPersonService;
            _sysPersonContactService = sysPersonContactService;
            _sysPersonEducateService = sysPersonEducateService;
            _sysPersonWorkService = sysPersonWorkService;
        }

        #region 员工基本信息
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("getpages")]
        public async Task<JsonResult> GetPages(SysPersonPost request)
        {
            var res = await _sysPersonService.GetPagesAsync(request);
            return Json(new { code = 0, msg = "success", count = res.data.TotalItems, data = res.data.Items });
        }

        /// <summary>
        /// 获得字典栏目Tree列表
        /// </summary>
        /// <returns></returns>
        [HttpPost("add")]
        public async Task<ApiResult<string>> AddCodeType(SysPersonDto parm)
        {
            return await _sysPersonService.AddAsync(parm);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost("delete")]
        public async Task<ApiResult<string>> DeleteCode(DeletePost parm)
        {
            return await _sysPersonService.DeleteAsync(parm);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPost("edit")]
        public async Task<ApiResult<string>> EditCode(SysPersonDto parm)
        {
            return await _sysPersonService.ModifyAsync(parm);
        }
        #endregion

        #region 员工联系人Api
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("getcontactpages")]
        public async Task<JsonResult> GetContactPages(SysPersonContactPage request)
        {
            var res = await _sysPersonContactService.GetPagesAsync(request);
            return Json(new { code = 0, msg = "success", count = res.data.TotalItems, data = res.data.Items });
        }

        /// <summary>
        /// 获得字典栏目Tree列表
        /// </summary>
        /// <returns></returns>
        [HttpPost("addcontact")]
        public async Task<ApiResult<string>> AddContact(SysPersonContactPost parm)
        {
            return await _sysPersonContactService.AddAsync(parm);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost("delcontact")]
        public async Task<ApiResult<string>> DeleteContact(DeletePost parm)
        {
            return await _sysPersonContactService.DeleteAsync(parm);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPost("editcontact")]
        public async Task<ApiResult<string>> EditContact(SysPersonContactPost parm)
        {
            return await _sysPersonContactService.ModifyAsync(parm);
        }
        #endregion

        #region 员工教育经历Api
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("geteducatepages")]
        public async Task<JsonResult> GetEducatePages(SysPersonEducatePage request)
        {
            var res = await _sysPersonEducateService.GetPagesAsync(request);
            return Json(new { code = 0, msg = "success", count = res.data.TotalItems, data = res.data.Items });
        }

        /// <summary>
        /// 获得字典栏目Tree列表
        /// </summary>
        /// <returns></returns>
        [HttpPost("addeducate")]
        public async Task<ApiResult<string>> AddEducate(SysPersonEducatePost parm)
        {
            return await _sysPersonEducateService.AddAsync(parm);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost("deleducate")]
        public async Task<ApiResult<string>> DeleteEducate(DeletePost parm)
        {
            return await _sysPersonEducateService.DeleteAsync(parm);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPost("editeducate")]
        public async Task<ApiResult<string>> EditEducate(SysPersonEducatePost parm)
        {
            return await _sysPersonEducateService.ModifyAsync(parm);
        }
        #endregion

        #region 员工工作经历Api
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("getworkpages")]
        public async Task<JsonResult> GetWorkPages(SysPersonWorkPostPage request)
        {
            var res = await _sysPersonWorkService.GetPagesAsync(request);
            return Json(new { code = 0, msg = "success", count = res.data.TotalItems, data = res.data.Items });
        }

        /// <summary>
        /// 获得字典栏目Tree列表
        /// </summary>
        /// <returns></returns>
        [HttpPost("addwork")]
        public async Task<ApiResult<string>> AddWork(SysPersonWorkPost parm)
        {
            return await _sysPersonWorkService.AddAsync(parm);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost("delwork")]
        public async Task<ApiResult<string>> DeleteWork(DeletePost parm)
        {
            return await _sysPersonWorkService.DeleteAsync(parm);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPost("editwork")]
        public async Task<ApiResult<string>> EditWork(SysPersonWorkPost parm)
        {
            return await _sysPersonWorkService.ModifyAsync(parm);
        }
        #endregion

        [Route("val")]
        [HttpPost]
        public ApiResult<string> Values()
        {
            var res = new ApiResult<string>
            {
                statusCode = 200,
                data = "aaaaaaaaaaaaa"
            };
            return res;
        }
    }
}