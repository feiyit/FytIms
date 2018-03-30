using System;
using System.Threading.Tasks;
using FytIms.Common;
using FytIms.Common.ClientData;
using FytIms.Core;
using FytIms.Core.Model.Hr;
using FytIms.Service.Extensions;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;

namespace FytIms.Service.Implements
{
    /// <summary>
    /// 人员扩展信息工作经历业务实现
    /// </summary>
    public class SysPersonWorkService : DbContext, ISysPersonWorkService
    {
        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> AddAsync(SysPersonWorkPost parm)
        {
            var res = new ApiResult<string>();
            try
            {
                var newGuid = Guid.NewGuid().ToString();
                var model = new SysPersonWork()
                {
                    Guid = newGuid,
                    PersonGuid = parm.PersonGuid,
                    EntryTime = parm.EntryTime,
                    OutTime = parm.OutTime,
                    Address = parm.Address,
                    CompanyName = parm.CompanyName,
                    PostName = parm.PostName,
                    WorkContent =parm.WorkContent,
                    Witness=parm.Witness,
                    WitnessTel=parm.WitnessTel,
                    OutSummary=parm.OutSummary,
                    SalarySummary=parm.SalarySummary
                };
                var isok = SysPersonWorkDb.Insert(model);
                res.statusCode = isok ? (int)ApiEnum.Status : (int)ApiEnum.Error;
                res.data = newGuid;
            }
            catch (Exception ex)
            {
                res.statusCode = (int)ApiEnum.Error;
                res.message = ex.Message;
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> DeleteAsync(DeletePost parm)
        {
            var res = new ApiResult<string>();
            try
            {
                var list = Utils.StrToListString(parm.guid);
                var isok = SysPersonWorkDb.Delete(m => list.Contains(m.Guid));
                res.statusCode = isok ? (int)ApiEnum.Status : (int)ApiEnum.Error;
                res.data = "1";
                res.message = isok ? "删除成功~" : "删除失败~";
            }
            catch (Exception ex)
            {
                res.statusCode = (int)ApiEnum.Error;
                res.message = ex.Message;
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 根据条件查询一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<SysPersonWorkDto>> GetByGuidAsync(ByGuidPost parm)
        {
            var res = new ApiResult<SysPersonWorkDto>();
            try
            {
                var model = SysPersonWorkDb.GetById(parm.guid);
                res.statusCode = 200;
                res.data = model != null ? new SysPersonWorkDto()
                {
                    Guid = model.Guid,
                    PersonGuid=model.PersonGuid,
                    EntryTime = model.EntryTime,
                    OutTime = model.OutTime,
                    Address = model.Address,
                    CompanyName = model.CompanyName,
                    PostName = model.PostName,
                    WorkContent = model.WorkContent,
                    Witness = model.Witness,
                    WitnessTel = model.WitnessTel,
                    OutSummary = model.OutSummary,
                    SalarySummary = model.SalarySummary
                } : null;
            }
            catch (Exception ex)
            {
                res.statusCode = (int)ApiEnum.Error;
                res.message = ex.Message;
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<Page<SysPersonWorkDto>>> GetPagesAsync(SysPersonWorkPostPage parm)
        {
            var res = new ApiResult<Page<SysPersonWorkDto>>();
            try
            {
                using (Db)
                {
                    var query = Db.Queryable<SysPersonWork>()
                        .Where(m => m.PersonGuid == parm.guid)
                        .Select(m => new SysPersonWorkDto()
                        {
                            Guid = m.Guid,
                            EntryTime = m.EntryTime,
                            OutTime = m.OutTime,
                            Address = m.Address,
                            CompanyName = m.CompanyName,
                            PostName = m.PostName,
                            WorkContent = m.WorkContent,
                            Witness = m.Witness,
                            WitnessTel = m.WitnessTel,
                            OutSummary = m.OutSummary,
                            SalarySummary = m.SalarySummary
                        }).ToPageAsync(parm.page, parm.limit);
                    res.success = true;
                    res.message = "获取成功！";
                    res.data = await query;
                }
            }
            catch (Exception ex)
            {
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
                res.statusCode = (int)ApiEnum.Error;
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> ModifyAsync(SysPersonWorkPost parm)
        {
            var res = new ApiResult<string>();
            try
            {
                var isok = SysPersonWorkDb.Update(
                m => new SysPersonWork()
                {
                    EntryTime = parm.EntryTime,
                    OutTime = parm.OutTime,
                    Address = parm.Address,
                    CompanyName = parm.CompanyName,
                    PostName = parm.PostName,
                    WorkContent = parm.WorkContent,
                    Witness = parm.Witness,
                    WitnessTel = parm.WitnessTel,
                    OutSummary = parm.OutSummary,
                    SalarySummary = parm.SalarySummary
                }, m => m.Guid == parm.Guid);
                res.success = isok;
                res.statusCode = isok ? (int)ApiEnum.Status : (int)ApiEnum.Error;
                res.data = "1";
            }
            catch (Exception ex)
            {
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
                res.statusCode = (int)ApiEnum.Error;
            }
            return await Task.Run(() => res);
        }
    }
}
