using Microsoft.AspNetCore.Mvc;
using PryanikyTest.Interfaces;

namespace PryanikyTest.Controllers
{
    [Route("{controller}")]
    public class OrdersController : Controller
    {
        private readonly IOrders _orders;
        private readonly IProducts _products;
        public OrdersController(IOrders orders, IProducts products)
        {
            _orders = orders;
            _products = products;
        }

        [HttpGet]
        [Route("")]
        public IActionResult List()
        {
            if (_orders.OrderedProducts.Count == 0) return Content("Нет заказанных товаров.");
            return Json(_orders.OrderedProducts);
        }

        [HttpGet]
        [Route("{code}")]
        public IActionResult Show(string code)
        {
            var selectedOrder = _orders.OrderedProducts.FirstOrDefault(op => op.Code == code);
            if (selectedOrder is null) return NotFound();
            return LocalRedirectPermanent($"~/Products/{code}");
        }

        [HttpPost]
        [Route("{action}/{code}")]
        public IActionResult Create(string code)
        {
            var orderedProduct = _products.List.FirstOrDefault(p => p.Code == code);
            if (orderedProduct is null) return NotFound();
            else
            {
                _orders.OrderedProducts.Add(orderedProduct);
                return RedirectToActionPermanent("List");
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Clear()
        {
            _orders.OrderedProducts.Clear();
            return RedirectToActionPermanent("List");
        }

        [HttpDelete]
        [Route("{action}/{code}")]
        public IActionResult Delete(string code)
        {
            var deletedProductIndex = _orders.OrderedProducts.FindIndex(dp => dp.Code == code);
            if (deletedProductIndex == -1) return NotFound();
            else
            {
                _orders.OrderedProducts.RemoveAt(deletedProductIndex);
                return RedirectToActionPermanent("List");
            }
        }
    }
}
