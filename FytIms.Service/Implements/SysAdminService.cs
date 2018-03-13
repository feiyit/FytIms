using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core;
using FytIms.Core.Model;
using FytIms.Service.Interfaces;
using SqlSugar;

namespace FytIms.Service.Implements
{
    public class SysAdminService : DbContext,ISysAdminService
    {
        public List<SysAdmin> GetList()
        {
            return SysAdminDb.GetList();
        }

        public async Task<ApiResult<List<SysAdmin>>> GetListAsync()
        {
            ApiResult<List<SysAdmin>> res = new ApiResult<List<SysAdmin>>
            {
                statusCode = 200,
                data = SysAdminDb.GetList()
            };
            return res;
        }
    }
}
