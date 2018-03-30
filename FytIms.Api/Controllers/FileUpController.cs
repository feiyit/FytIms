using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FytIms.Common;
using FytIms.Common.ClientData;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FytIms.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/FileUp")]
    public class FileUpController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public FileUpController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// 上传头像
        /// </summary>
        /// <returns></returns>
        [HttpPost("upheadpic")]
        public ApiResult<string> FileUpHead()
        {
            var res = new ApiResult<string>();
            var files = Request.Form.Files[0];
            if (files != null)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                //文件上传到本地
                var fext = FileHelper.GetFileExt(files.FileName);
                var newFileName = Guid.NewGuid().ToString() + "." + fext;
                var newFilePath = webRootPath + "/themes/img/headpic/";
                var filePath = webRootPath + "/themes/img/headpic/" + newFileName;
                //判断是否有文件
                if (!FileHelper.IsExistDirectory(newFilePath))
                {
                    FileHelper.CreateFiles(newFilePath);
                }
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    files.CopyToAsync(stream);
                }
                res.data = "/themes/img/headpic/" + newFileName;
                res.success = true;
            }
            else
            {
                res.statusCode = 404;
                res.message = "没有图片";
                res.success = false;
            }
            return res;
        }
    }
}