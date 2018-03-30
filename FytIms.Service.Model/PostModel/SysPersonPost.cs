using System;
using System.Collections.Generic;
using System.Text;

namespace FytIms.Service.Model.PostModel
{
    public class SysPersonPost
    {
        /// <summary>
        /// Desc:唯一标识
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Guid { get; set; }


        public string key { get; set; }

        /// <summary>
        /// Desc:在职状态  0=离职1=在职
        /// Default:b'1'
        /// Nullable:False
        /// </summary>           
        public bool poststatus { get; set; } = true;

        public int limit { get; set; } = 10;

        public int page { get; set; } = 1;
    }
}
