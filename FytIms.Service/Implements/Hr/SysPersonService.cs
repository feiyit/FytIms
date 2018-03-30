using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common;
using FytIms.Common.ClientData;
using FytIms.Core;
using FytIms.Core.Model.Hr;
using FytIms.Core.Model.Sys;
using FytIms.Service.Extensions;
using FytIms.Service.Interfaces;
using FytIms.Service.Model.DtoModel;
using FytIms.Service.Model.PostModel;
using SqlSugar;

namespace FytIms.Service.Implements
{
    /// <summary>
    /// 员工业务实现
    /// </summary>
    public class SysPersonService:DbContext,ISysPersonService
    {
        /// <summary>
        /// 添加员工基本信息
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> AddAsync(SysPersonDto parm)
        {
            var res = new ApiResult<string>();
            try
            {
                parm.HeadPic = !string.IsNullOrEmpty(parm.HeadPic) ? parm.HeadPic : "/themes/img/headpic.png";
                parm.LoginPwd = DESCrypt.Encrypt(parm.LoginPwd);
                var newGuid = Guid.NewGuid().ToString();
                var model = new SysPerson()
                {
                    Guid = newGuid,
                    RoleGuid = parm.RoleGuid,
                    DepartmentGuid = parm.DepartmentGuid,
                    CompayGuid = parm.CompayGuid,
                    LoginName = parm.LoginName,
                    LoginPwd = parm.LoginPwd,
                    TrueName = parm.TrueName,
                    Codes = parm.Codes,
                    HeadPic = parm.HeadPic,
                    Sex = parm.Sex,
                    Mobile = parm.Mobile,
                    Email = parm.Email,
                    QQ = parm.QQ,
                    WebXin = parm.WebXin,
                    WorkTel = parm.WorkTel,
                    LoginStatus = parm.LoginStatus,
                    DelStatus = false,
                    PostStatus = parm.PostStatus,
                    AuditStatus = true,
                    Birthday = parm.Birthday,
                    IDCard = parm.IDCard,
                    NativePlaceCity = parm.NativePlaceCity,
                    AccountCity = parm.AccountCity,
                    LiveCity = parm.LiveCity,
                    PoliticalStatus = parm.PoliticalStatus,
                    Ethnic = parm.Ethnic,
                    Faith = parm.Faith,
                    Marriage = parm.Marriage,
                    Education = parm.Education,
                    Hobbies = parm.Hobbies,
                    LanguageSkills = parm.LanguageSkills,
                    Specialty=parm.Specialty,
                    AddTime = DateTime.Now,
                    EditTime = DateTime.Now
                };
                var isok = SysPersonDb.Insert(model);
                res.statusCode = isok ? (int)ApiEnum.Status : (int)ApiEnum.Error;
                res.data = newGuid;     
            }
            catch (Exception ex)
            {
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
                res.statusCode = (int)ApiEnum.Error;
                res.success = false;
            }            
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 删除员工信息
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> DeleteAsync(DeletePost parm)
        {
            var list = Utils.StrToListString(parm.guid);
            var isok = SysPersonDb.Delete(m => list.Contains(m.Guid));
            var res = new ApiResult<string>
            {
                statusCode = isok ? (int)ApiEnum.Status : (int)ApiEnum.Error,
                data = isok ? "1" : "0",
                message = isok ? "删除成功~" : "删除失败~"
            };
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 根据ID查询员工信息
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<SysPersonDto>> GetByGuidAsync(ByGuidPost parm)
        {
            var model = SysPersonDb.GetById(parm.guid);
            var res = new ApiResult<SysPersonDto>
            {
                statusCode = 200,
                data = model != null ? new SysPersonDto()
                {
                    Guid = model.Guid,
                    RoleGuid=model.RoleGuid,
                    DepartmentGuid=model.DepartmentGuid,
                    CompayGuid=model.CompayGuid,
                    LoginPwd=model.LoginPwd,
                    LoginName = model.LoginName,
                    TrueName = model.TrueName,
                    Codes = model.Codes,
                    HeadPic = model.HeadPic,
                    Sex=model.Sex,
                    Mobile=model.Mobile,
                    Email=model.Email,
                    QQ=model.QQ,
                    WebXin=model.WebXin,
                    WorkTel=model.WorkTel,
                    LoginStatus=model.LoginStatus,
                    PostStatus=model.PostStatus,
                    Birthday=model.Birthday,
                    IDCard=model.IDCard,
                    NativePlaceCity=model.NativePlaceCity,
                    AccountCity=model.AccountCity,
                    LiveCity=model.LiveCity,
                    PoliticalStatus=model.PoliticalStatus,
                    Ethnic=model.Ethnic,
                    Faith=model.Faith,
                    Marriage=model.Marriage,
                    Education=model.Education,
                    Hobbies=model.Hobbies,
                    LanguageSkills=model.LanguageSkills,
                    Specialty=model.Specialty
                } : null
            };            
            return await Task.Run(() => res);
        }

        /// <summary>
        /// 查询员工列表
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<Page<SysPersonModel>>> GetPagesAsync(SysPersonPost parm)
        {
            var res = new ApiResult<Page<SysPersonModel>>();
            try
            {
                var query = Db.Queryable<SysPerson>()
                        .WhereIF(!string.IsNullOrEmpty(parm.key), m => m.TrueName.Contains(parm.key) || m.LoginName.Contains(parm.key) || m.Mobile== parm.key || m.Email== parm.key)
                        .Where(m => m.PostStatus == parm.poststatus)
                        .OrderBy(m => m.EditTime, OrderByType.Desc).Select(m => new SysPersonModel()
                        {
                            guid = m.Guid,
                            loginName = m.LoginName,
                            trueName = m.TrueName,
                            codes = m.Codes,
                            companyName =SqlFunc.Subqueryable<SysCompany>().Where(s => s.Guid == m.CompayGuid).Select(s => s.Name),
                            departmentName= SqlFunc.Subqueryable<SysDepartment>().Where(s => s.Guid == m.DepartmentGuid).Select(s => s.Name),
                            postName = "高级软件工程师",
                            sex = m.Sex,
                            mobile = m.Mobile,
                            email = m.Email,
                        }).ToPage(parm.page, parm.limit);
                res.success = true;
                res.message = "获取成功！";
                res.data = query;
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
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<string>> ModifyAsync(SysPersonDto parm)
        {
            var res = new ApiResult<string>();
            try
            {
                parm.LoginStatus = string.IsNullOrEmpty(parm.LoginStr) ? false : true;
                parm.PostStatus = string.IsNullOrEmpty(parm.PostStr) ? false : true;
                if (parm.LanguageSkillsStr.Length>0)
                {
                    parm.LanguageSkills = string.Join(',', parm.LanguageSkillsStr);
                }
                if (parm.LoginPwd=="111111")
                {
                    parm.LoginPwd = parm.LoginOldPwd;
                }
                else
                {
                    parm.LoginPwd = DESCrypt.Encrypt(parm.LoginPwd);
                }
                parm.HeadPic = !string.IsNullOrEmpty(parm.HeadPic) ? parm.HeadPic : "/themes/img/headpic.png";
                var isok = SysPersonDb.Update(
                m => new SysPerson()
                {
                    RoleGuid = parm.RoleGuid,
                    DepartmentGuid = parm.DepartmentGuid,
                    CompayGuid = parm.CompayGuid,
                    LoginName = parm.LoginName,
                    LoginPwd = parm.LoginPwd,
                    TrueName = parm.TrueName,
                    Codes = parm.Codes,
                    HeadPic = parm.HeadPic,
                    Sex = parm.Sex,
                    Mobile = parm.Mobile,
                    Email = parm.Email,
                    QQ = parm.QQ,
                    WebXin = parm.WebXin,
                    WorkTel = parm.WorkTel,
                    LoginStatus = parm.LoginStatus,
                    PostStatus =parm.PostStatus,
                    Birthday = parm.Birthday,
                    IDCard = parm.IDCard,
                    NativePlaceCity = parm.NativePlaceCity,
                    AccountCity = parm.AccountCity,
                    LiveCity = parm.LiveCity,
                    PoliticalStatus = parm.PoliticalStatus,
                    Ethnic = parm.Ethnic,
                    Faith = parm.Faith,
                    Marriage = parm.Marriage,
                    Education = parm.Education,
                    Hobbies = parm.Hobbies,
                    LanguageSkills = parm.LanguageSkills,
                    Specialty = parm.Specialty,
                    EditTime = DateTime.Now
                }, m => m.Guid == parm.Guid);
                res.success = isok;
                res.statusCode = isok ? (int)ApiEnum.Status : (int)ApiEnum.Error;
                res.data = isok ? "1" : "0";
            }
            catch (Exception ex)
            {
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
                res.statusCode = (int)ApiEnum.Error;
                res.success = false;
            }
            return await Task.Run(() => res);
        }
    }
}
