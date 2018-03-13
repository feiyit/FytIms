using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using FytIms.Core.Model;

namespace FytIms.Service.Interfaces
{
    public interface ISysAdminService
    {
        Task<ApiResult<List<SysAdmin>>> GetListAsync();
    }
}
