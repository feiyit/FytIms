using System;
using System.Linq;
using System.Text;

namespace FytIms.Core.Model.Hr
{
    ///<summary>
    /// 人员表
    ///</summary>
    public partial class SysPerson
    {
        public SysPerson()
        {


        }
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
        public bool LoginStatus { get; set; }

        /// <summary>
        /// Desc:删除状态
        /// Default:b'0'
        /// Nullable:False
        /// </summary>           
        public bool DelStatus { get; set; }

        /// <summary>
        /// Desc:在职状态  0=离职1=在职
        /// Default:b'1'
        /// Nullable:False
        /// </summary>           
        public bool PostStatus { get; set; }

        /// <summary>
        /// Desc:审核状态
        /// Default:
        /// Nullable:False
        /// </summary>           
        public bool AuditStatus { get; set; }

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
        /// Desc:身份证图片
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string IDCardImg { get; set; }

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
        /// Desc:最后登录时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// Desc:登录次数
        /// Default:0
        /// Nullable:False
        /// </summary>           
        public int LoginSum { get; set; }

        /// <summary>
        /// Desc:苹果设备的唯一标识
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string IosToken { get; set; }

        /// <summary>
        /// Desc:安卓设备的唯一标识
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string AndRoidToken { get; set; }

        /// <summary>
        /// Desc:是否允许推送通知
        /// Default:b'1'
        /// Nullable:False
        /// </summary>           
        public bool IsPush { get; set; }

        /// <summary>
        /// Desc:设备名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DeviceName { get; set; }

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
