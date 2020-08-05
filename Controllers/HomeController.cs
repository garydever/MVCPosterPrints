using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCWebStore.Models;
using MVCWebStore.ViewModels;

namespace MVCWebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArtworkRepository _artworkRepository;

        public HomeController(ILogger<HomeController> logger, IArtworkRepository artworkRepository)
        {
            _logger = logger;
            _artworkRepository = artworkRepository;
        }

        public IActionResult Index()
        {
            ArtworkViewModel artworkViewModel = new ArtworkViewModel();
            artworkViewModel.AllArtwork = _artworkRepository.AllArtwork;
            artworkViewModel.ArtworkCount = _artworkRepository.AllArtwork.Count();
            return View(artworkViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
