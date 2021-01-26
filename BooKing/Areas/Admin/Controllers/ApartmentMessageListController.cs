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
    public class ApartmentMessageListController : BaseDbContactController
    {

        public ApartmentMessageListController(BooKingDbContext dbContext) : base(dbContext)
        {

        }

        public IActionResult Index()
        {
            var userMessageEntities = _dbContext.UserMessages.ToList();
            var userMessages = new List<UserMessageAdminDisplayModel>();

            foreach(UserMessageEntity entity in userMessageEntities)
            {
                userMessages.Add(UserMessageEntityToAdminDisplayModel(entity));
            }

            return View();
        }
    }
}
