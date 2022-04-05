using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.II
{
    public class ShopFacade
    {
        private IProductService productService;
        private ICartService cartService;
        private IPaymentService paymentService;

        public ShopFacade(IProductService productService, ICartService cartService, IPaymentService paymentService)
        {
            this.productService = productService;
            this.cartService = cartService;
            this.paymentService = paymentService;
        }

        public void Buy(params int[] productIds)
        {
            foreach (var productId in productIds)
            {
                var price = productService.GetPrice(productId);
                cartService.AddProduct(productId, price);
            }
            paymentService.Pay(cartService.GetId(), cartService.GetValue());
        }

    }
}
