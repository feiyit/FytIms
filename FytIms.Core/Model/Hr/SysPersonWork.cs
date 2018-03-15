using System;
using System.Linq;
using System.Text;

namespace FytIms.Core.Model.Hr
{
    ///<summary>
    /// 人员扩展信息 ，工作经历表
    ///</summary>
    public partial class SysPersonWork
    {
        public SysPersonWork()
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
        /// Desc:入职时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string EntryTime { get; set; }

        /// <summary>
        /// Desc:离职时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string OutTime { get; set; }

        /// <summary>
        /// Desc:在职地点
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Address { get; set; }

        /// <summary>
        /// Desc:公司名称
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string CompanyName { get; set; }

        /// <summary>
        /// Desc:职务
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string PostName { get; set; }

        /// <summary>
        /// Desc:工作内容
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string WorkContent { get; set; }

        /// <summary>
        /// Desc:证明人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Witness { get; set; }

        /// <summary>
        /// Desc:证明人联系方式
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string WitnessTel { get; set; }

        /// <summary>
        /// Desc:离职原因
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OutSummary { get; set; }

        /// <summary>
        /// Desc:薪资描述
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SalarySummary { get; set; }

    }
}
