using BooKing.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Areas.Admin.ViewComponents
{
    public class AdminImageModal : ViewComponent
    {
        public IViewComponentResult Invoke(string inputId, string apartmentImageIds)
        {
            return View(
                new AdminImageModalModel 
                { 
                    InputId = inputId,
                    ApartmentImageIdsAsString = apartmentImageIds
                }
            );
        }
    }
}
