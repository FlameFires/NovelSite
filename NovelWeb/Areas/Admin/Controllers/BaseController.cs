using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NovelWeb.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // 实例共有帮助类
        public Common.CommonHelper common = new Common.CommonHelper();

        
    }
}