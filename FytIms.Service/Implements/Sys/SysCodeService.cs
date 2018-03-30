using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common;
using FytIms.Common.ClientData;
using FytIms.Core;
using FytIms.Core.Model;
using FytIms.Core.Model.Sys;
using FytIms.Service.Extensions;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using SqlSugar;

namespace FytIms.Service.Implements
{
    /// <summary>
    /// 字典值实现
    /// </summary>
    public class SysCodeService : DbContext, ISysCodeService
    {
        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<SysCodeDto>> GetByGuidAsync(ByGuidPost parm)
        {
            var model = SysCodeDb.GetById(parm.guid);
            var res = new ApiResult<SysCodeDto>
            {
                statusCode = 200,
                data = model != null ? new SysCodeDto()
                {
                    guid = model.Guid,
                    parentguid=model.ParentGuid,
                    name = model.Name,
                    type = model.CodeType,
                    sort = model.Sort,
                    status = model.Status
                } : null
            };
            if (model == null)
            {
                var pmdel = Db.Queryable<SysCode>().OrderBy(m => m.Sort, OrderByType.Desc).First();
                res.data = new SysCodeDto() { status = true, sort = pmdel?.Sort + 1 ?? 1 };
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 添加一条记录
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> AddAsync(SysCodeDto parm)
        {
            var model = new SysCode()
            {
                Guid = Guid.NewGuid().ToString(),
                Name = parm.name,
                ParentGuid = parm.parentguid,
                CodeType = parm.type,
                Sort = parm.sort,
                Status = parm.status,
                Summary = parm.summary,
                AddTime = DateTime.Now,
                EditTime = DateTime.Now
            };
            var isok = SysCodeDb.Insert(model);
            var res = new ApiResult<string>
            {
                statusCode = isok ? (int)ApiEnum.Status : (int)ApiEnum.Error,
                data = isok ? "1" : "0"
            };
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<string>> DeleteAsync(DeletePost parm)
        {
            var list = Utils.StrToListString(parm.guid);
            var isok = SysCodeDb.Delete(m => list.Contains(m.Guid));
            var res = new ApiResult<string>
            {
                statusCode = isok ? (int)ApiEnum.Status : (int)ApiEnum.Error,
                data = isok ? "1" : "0",
                message = isok ? "删除成功~" : "删除失败~"
            };
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 查询列表，根据条件
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<Page<SysCodeDto>>> GetPagesAsync(SysCodePostPage parm)
        {
            var res = new ApiResult<Page<SysCodeDto>>();
            try
            {
                using (Db)
                {
                    var query = Db.Queryable<SysCode>()
                        .WhereIF(!string.IsNullOrEmpty(parm.guid), m => m.ParentGuid == parm.guid)
                        .OrderBy(m => m.Sort).Select(m => new SysCodeDto()
                        {
                            guid = m.Guid,
                            name = m.Name,
                            sort = m.Sort,
                            parentguid=m.ParentGuid,
                            status = m.Status,
                            type = m.CodeType
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
        /// 修改一条记录
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<string>> ModifyAsync(SysCodeDto parm)
        {
            var isok = SysCodeDb.Update(
                m => new SysCode()
                {
                    Name = parm.name,
                    CodeType = parm.type,
                    Summary = parm.summary,
                    Status = parm.status,
                    EditTime = DateTime.Now
                }, m => m.Guid == parm.guid);
            var res = new ApiResult<string>
            {
                success = isok,
                statusCode = isok? (int)ApiEnum.Status : (int)ApiEnum.Error,
                data = isok ? "1" : "0"
            };
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> ModifyStatusAsync(SysCodeDto parm)
        {
            var isok = SysCodeDb.Update(
                m => new SysCode()
                {
                    Status = parm.status,
                    EditTime = DateTime.Now
                }, m => m.Guid == parm.guid);
            var res = new ApiResult<string>
            {
                success = isok,
                statusCode = isok ? (int)ApiEnum.Status : (int)ApiEnum.Error,
                data = isok ? "1" : "0"
            };
            return await Task.Run(() => res);
        }
    }
}
