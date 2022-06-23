using BikeStoreSimple.API.Models;
using BikeStoreSimple.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreSimple.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService storeService)
        {
            _staffService = storeService;
        }

        [HttpGet]
        public List<Staff> GetAllStaff()
        {
            return _staffService.GetAllStaff();
        }
        [HttpGet("{Id:int}")]
        public Staff GetStaffById(int Id)
        {
            return _staffService.GetStaffById(Id);
        }
        [HttpPost]
        public Staff CreateStaff(Staff model)
        {
            return _staffService.CreateStaff(model);
        }
        [HttpPut]
        public Staff UpdateStaff(Staff model)
        {
            return _staffService.UpdateStaff(model);
        }
        [HttpDelete("{Id:int}")]
        public bool DeleteStaff(int Id)
        {
            return _staffService.DeleteStaff(Id);
        }
    }
}
