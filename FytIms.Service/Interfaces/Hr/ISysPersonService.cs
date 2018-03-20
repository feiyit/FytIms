using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core.Model.Hr;
using FytIms.Service.Model.PostModel;

namespace FytIms.Service.Interfaces.Hr
{
    /// <summary>
    /// 员工业务接口
    /// </summary>
    public interface ISysPersonService
    {
        /// <summary>
        /// 查询员工列表
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<List<SysPerson>>> GetListAsync(SysPersonPost parm);
    }
}
