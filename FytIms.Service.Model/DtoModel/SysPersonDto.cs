using System;
using System.Collections.Generic;
using System.Text;

namespace FytIms.Service.Model.DtoModel
{
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
        /// Desc:登录账号
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string LoginName { get; set; }

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
        public string Sex { get; set; }

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
        /// Desc:状态 0=冻结1=正常
        /// Default:b'1'
        /// Nullable:False
        /// </summary>           
        public bool LoginStatus { get; set; }
    }
}
