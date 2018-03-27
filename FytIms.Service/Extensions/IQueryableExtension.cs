using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FytIms.Common.ClientData;
using SqlSugar;

namespace FytIms.Service.Extensions
{
    public static class QueryableExtension
    {
        /// <summary>
        /// 读取列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="isOrderBy"></param>
        /// <returns></returns>
        public static async Task<Page<T>> ToPageAsync<T>(this ISugarQueryable<T> query,
            int pageIndex,
            int pageSize,
            bool isOrderBy = false)
        {
            var page = new Page<T>();
            var totalItems = await query.CountAsync();
            var totalPages = totalItems != 0 ? (totalItems % pageSize) == 0 ? (totalItems / pageSize) : (totalItems / pageSize) + 1 : 0;
            page.CurrentPage = pageIndex;
            page.ItemsPerPage = pageSize;
            page.TotalItems = totalItems;
            page.TotalPages = totalPages;
            page.Items = totalItems == 0 ? null : await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return page;
        }
    }
}
