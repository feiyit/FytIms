using System;
using System.Collections.Generic;
using System.Text;

namespace FytIms.Service.Model.DtoModel
{
    public class SysCodeDto
    {
        public string guid { get; set; }
        public string parentguid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int sort { get; set; }
        public bool status { get; set; }
        public string summary { get; set; }
    }
}
