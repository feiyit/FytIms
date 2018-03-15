using System;
using System.Linq;
using System.Text;

namespace FytIms.Core.Model.Hr
{
    ///<summary>
    /// 人员信息扩展联系表
    ///</summary>
    public partial class SysPersonContact
    {
        public SysPersonContact()
        {


        }
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
        /// Desc:添加时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime AddTime { get; set; }

        /// <summary>
        /// Desc:修改时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime Edit { get; set; }

    }
}
