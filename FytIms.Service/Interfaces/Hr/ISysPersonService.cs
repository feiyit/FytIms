using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core.Model.Hr;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;

namespace FytIms.Service.Interfaces
{
    /// <summary>
    /// 员工业务接口
    /// </summary>
    public interface ISysPersonService
    {
        /// <summary>
        /// 查询员工信息，提供APP使用
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<List<SysPersonAppDto>>> GetAppPersonList();

        /// <summary>
        /// 查询员工列表
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<Page<SysPersonModel>>> GetPagesAsync(SysPersonPost parm);

        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<SysPersonDto>> GetByGuidAsync(ByGuidPost parm);

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> AddAsync(SysPersonDto parm);

        /// <summary>
        /// 删除一条或多条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> DeleteAsync(DeletePost parm);

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> ModifyAsync(SysPersonDto parm);
    }
}
