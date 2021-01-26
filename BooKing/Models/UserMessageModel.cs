using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Models
{
    public class UserMessageModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int ApartmentId { get; set; }
    }
}
