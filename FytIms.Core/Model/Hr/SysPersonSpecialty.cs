using System;
using System.Linq;
using System.Text;

namespace FytIms.Core.Model.Hr
{
    ///<summary>
    /// 人员信息扩展  专业表
    ///</summary>
    public partial class SysPersonSpecialty
    {
        public SysPersonSpecialty()
        {


        }
        /// <summary>
        /// Desc:唯一标识
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Guid { get; set; }

        /// <summary>
        /// Desc:员工唯一标识
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string PersonGuid { get; set; }

        /// <summary>
        /// Desc:特长名称
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Name { get; set; }

        /// <summary>
        /// Desc:特长描述
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Summary { get; set; }

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
        public DateTime EditTime { get; set; }

    }
}
