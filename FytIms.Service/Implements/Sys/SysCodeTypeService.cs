using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common;
using FytIms.Common.ClientData;
using FytIms.Core;
using FytIms.Core.Model.Sys;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using SqlSugar;

namespace FytIms.Service.Implements
{
    /// <summary>
    /// 字典分类
    /// </summary>
    public class SysCodeTypeService : DbContext, ISysCodeTypeService
    {
        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> AddAsync(SysCodeTypeDto parm)
        {
            var model=new SysCodeType()
            {
                Guid = Guid.NewGuid().ToString(),
                Name = parm.name,
                ParentGuid = parm.parent,
                Layer = !string.IsNullOrEmpty(parm.parent)?1:0,
                Sort = parm.sort,
                AddTime = DateTime.Now,
                EditTime = DateTime.Now
            };
            var res = new ApiResult<string>
            {
                statusCode = 200,
                data = SysCodeTypeDb.Insert(model)?"1":"0"
            };
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 删除一条或多条数据
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<string>> DeleteAsync(DeletePost parm)
        {
            var isok = SysCodeTypeDb.Delete(m => m.Guid==parm.guid);
            var res = new ApiResult<string>
            {
                statusCode = isok?200:500,
                data = isok ? "1" : "0",
                message = isok?"删除成功~":"删除失败~"
            };
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<SysCodeTypeDto>> GetByGuidAsync(ByGuidPost parm)
        {
            var model = SysCodeTypeDb.GetById(parm.guid);
            var res = new ApiResult<SysCodeTypeDto>
            {
                statusCode = 200,
                data = model!=null?new SysCodeTypeDto()
                {
                    guid=model.Guid,
                    name=model.Name,
                    parent = model.ParentGuid,
                    sort=model.Sort
                }:null
            };
            if (model==null)
            {
                var pmdel = Db.Queryable<SysCodeType>().OrderBy(m => m.Sort,OrderByType.Desc).First();
                res.data=new SysCodeTypeDto(){sort = pmdel?.Sort + 1 ?? 1 };
            }
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 获得列表
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<List<SysCodeTypeDto>>> GetListAsync()
        {
            var res = new ApiResult<List<SysCodeTypeDto>>
            {
                statusCode = 200,
                data = Db.Queryable<SysCodeType>().OrderBy(m=>m.Sort).Select(m=>new SysCodeTypeDto() {
                    guid=m.Guid,
                    name=m.Name,
                    parent = m.ParentGuid,
                    sort=m.Sort
                }).ToList()
            };
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 获得树实现
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<List<SysCodeTypeTree>>> GetListTreeAsync()
        {
            var list = SysCodeTypeDb.GetList();
            var treeList = new List<SysCodeTypeTree>();
            foreach (var item in list.Where(m=>m.Layer==0).OrderBy(m=>m.Sort))
            {
                //获得子级
                var children= new List<SysCodeTypeTree>();
                foreach (var row in list.Where(m => m.ParentGuid == item.Guid).OrderBy(m => m.Sort))
                {
                    children.Add(new SysCodeTypeTree()
                    {
                        guid = row.Guid,
                        name = row.Name,
                        children = null
                    });
                }
                treeList.Add(new SysCodeTypeTree() {
                    guid=item.Guid,
                    name=item.Name,
                    children= children
                });
            }
            var res = new ApiResult<List<SysCodeTypeTree>>
            {
                statusCode = 200,
                data = treeList
            };
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<string>> ModifyAsync(SysCodeTypeDto parm)
        {
            var res = new ApiResult<string>
            {
                statusCode = 200,
                data = SysCodeTypeDb.Update(m=>new SysCodeType() {Name=parm.name,EditTime=DateTime.Now },m=>m.Guid==parm.guid) ? "1" : "0"
            };
            return await Task.Run(() => res);
        }
    }
}
