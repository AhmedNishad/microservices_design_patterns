using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace gateway.Customers.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private CustomerStore store;

        public CustomersController(CustomerStore store)
        {
            this.store = store;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(store.customers);
        }
        [HttpGet("{customerId}")]
        public IActionResult GetById(int customerId)
        {
            return Ok(store.customers.FirstOrDefault(c => c.CustomerId == customerId));
        }

        [HttpGet("{customerId:int}/orders")]
        public async Task<IActionResult> GetOrdersForCustomer(int customerId)
        {
            // Get a query that gets the customer for customer Id
            using (var client = new HttpClient())
            {
                //var url = $"https://localhost:{Mappings.addresses["customers"]}/api/customers/{customerId}";
                var url = $"https://localhost:{Mappings.addresses["orders"]}/api/orders/{customerId}/customer";
                var result = await client.GetAsync(url);
                var body = result.Content.ReadAsStringAsync();
                return Ok(body.Result);
            }
            // Get a query that gets the ordersThatMatch CustomerId
            //return Ok();
        }

        [HttpPost("order")]
        public async Task<IActionResult> PostOrder(OrderPost order)
        {
            // Prepare
            var orderDTO = new OrderDTO();
            orderDTO.Products = order.Products;
            var customer = store.customers.FirstOrDefault(c => c.CustomerId == order.CustomerId);
            foreach (var product in orderDTO.Products)
            {
                customer.LifeTimeValue += product.UnitPrice * 1;
            }
            customer.OrderCount++;
            orderDTO.Customer = customer;

            // Post to Orders
            using (var client = new HttpClient())
            {
                var url = $"https://localhost:{Mappings.addresses["orders"]}/api/orders";
                var json = JsonConvert.SerializeObject(orderDTO);
                var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, stringContent);

                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                return Ok("Sent to !");
            }
        }

        [HttpPost("cancel")]
        public async Task<IActionResult> CancelOrder(OrderCancelRequest request)
        {
            var customer = store.customers.FirstOrDefault(c => c.CustomerId == request.CustomerId);
            if (customer == null)
            {
                return BadRequest("Customer Not Found");
            }
            customer.LifeTimeValue -= request.OrderTotal;
            customer.OrderCount -= 1;
            return Ok("Reductions Complete");
        }
    }
}