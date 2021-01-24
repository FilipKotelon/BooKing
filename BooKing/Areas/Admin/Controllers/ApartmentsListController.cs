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

        public IActionResult RemoveAndRedirectToList(int apartmentId)
        {
            var apartmentToRemove = _dbContext.Apartments.First(apartment => apartment.Id == apartmentId);

            if (apartmentToRemove != null)
            {
                _dbContext.Apartments.Remove(apartmentToRemove);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
