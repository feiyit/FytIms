using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core.Model.Hr;
using FytIms.Service.Interfaces;
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
        public PersonController(ISysPersonService sysPersonService)
        {
            _sysPersonService = sysPersonService;
        }

        [Route("{id:int=5}/test")]
        [HttpGet]
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "value1", "value2"+id };
        }

        /// <summary>
        /// 获得人事列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpPost("getlist")]
        public async Task<ApiResult<List<SysPerson>>> GetListPage(SysPersonPost parm)
        {
            return await _sysPersonService.GetListAsync(parm);
        }

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