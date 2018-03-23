using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core;
using FytIms.Core.Model.Hr;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.PostModel;

namespace FytIms.Service.Implements
{
    /// <summary>
    /// 员工业务实现
    /// </summary>
    public class SysPersonService:DbContext,ISysPersonService
    {
        /// <summary>
        /// 查询员工列表
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<List<SysPerson>>> GetListAsync(SysPersonPost parm)
        {
            var res = new ApiResult<List<SysPerson>>
            {
                statusCode = 200,
                data = SysPersonDb.GetList()
            };
            return await Task.Run(() => res);
            ;
        }
    }
}
