using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Entities
{
    public class UserMessageEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int ApartmentId { get; set; }
        public DateTime DateSent { get; set; }
    }
}
