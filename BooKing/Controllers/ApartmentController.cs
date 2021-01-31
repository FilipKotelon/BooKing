using BooKing.Database;
using BooKing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Controllers
{
    public class ApartmentController : BaseDbContactController
    {
        private readonly ILogger<ApartmentController> _logger;

        public ApartmentController(BooKingDbContext dbContext, ILogger<ApartmentController> logger) : base(dbContext)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            try
            {
                var apartmentEntity = _dbContext.Apartments.First(apartment => apartment.Id == id);
                var apartment = ApartmentEntityToModel(apartmentEntity);

                return View(apartment);
            } catch(InvalidOperationException exception)
            {
                return View("NotFound");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NotFound()
        {
            return View();
        }
    }
}
