using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Models
{
    public class ImageResponseModel
    {
        public List<ImageModel> Images { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
