using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Service.Model.PostModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FytIms.Api.Controllers
{
    //[Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        [Route("{id:int=5}/test")]
        [HttpGet]
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "value1", "value2"+id };
        }

        [Route("tests")]
        [HttpGet]
        public ApiResult<SysPersonPost> Tests(SysPersonPost parm)
        {
            var res = new ApiResult<SysPersonPost>
            {
                statusCode = 200,
                data = parm
            };
            return res;
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