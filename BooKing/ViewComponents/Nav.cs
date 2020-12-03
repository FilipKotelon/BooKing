using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.ViewComponents
{
    public class Nav : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
