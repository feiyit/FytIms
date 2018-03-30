using System;
using System.Collections.Generic;
using System.Text;

namespace FytIms.Service.Model.PostModel
{
    public class SysPersonContactPage
    {
        public string guid { get; set; }

        public int limit { get; set; } = 10;

        public int page { get; set; } = 1;
    }
    /// <summary>
    /// 紧急联系人入参
    /// </summary>
    public class SysPersonContactPost
    {
        /// <summary>
        /// Desc:唯一标识
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Guid { get; set; }

        /// <summary>
        /// Desc:员工Guid
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string PersonGuid { get; set; }

        /// <summary>
        /// Desc:联系人姓名
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Name { get; set; }

        /// <summary>
        /// Desc:联系人关系
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Relation { get; set; }

        /// <summary>
        /// Desc:联系方式
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Mobile { get; set; }

        /// <summary>
        /// Desc:联系地址
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Address { get; set; }

        /// <summary>
        /// Desc:是否为紧急联系人
        /// Default:b'0'
        /// Nullable:False
        /// </summary>           
        public bool IsUrgent { get; set; }

        /// <summary>
        /// Desc:是否为紧急联系人
        /// Default:b'0'
        /// Nullable:False
        /// </summary>           
        public string IsUrgentStr { get; set; }
    }
}
