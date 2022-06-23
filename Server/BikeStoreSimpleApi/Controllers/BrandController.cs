using BikeStoreSimple.API.Models;
using BikeStoreSimple.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreSimple.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService storeService)
        {
            _brandService = storeService;
        }

        [HttpGet]
        public List<Brand> GetAllBrand()
        {
            return _brandService.GetAllBrand();
        }
        [HttpGet("{Id:int}")]
        public Brand GetBrandById(int Id)
        {
            return _brandService.GetBrandById(Id);
        }
        [HttpPost]
        public Brand CreateBrand(Brand model)
        {
            return _brandService.CreateBrand(model);
        }
        [HttpPut]
        public Brand UpdateBrand(Brand model)
        {
            return _brandService.UpdateBrand(model);
        }
        [HttpDelete("{Id:int}")]
        public bool DeleteBrand(int Id)
        {
            return _brandService.DeleteBrand(Id);
        }
    }
}
