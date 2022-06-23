using BikeStoreSimple.API.Models;
using BikeStoreSimple.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreSimple.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public List<Store> GetAllStore()
        {
            return _storeService.GetAllStore();
        }
        [HttpGet("{Id:int}")]
        public Store GetStoreById(int Id)
        {
            return _storeService.GetStoreById(Id);
        }
        [HttpPost]
        public Store CreateStore(Store model)
        {
            return _storeService.CreateStore(model);
        }
        [HttpPut]
        public Store UpdateStore(Store model)
        {
            return _storeService.UpdateStore(model);
        }
        [HttpDelete("{Id:int}")]
        public bool DeleteStore(int Id)
        {
            return _storeService.DeleteStore(Id);
        }
    }
}
