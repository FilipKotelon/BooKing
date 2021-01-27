using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Models
{
    public class UserMessageAdminDisplayModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string ApartmentTitle { get; set; }
        public int ApartmentId { get; set; }
    }
}
