using System;
using System.Collections.Generic;
using System.Text;

namespace FytIms.Service.Model.PostModel
{
    public class SysPersonEducatePage
    {
        public string guid { get; set; }

        public int limit { get; set; } = 10;

        public int page { get; set; } = 1;
    }
    public class SysPersonEducatePost
    {
        /// <summary>
        /// Desc:唯一标识
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Guid { get; set; }

        /// <summary>
        /// Desc:员工Gudi
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string PersonGuid { get; set; }

        /// <summary>
        /// Desc:类型如国立，私立，职业培训
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string EducateType { get; set; }

        /// <summary>
        /// Desc:入学时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime AdmissionTime { get; set; }

        /// <summary>
        /// Desc:毕业时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime GraduateTime { get; set; }

        /// <summary>
        /// Desc:院校名称
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string SchoolName { get; set; }

        /// <summary>
        /// Desc:专业
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Specialty { get; set; }
    }
}
