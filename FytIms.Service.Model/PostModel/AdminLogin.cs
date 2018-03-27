using System;
using System.Collections.Generic;
using System.Text;

namespace FytIms.Service.Model.PostModel
{
    /// <summary>
    /// 管理员登录
    /// </summary>
    public class AdminLogin
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        public string loginname { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string loginpwd { get; set; }

        public string code { get; set; }
    }
}
