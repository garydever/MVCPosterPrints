using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebStore.Models;
using MVCWebStore.ViewModels;

namespace MVCWebStore.Controllers
{
    public class ShopController : Controller
    {
        private readonly IArtworkRepository _artworkRepository;

        public ShopController(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }

        public IActionResult Index()
        {
            ArtworkViewModel artworkViewModel = new ArtworkViewModel();
            artworkViewModel.AllArtwork = _artworkRepository.AllArtwork;
            artworkViewModel.ArtworkCount = _artworkRepository.AllArtwork.Count();

            return View(artworkViewModel);
        }

        public IActionResult Detail(int id)
        {
            var artwork = _artworkRepository.GetArtworkById(id);
            if (artwork == null)
            {
                return NotFound();
            }
            return View(artwork);
        }
    }
}
