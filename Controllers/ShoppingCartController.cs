using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebStore.Models;
using MVCWebStore.ViewModels;

namespace MVCWebStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IArtworkRepository _artworkRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IArtworkRepository artworkRepository, ShoppingCart shoppingCart)
        {
            _artworkRepository = artworkRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int artworkId)
        {
            var selectedArtwork = _artworkRepository.AllArtwork.FirstOrDefault(p => p.ArtworkId == artworkId);

            if (selectedArtwork != null)
            {
                _shoppingCart.AddToCart(selectedArtwork, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int artworkId)
        {
            var selectedArtwork = _artworkRepository.AllArtwork.FirstOrDefault(p => p.ArtworkId == artworkId);

            if (selectedArtwork != null)
            {
                _shoppingCart.RemoveFromCart(selectedArtwork);
            }
            return RedirectToAction("Index");
        }
    }
}
