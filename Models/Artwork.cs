using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebStore.Models
{
    public class Artwork
    {
        public int ArtworkId { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool IsSold { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbUrl { get; set; }
    }
}
