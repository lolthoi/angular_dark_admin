using BikeStoreSimple.API.Models;
using BikeStoreSimple.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreSimple.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService storeService)
        {
            _customerService = storeService;
        }

        [HttpGet]
        public List<Customer> GetAllCustomer()
        {
            return _customerService.GetAllCustomer();
        }
        [HttpGet("{Id:int}")]
        public Customer GetCustomerById(int Id)
        {
            return _customerService.GetCustomerById(Id);
        }
        [HttpPost]
        public Customer CreateCustomer(Customer model)
        {
            return _customerService.CreateCustomer(model);
        }
        [HttpPut]
        public Customer UpdateCustomer(Customer model)
        {
            return _customerService.UpdateCustomer(model);
        }
        [HttpDelete("{Id:int}")]
        public bool DeleteCustomer(int Id)
        {
            return _customerService.DeleteCustomer(Id);
        }
    }
}
