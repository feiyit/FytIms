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
    /// 员工教育业务实现
    /// </summary>
    public class SysPersonEducateService : DbContext, ISysPersonEducateService
    {
        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> AddAsync(SysPersonEducatePost parm)
        {
            var res = new ApiResult<string>();
            try
            {
                var newGuid = Guid.NewGuid().ToString();
                var model = new SysPersonEducate()
                {
                    Guid = newGuid,
                    PersonGuid = parm.PersonGuid,
                    EducateType = parm.EducateType,
                    AdmissionTime = parm.AdmissionTime,
                    GraduateTime = parm.GraduateTime,
                    SchoolName = parm.SchoolName,
                    Specialty = parm.Specialty
                };
                var isok = SysPersonEducateDb.Insert(model);
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
                var isok = SysPersonEducateDb.Delete(m => list.Contains(m.Guid));
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
        /// 根据主见查询一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<SysPersonEducateDto>> GetByGuidAsync(ByGuidPost parm)
        {
            var res = new ApiResult<SysPersonEducateDto>();
            try
            {
                var model = SysPersonEducateDb.GetById(parm.guid);
                res.statusCode = 200;
                res.data = model != null ? new SysPersonEducateDto()
                {
                    Guid = model.Guid,
                    PersonGuid=model.PersonGuid,
                    EducateType = model.EducateType,
                    AdmissionTime = model.AdmissionTime,
                    GraduateTime = model.GraduateTime,
                    SchoolName = model.SchoolName,
                    Specialty = model.Specialty
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
        /// 查询分页
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<Page<SysPersonEducateDto>>> GetPagesAsync(SysPersonEducatePage parm)
        {
            var res = new ApiResult<Page<SysPersonEducateDto>>();
            try
            {
                using (Db)
                {
                    var query = Db.Queryable<SysPersonEducate>()
                        .Where(m => m.PersonGuid == parm.guid)
                        .Select(m => new SysPersonEducateDto()
                        {
                            Guid = m.Guid,
                            EducateType = m.EducateType,
                            AdmissionTime = m.AdmissionTime,
                            GraduateTime = m.GraduateTime,
                            SchoolName = m.SchoolName,
                            Specialty = m.Specialty
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
        /// 更新一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> ModifyAsync(SysPersonEducatePost parm)
        {
            var res = new ApiResult<string>();
            try
            {
                var isok = SysPersonEducateDb.Update(
                m => new SysPersonEducate()
                {
                    EducateType = parm.EducateType,
                    AdmissionTime = parm.AdmissionTime,
                    GraduateTime = parm.GraduateTime,
                    SchoolName = parm.SchoolName,
                    Specialty = parm.Specialty
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
