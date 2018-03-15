using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core;
using FytIms.Core.Model;
using FytIms.Core.Model.Sys;
using FytIms.Service.Interfaces;
using SqlSugar;

namespace FytIms.Service.Implements
{
    public class SysCodeService : DbContext, ISysCodeService
    {
        public List<SysCode> GetList()
        {
            return SysCodeDb.GetList();
        }

        public async Task<ApiResult<List<SysCode>>> GetListAsync()
        {
            ApiResult<List<SysCode>> res = new ApiResult<List<SysCode>>
            {
                statusCode = 200,
                data = SysCodeDb.GetList()
            };
            return res;
        }
    }
}
