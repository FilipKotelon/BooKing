using BooKing.Controllers;
using BooKing.Database;
using BooKing.Entities;
using BooKing.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Areas.Admin.Controllers
{
    [ApiController]
    [Route("api/apartment")]
    public class ApartmentApiController : BaseDbContactController
    {
        public ApartmentApiController(BooKingDbContext dbContext) : base(dbContext)
        {

        }

        [HttpPost("create")]
        public ApartmentApiResponseModel CreateAndRedirectToEdit(ApartmentSaveModel addedApartment)
        {
            var apartmentEntity = new ApartmentEntity
            {
                Name = addedApartment.Name,
                LocationName = addedApartment.LocationName,
                Description = addedApartment.Description,
                Sleeps = addedApartment.Sleeps,
                ImageIds = JsonConvert.SerializeObject(addedApartment.ImageIds)
            };

            _dbContext.Apartments.Add(apartmentEntity);
            _dbContext.SaveChanges();

            return new ApartmentApiResponseModel
            {
                RedirectUrl = $"/Admin/ApartmentSingle/Edit/{apartmentEntity.Id}"
            };
        }

        [HttpPost("modify")]
        public ApartmentApiResponseModel ModifyAndRedirectToEdit(ApartmentSaveModel editedApartment)
        {
            var apartmentEntity = _dbContext.Apartments.First(apartment => apartment.Id == editedApartment.Id);

            if(apartmentEntity != null)
            {
                apartmentEntity.Name = editedApartment.Name;
                apartmentEntity.Description = editedApartment.Description;
                apartmentEntity.LocationName = editedApartment.LocationName;
                apartmentEntity.Sleeps = editedApartment.Sleeps;
                apartmentEntity.ImageIds = JsonConvert.SerializeObject(editedApartment.ImageIds);

                _dbContext.SaveChanges();

                return new ApartmentApiResponseModel
                {
                    RedirectUrl = $"/Admin/ApartmentSingle/Edit/{editedApartment.Id}"
                };
            } else
            {
                return new ApartmentApiResponseModel
                {
                    RedirectUrl = ""
                };
            }
        }
    }
}
