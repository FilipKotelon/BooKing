using BooKing.Controllers;
using BooKing.Database;
using BooKing.Entities;
using BooKing.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApartmentsListController : BaseDbContactController
    {
        public ApartmentsListController(BooKingDbContext dbContext) : base(dbContext)
        {
        
        }

        public IActionResult Index()
        {
            var apartmentEntitiesList = _dbContext.Apartments.ToList<ApartmentEntity>();
            var apartmentsList = new List<ApartmentModel>();

            foreach(ApartmentEntity entity in apartmentEntitiesList)
            {
                apartmentsList.Add(ApartmentEntityToModel(entity));
            }

            return View("Index", apartmentsList);
        }

        public IActionResult RemoveAndRedirectToList()
        {
            int apartmentId = 0;

            return RedirectToAction("Index");
        }
    }
}
