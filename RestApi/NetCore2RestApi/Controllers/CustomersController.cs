using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCore2BLL;
using NetCore2BLL.BusinessObjects;
using System;

namespace NetCore2RestApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Customers")]
    public class CustomersController : Controller
    {

        BLLFacade facade = new BLLFacade();
        // GET: api/Customers
        [HttpGet]
        public IEnumerable<CustomerBO> Get()
        {
            return facade.CustomerService.GetAll();
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "Get")]
        public CustomerBO Get(int id)
        {
            return facade.CustomerService.Get(id);
        }
        
        // POST: api/Customers
        [HttpPost]
        public void Post([FromBody]CustomerBO cast)
        {
            facade.CustomerService.Create(cast);
        }
        
        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]CustomerBO cast)
        {
            if (id != cast.Id)
            {
                return BadRequest("You trying update the wrog Id. Güncellemeye çalıştığın I ile linkteki id uyuşmuyor");
            }
            var customer =  facade.CustomerService.Update(cast);
            return Ok(customer);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            facade.CustomerService.Delete(id);
        }
    }
}
