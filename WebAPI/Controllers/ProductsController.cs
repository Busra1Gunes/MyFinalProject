using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //c# Attribute Bir callas ile ilgili bilgi verme onu imzalama
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        //Bu komutu yazdıktan sonra sağ click ampül generic constractor denildiğinde  aşağıdaki yapı oluşur
        //public ProductsController(IProductService productService)
        //{
        //    this.productService = productService;
        //}
        //Loosely coupled
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //Dependency chain--Bağımlılık ziniciri

            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
