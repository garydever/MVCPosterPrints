using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebStore.Models
{
    public class MockArtworkRepository : IArtworkRepository
    {
        public IEnumerable<Artwork> AllArtwork => 
            new List<Artwork>
            {
                new Artwork{ArtworkId=1, Name="Borobodur", Price=400M, IsSold=false, ImageUrl="https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354589/Artwork/468_jcx5ul.jpg"},
                new Artwork{ArtworkId=2, Name="The Samurai", Price=300M, IsSold=false, ImageUrl="https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354587/Artwork/341_pbzjfl.jpg"},
                new Artwork{ArtworkId=3, Name="Jakarta Bicycles", Price=650M, IsSold=false, ImageUrl="https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354586/Artwork/388_l2fdca.jpg"}
            };

        public Artwork GetArtworkById(int artworkId)
        {
            return AllArtwork.FirstOrDefault(a => a.ArtworkId == artworkId);
        }
    }
}
