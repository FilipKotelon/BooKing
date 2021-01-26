using BooKing.Database;
using BooKing.Models;
using BooKing.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Controllers
{
    public class ApartmentArchiveController : BaseDbContactController
    {
        public ApartmentArchiveController(BooKingDbContext dbContext) : base(dbContext)
        {

        }

        public IActionResult Index()
        {
            var apartmentEntities = _dbContext.Apartments.ToList();
            var apartments = new List<ApartmentModel>();

            foreach(ApartmentEntity entity in apartmentEntities)
            {
                apartments.Add(ApartmentEntityToModel(entity));
            }

            return View(apartments);
        }
    }
}
