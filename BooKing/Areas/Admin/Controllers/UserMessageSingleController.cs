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
    public class UserMessageSingleController : BaseDbContactController
    {
        public UserMessageSingleController(BooKingDbContext dbContext) : base(dbContext)
        {

        }

        public IActionResult Index(int id)
        {
            try
            {
                var messageEntity = _dbContext.UserMessages.First(msg => msg.Id == id);

                if (messageEntity != null)
                {
                    var msg = UserMessageEntityToAdminDisplayModel(messageEntity);

                    return View(msg);
                }
                else
                {
                    return View("NotFound");
                }
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
