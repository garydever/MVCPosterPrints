using MVCWebStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebStore.ViewModels
{
    public class ArtworkViewModel
    {
        public IEnumerable<Artwork> AllArtwork { get; set; }
        public int ArtworkCount { get; set; }
    }
}
