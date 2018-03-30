using FytIms.Common.ClientData;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using System.Threading.Tasks;

namespace FytIms.Service.Interfaces
{
    /// <summary>
    /// 人员扩展信息工作经历业务接口
    /// </summary>
    public interface ISysPersonWorkService
    {
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<Page<SysPersonWorkDto>>> GetPagesAsync(SysPersonWorkPostPage parm);

        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<SysPersonWorkDto>> GetByGuidAsync(ByGuidPost parm);

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> AddAsync(SysPersonWorkPost parm);

        /// <summary>
        /// 删除一条或多条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> DeleteAsync(DeletePost parm);

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> ModifyAsync(SysPersonWorkPost parm);
    }
}
