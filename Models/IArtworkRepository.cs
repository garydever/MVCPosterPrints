using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebStore.Models
{
    public interface IArtworkRepository
    {
        IEnumerable<Artwork> AllArtwork { get; }
        Artwork GetArtworkById(int artworkId);
    }
}
