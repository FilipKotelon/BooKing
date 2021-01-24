using BooKing.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Areas.Admin.ViewComponents
{
    public class AdminImageModal : ViewComponent
    {
        public IViewComponentResult Invoke(string inputId, IList<int> apartmentImageIds)
        {
            return View(
                new AdminImageModalModel 
                { 
                    InputId = inputId,
                    ApartmentImageIdsAsString = JsonConvert.SerializeObject(apartmentImageIds)
                }
            );
        }
    }
}
