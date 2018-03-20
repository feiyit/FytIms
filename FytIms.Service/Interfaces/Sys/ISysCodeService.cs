using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core.Model.Sys;

namespace FytIms.Service.Interfaces.Sys
{
    /// <summary>
    /// 字典值接口
    /// </summary>
    public interface ISysCodeService
    {
        Task<ApiResult<List<SysCode>>> GetListAsync();
    }
}
