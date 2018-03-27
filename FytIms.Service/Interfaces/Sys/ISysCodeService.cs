using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core.Model.Sys;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;

namespace FytIms.Service.Interfaces
{
    /// <summary>
    /// 字典值接口
    /// </summary>
    public interface ISysCodeService
    {
        /// <summary>
        /// 获得列表
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<Page<SysCodeDto>>> GetPagesAsync(SysCodePostPage request);

        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<SysCodeDto>> GetByGuidAsync(ByGuidPost parm);

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> AddAsync(SysCodeDto parm);

        /// <summary>
        /// 删除一条或多条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> DeleteAsync(DeletePost parm);

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> ModifyAsync(SysCodeDto parm);

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> ModifyStatusAsync(SysCodeDto parm);
    }
}
