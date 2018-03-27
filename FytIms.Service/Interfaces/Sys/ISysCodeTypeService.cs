using FytIms.Common.ClientData;
using FytIms.Core.Model.Sys;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FytIms.Service.Interfaces
{
    /// <summary>
    /// 字典分类接口
    /// </summary>
    public interface ISysCodeTypeService
    {
        /// <summary>
        /// 获得列表
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<List<SysCodeTypeDto>>> GetListAsync();

        /// <summary>
        /// 获得树列表
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<List<SysCodeTypeTree>>> GetListTreeAsync();

        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<SysCodeTypeDto>> GetByGuidAsync(ByGuidPost parm);

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> AddAsync(SysCodeTypeDto parm);

        /// <summary>
        /// 删除一条或多条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> DeleteAsync(DeletePost parm);

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> ModifyAsync(SysCodeTypeDto parm);
    }
}
