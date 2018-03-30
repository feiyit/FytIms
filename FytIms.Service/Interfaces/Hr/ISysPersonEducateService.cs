using FytIms.Common.ClientData;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using System.Threading.Tasks;

namespace FytIms.Service.Interfaces
{
    /// <summary>
    /// 人员扩展教育业务接口
    /// </summary>
    public interface ISysPersonEducateService
    {
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<Page<SysPersonEducateDto>>> GetPagesAsync(SysPersonEducatePage parm);

        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<SysPersonEducateDto>> GetByGuidAsync(ByGuidPost parm);

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> AddAsync(SysPersonEducatePost parm);

        /// <summary>
        /// 删除一条或多条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> DeleteAsync(DeletePost parm);

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<string>> ModifyAsync(SysPersonEducatePost parm);
    }
}
