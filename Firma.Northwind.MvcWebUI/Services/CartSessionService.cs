using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firma.Northwind.Entities.Concrete;
using Firma.Northwind.MvcWebUI.ExtensionMetots;
using Microsoft.AspNetCore.Http;

namespace Firma.Northwind.MvcWebUI.Services
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _httpContextAccessor; 

        public CartSessionService(IHttpContextAccessor httpContextAccessor) 
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Cart GetCart()
        {
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck== null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart",new Cart());

                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");

            }
            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
