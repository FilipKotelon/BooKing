using BooKing.Database;
using BooKing.Models;
using BooKing.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Controllers
{
    public class HomeController : BaseDbContactController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(BooKingDbContext dbContext, ILogger<HomeController> logger) : base(dbContext)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var apartmentEntities = _dbContext.Apartments.Take(8).ToList();
            var apartments = new List<ApartmentModel>();

            foreach(ApartmentEntity entity in apartmentEntities)
            {
                apartments.Add(ApartmentEntityToModel(entity));
            }

            return View(apartments);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
