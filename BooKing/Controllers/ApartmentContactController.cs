using BooKing.Database;
using BooKing.Entities;
using BooKing.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Controllers
{
    [ApiController]
    [Route("api/contact")]
    public class ApartmentContactController : BaseDbContactController
    {
        public ApartmentContactController(BooKingDbContext dbContext) : base(dbContext)
        {

        }

        [HttpPost]
        public ApartmentContactResponseModel Post(UserMessageModel userMessage)
        {
            var entity = new UserMessageEntity
            {
                Name = userMessage.Name,
                Email = userMessage.Email,
                Message = userMessage.Message,
                ApartmentId = userMessage.ApartmentId
            };

            _dbContext.UserMessages.Add(entity);
            _dbContext.SaveChanges();

            return new ApartmentContactResponseModel
            {
                Message = "We received your message and will respond with the next 24 hours!"
            };
        }
    }
}
