using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Models
{
    public class ApartmentAddModel
    {
        public string Name { get; set; }
        public string LocationName { get; set; }
        public string Description { get; set; }
        public int Sleeps { get; set; }
        public List<IFormFile> Images { get; set; }
    }
}
