using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Entities
{
    public class ApartmentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LocationName { get; set; }
        public string Description { get; set; }
        public string ImageIds { get; set; }
        public int MainImageId { get; set; }
    }
}
