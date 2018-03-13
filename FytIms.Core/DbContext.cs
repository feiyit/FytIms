using System;
using System.Collections.Generic;
using System.Text;
using FytIms.Core.Model;
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
                ConnectionString = "server=localhost;database=fytims;uid=root;pwd=123456;charset='utf8';SslMode=None",
                DbType = DbType.MySql,
                IsAutoCloseConnection = true
            });
        }
        public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作
        //public DbSet<SysAdmin> SysAdminDb => new DbSet<SysAdmin>(Db);
        public DbSet<SysAdmin> SysAdminDb { get { return new DbSet<SysAdmin>(Db); } }
    }
}
