using Microsoft.AspNetCore.Mvc;
using PryanikyTest.Interfaces;

namespace PryanikyTest.Controllers
{
    [Route("{controller}")]
    public class ProductsController : Controller
    {
        private readonly IProducts _products;
        public ProductsController(IProducts products)
        {
            _products = products;
        }
        [HttpGet]
        [Route("")]
        public IActionResult List()
        {
            if (_products.List.Count == 0) return Content("Товары отсутствуют");
            return Json(_products.List);
        }

        [HttpGet]
        [Route("{code}")]
        public IActionResult Show(string code)
        {
            var selectedProduct = _products.List.FirstOrDefault(p => p.Code == code);
            if (selectedProduct != null) return Json(selectedProduct);
            else return NotFound();
        }
    }
}
