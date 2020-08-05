using MVCWebStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebStore.Models
{
    public class ArtworkRepository : IArtworkRepository
    {
        private readonly AppDbContext _appDbContext;

        public ArtworkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Artwork> AllArtwork => 
            _appDbContext.Artworks;

        public Artwork GetArtworkById(int artworkId)
        {
            return _appDbContext.Artworks.FirstOrDefault(a => a.ArtworkId == artworkId);
        }
    }
}
