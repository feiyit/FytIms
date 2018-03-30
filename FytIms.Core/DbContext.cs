using System;
using System.Collections.Generic;
using System.Text;
using FytIms.Core.Model;
using FytIms.Core.Model.Hr;
using FytIms.Core.Model.Sys;
using SqlSugar;

namespace FytIms.Core
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public class DbContext
    {
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                //ConnectionString = "server=localhost;database=fyt_ims;uid=root;pwd=feiyit302050;charset='utf8';SslMode=None",
                ConnectionString = "server=localhost;database=fyt_ims;uid=root;pwd=123456;charset='utf8';SslMode=None",
                DbType = DbType.MySql,
                IsAutoCloseConnection = true
            });
        }
        public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作

        //系统权限设置
        public DbSet<SysCode> SysCodeDb => new DbSet<SysCode>(Db);
        public DbSet<SysCodeType> SysCodeTypeDb => new DbSet<SysCodeType>(Db);
        public DbSet<SysCompany> SysCompanyDb => new DbSet<SysCompany>(Db);
        public DbSet<SysDepartment> SysDepartmentDb => new DbSet<SysDepartment>(Db);
        public DbSet<SysImage> SysImageDb => new DbSet<SysImage>(Db);
        public DbSet<SysLog> SysLogDb => new DbSet<SysLog>(Db);
        public DbSet<SysMenu> SysMenuDb => new DbSet<SysMenu>(Db);
        public DbSet<SysPermissions> SysPermissionsDb => new DbSet<SysPermissions>(Db);
        public DbSet<SysRole> SysRoleDb => new DbSet<SysRole>(Db);
        public DbSet<SysRoleMenu> SysRoleMenuDb => new DbSet<SysRoleMenu>(Db);

        //人员设置
        public DbSet<SysPerson> SysPersonDb => new DbSet<SysPerson>(Db);
        public DbSet<SysPersonContact> SysPersonContactDb => new DbSet<SysPersonContact>(Db);
        public DbSet<SysPersonEducate> SysPersonEducateDb => new DbSet<SysPersonEducate>(Db);
        public DbSet<SysPersonWork> SysPersonWorkDb => new DbSet<SysPersonWork>(Db);
    }
}
