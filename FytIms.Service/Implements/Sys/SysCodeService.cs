using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core;
using FytIms.Core.Model;
using FytIms.Core.Model.Sys;
using FytIms.Service.Interfaces.Sys;
using SqlSugar;

namespace FytIms.Service.Implements.Sys
{
    /// <summary>
    /// 字典值实现
    /// </summary>
    public class SysCodeService : DbContext, ISysCodeService
    {
        public List<SysCode> GetList()
        {
            return SysCodeDb.GetList();
        }

        public async Task<ApiResult<List<SysCode>>> GetListAsync()
        {
            var res = new ApiResult<List<SysCode>>
            {
                statusCode = 200,
                data = SysCodeDb.GetList()
            };
            return await Task.Run(() => res);
;
        }
    }
}
