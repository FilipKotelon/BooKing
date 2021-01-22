using BooKing.Database;
using BooKing.Entities;
using BooKing.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Controllers
{
    public abstract class BaseDbContactController : Controller
    {
        protected readonly BooKingDbContext _dbContext;
        public BaseDbContactController(BooKingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected ApartmentModel ApartmentEntityToModel(ApartmentEntity entity)
        {
            var imagesIdList = JsonConvert.DeserializeObject<List<int>>(entity.ImageIds);
            var imageModelsList = new List<ImageModel>();

            foreach (int imageId in imagesIdList)
            {
                imageModelsList.Add(
                    new ImageModel
                    {
                        FileLocation = _dbContext.Images.First(img => img.Id == imageId).FileLocation
                    }
                );
            }

            return new ApartmentModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                LocationName = entity.LocationName,
                Sleeps = entity.Sleeps,
                Images = imageModelsList
            };
        }
    }
}
