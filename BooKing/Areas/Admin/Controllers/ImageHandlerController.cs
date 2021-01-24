using BooKing.Controllers;
using BooKing.Database;
using BooKing.Entities;
using BooKing.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Areas.Admin.Controllers
{
    [ApiController]
    [Route("api/images")]
    public class ImageHandlerController : BaseDbContactController
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public ImageHandlerController(BooKingDbContext dbContext, IHostingEnvironment hostingEnvironment) : base(dbContext)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public async Task<ImageResponseModel> Post(IList<IFormFile> images)
        {
            if(images != null & images.Count > 0)
            {

                var imageEntities = new List<ImageEntity>();
                var imageModels = new List<ImageModel>();

                foreach (IFormFile image in images)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;

                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    await image.CopyToAsync(new FileStream(filePath, FileMode.Create));

                    var imageEntity = new ImageEntity
                    {
                        FileLocation = uniqueFileName
                    };

                    imageEntities.Add(imageEntity);
                    _dbContext.Images.Add(imageEntity);
                }

                _dbContext.SaveChanges();

                foreach (ImageEntity imgEntity in imageEntities)
                {
                    imageModels.Add(new ImageModel
                    {
                        Id = imgEntity.Id,
                        FileLocation = imgEntity.FileLocation
                    }
                    );
                }

                return new ImageResponseModel
                {
                    Images = imageModels,
                    Message = "Images uploaded successfully!"
                };
            } else {
                return new ImageResponseModel
                {
                    Images = new List<ImageModel>(),
                    Message = "No images uploaded!"
                };
            }
        }

        [HttpGet]
        public ImageResponseModel Get()
        {
            var imagesList = _dbContext.Images.ToList<ImageEntity>();

            if (imagesList != null & imagesList.Count > 0)
            {
                var imageModels = new List<ImageModel>();

                foreach (ImageEntity image in imagesList)
                {
                    imageModels.Add(new ImageModel
                        {
                            Id = image.Id,
                            FileLocation = image.FileLocation
                        }
                    );
                }

                return new ImageResponseModel
                {
                    Images = imageModels,
                    Message = "Images received successfully!"
                };
            }
            else
            {
                return new ImageResponseModel
                {
                    Images = new List<ImageModel>(),
                    Message = "No image data stored in database!"
                };
            }
        }
    }
}
