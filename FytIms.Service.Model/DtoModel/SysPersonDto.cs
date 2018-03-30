using System;
using System.Collections.Generic;
using System.Text;

namespace FytIms.Service.Model.DtoModel
{
    public class SysPersonModel
    {
        public string guid { get; set; }
        public string loginName { get; set; }
        public string codes { get; set; }
        public string trueName { get; set; }
        public string sex { get; set; }
        public string companyName { get; set; }
        public string departmentName { get; set; }
        public string postName { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
    }
    /// <summary>
    /// 员工信息返回对象
    /// </summary>
    public class SysPersonDto
    {
        /// <summary>
        /// Desc:唯一标识
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Guid { get; set; }

        /// <summary>
        /// Desc:角色Guid
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string RoleGuid { get; set; }

        /// <summary>
        /// Desc:部门Guid
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DepartmentGuid { get; set; }

        /// <summary>
        /// Desc:公司Guid
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CompayGuid { get; set; }

        /// <summary>
        /// Desc:登录账号
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string LoginName { get; set; }

        /// <summary>
        /// Desc:登录密码
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string LoginPwd { get; set; }
        public string LoginOldPwd { get; set; }

        /// <summary>
        /// Desc:真是姓名
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string TrueName { get; set; }

        /// <summary>
        /// Desc:员工编号
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Codes { get; set; }

        /// <summary>
        /// Desc:头像
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string HeadPic { get; set; }

        /// <summary>
        /// Desc:性别
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Sex { get; set; } = "男";

        /// <summary>
        /// Desc:手机号码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Mobile { get; set; }

        /// <summary>
        /// Desc:邮箱地址
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Email { get; set; }

        /// <summary>
        /// Desc:QQ号码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string QQ { get; set; }

        /// <summary>
        /// Desc:微信号码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string WebXin { get; set; }

        /// <summary>
        /// Desc:办公室电话
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string WorkTel { get; set; }

        /// <summary>
        /// Desc:状态 0=冻结1=正常
        /// Default:b'1'
        /// Nullable:False
        /// </summary>           
        public bool LoginStatus { get; set; } = true;

        public string LoginStr { get; set; }

        /// <summary>
        /// Desc:在职状态  0=离职1=在职
        /// Default:b'1'
        /// Nullable:False
        /// </summary>           
        public bool PostStatus { get; set; } = true;
        public string PostStr { get; set; }

        /// <summary>
        /// Desc:生日
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Desc:身份证号码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string IDCard { get; set; }

        /// <summary>
        /// Desc:籍贯
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string NativePlaceCity { get; set; }

        /// <summary>
        /// Desc:户口所在地
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string AccountCity { get; set; }

        /// <summary>
        /// Desc:居住地址
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string LiveCity { get; set; }

        /// <summary>
        /// Desc:政治面貌
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PoliticalStatus { get; set; }

        /// <summary>
        /// Desc:民族
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Ethnic { get; set; }

        /// <summary>
        /// Desc:信仰
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Faith { get; set; }

        /// <summary>
        /// Desc:婚姻
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Marriage { get; set; }

        /// <summary>
        /// Desc:学历
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Education { get; set; }

        /// <summary>
        /// Desc:个人爱好
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Hobbies { get; set; }

        /// <summary>
        /// Desc:语言能力
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string LanguageSkills { get; set; }

        /// <summary>
        /// Desc:语言能力
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string[] LanguageSkillsStr { get; set; }

        /// <summary>
        /// Desc:特长
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Specialty { get; set; }
    }
}
