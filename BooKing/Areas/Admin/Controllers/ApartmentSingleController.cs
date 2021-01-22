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
        private readonly IHostingEnvironment _hostingEnvironment;

        public ApartmentSingleController(BooKingDbContext dbContext, IHostingEnvironment hostingEnvironment) : base(dbContext)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult CreateAndRedirectToEdit(ApartmentAddModel addedApartment)
        {
            var imageEntities = new List<ImageEntity>();
            var imageModels = new List<ImageModel>();
            var imageIds = new List<int>();

            if(addedApartment.Images != null && addedApartment.Images.Count > 0)
            {
                foreach(IFormFile image in addedApartment.Images)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;

                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    image.CopyTo(new FileStream(filePath, FileMode.Create));

                    var imageEntity = new ImageEntity
                    {
                        FileLocation = uniqueFileName
                    };

                    imageEntities.Add(imageEntity);
                    _dbContext.Images.Add(imageEntity);
                }
            }

            _dbContext.SaveChanges();

            foreach(ImageEntity imageEntity in imageEntities)
            {
                imageModels.Add(new ImageModel { FileLocation = imageEntity.FileLocation });
                imageIds.Add(imageEntity.Id);
            }

            var apartmentEntity = new ApartmentEntity
            {
                Name = addedApartment.Name,
                LocationName = addedApartment.LocationName,
                Description = addedApartment.Description,
                Sleeps = addedApartment.Sleeps,
                ImageIds = JsonConvert.SerializeObject(imageIds)
            };

            _dbContext.Apartments.Add(apartmentEntity);
            _dbContext.SaveChanges();

            var apartment = new ApartmentModel
            {
                Id = apartmentEntity.Id,
                Name = addedApartment.Name,
                Description = addedApartment.Description,
                Sleeps = addedApartment.Sleeps,
                Images = imageModels
            };

            return RedirectToAction("Edit", apartment);
        }

        public IActionResult Edit(ApartmentModel apartment)
        {
            return View(apartment);
        }

        public IActionResult ModifyAndRedirectToEdit(ApartmentModel editedApartment)
        {
            return RedirectToAction("Edit");
        }
    }
}
