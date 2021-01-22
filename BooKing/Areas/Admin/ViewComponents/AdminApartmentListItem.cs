using BooKing.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Areas.Admin.ViewComponents
{
    public class AdminApartmentListItem : ViewComponent
    {
        public IViewComponentResult Invoke(ApartmentModel apartment)
        {
            return View(apartment);
        }
    }
}
