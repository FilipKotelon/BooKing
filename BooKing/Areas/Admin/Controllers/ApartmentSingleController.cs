using BooKing.Controllers;
using BooKing.Database;
using BooKing.Entities;
using BooKing.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApartmentSingleController : BaseDbContactController
    {

        public ApartmentSingleController(BooKingDbContext dbContext) : base(dbContext)
        {

        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var apartmentEntity = _dbContext.Apartments.First(apartment => apartment.Id == id);
                var apartment = ApartmentEntityToSaveModel(apartmentEntity);

                return View(apartment);
            } catch(InvalidOperationException exception)
            {
                return View("NotFound");
            }
        }

        public IActionResult NotFound()
        {
            return View();
        }
    }
}
