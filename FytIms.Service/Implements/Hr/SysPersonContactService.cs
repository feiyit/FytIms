using System;
using System.Collections.Generic;
using System.Text;
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
    /// 员工联系扩展业务实现
    /// </summary>
    public class SysPersonContactService : DbContext, ISysPersonContactService
    {
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> AddAsync(SysPersonContactPost parm)
        {
            var res = new ApiResult<string>();
            try
            {
                parm.IsUrgent = string.IsNullOrEmpty(parm.IsUrgentStr) ? false : true;
                var newGuid = Guid.NewGuid().ToString();
                var model = new SysPersonContact()
                {
                    Guid = newGuid,
                    Name = parm.Name,
                    PersonGuid=parm.PersonGuid,
                    Relation = parm.Relation,
                    Mobile = parm.Mobile,
                    Address = parm.Address,
                    IsUrgent = parm.IsUrgent,
                    AddTime = DateTime.Now,
                    EditTime = DateTime.Now
                };
                var isok = SysPersonContactDb.Insert(model);
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
        /// 删除记录
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> DeleteAsync(DeletePost parm)
        {
            var res = new ApiResult<string>();
            try
            {
                var list = Utils.StrToListString(parm.guid);
                var isok = SysPersonContactDb.Delete(m => list.Contains(m.Guid));
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
        /// 根据条件，查询一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<SysPersonContactDto>> GetByGuidAsync(ByGuidPost parm)
        {
            var res = new ApiResult<SysPersonContactDto>();
            try
            {
                var model = SysPersonContactDb.GetById(parm.guid);
                res.statusCode = 200;
                res.data = model != null ? new SysPersonContactDto()
                {
                    Guid = model.Guid,
                    Name = model.Name,
                    Relation = model.Relation,
                    Mobile = model.Mobile,
                    Address = model.Address,
                    IsUrgent = model.IsUrgent
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
        /// 查询列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<Page<SysPersonContactDto>>> GetPagesAsync(SysPersonContactPage parm)
        {
            var res = new ApiResult<Page<SysPersonContactDto>>();
            try
            {
                using (Db)
                {
                    var query = Db.Queryable<SysPersonContact>()
                        .Where(m => m.PersonGuid == parm.guid)
                        .OrderBy(m => m.AddTime).Select(m => new SysPersonContactDto()
                        {
                            Guid = m.Guid,
                            Name = m.Name,
                            Relation = m.Relation,
                            Mobile = m.Mobile,
                            Address = m.Address,
                            IsUrgent = m.IsUrgent
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
        /// 修改一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> ModifyAsync(SysPersonContactPost parm)
        {
            var res = new ApiResult<string>();
            try
            {
                parm.IsUrgent = string.IsNullOrEmpty(parm.IsUrgentStr) ? false : true;
                var isok = SysPersonContactDb.Update(
                m => new SysPersonContact()
                {
                    Name = parm.Name,
                    Relation = parm.Relation,
                    Mobile = parm.Mobile,
                    Address = parm.Address,
                    IsUrgent = parm.IsUrgent,
                    EditTime = DateTime.Now
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
