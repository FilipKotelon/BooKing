﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Areas.Admin.ViewComponents
{
    public class AdminImageModalOpener : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
