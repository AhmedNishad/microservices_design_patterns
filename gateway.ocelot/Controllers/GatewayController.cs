using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace gateway.ocelot.Controllers
{
    [Route("gateway")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok("Gateway!");
        }

        [HttpGet("customer")]
        public IActionResult GetOrdersForCustomerS()
        {
            // Get a query that gets the customer for customer Id
            return Ok("Gateway!");
            // Get a query that gets the ordersThatMatch CustomerId
            //return Ok();
        }

        [HttpGet("customer/{customerId}/orders")]
        public async Task<IActionResult> GetOrdersForCustomer(int customerId)
        {
            // Get a query that gets the customer for customer Id
            using(var client = new HttpClient())
            {
                var url = $"https://localhost:{Mappings.addresses["customers"]}/api/customers/{customerId}";
                var result = await client.GetAsync(url);
                var customerBody = await result.Content.ReadAsStringAsync();
                url = $"https://localhost:{Mappings.addresses["orders"]}/api/orders/{customerId}/customer";
                result = await client.GetAsync(url);
                var ordersBody = await result.Content.ReadAsStringAsync();
                return Ok(new { orders= JsonConvert.DeserializeObject(ordersBody), customer= JsonConvert.DeserializeObject(customerBody)});
            }
            // Get a query that gets the ordersThatMatch CustomerId
            //return Ok();
        }

        [HttpPost("")]
        public async Task<IActionResult> Post(OrderPost order)
        {
            return Ok(order);
        }

        [HttpPost("order")]
        public async Task<IActionResult> PostOrder(OrderPost order)
        {
            // Post to Product
            using (var client = new HttpClient())
            {
                var url = $"https://localhost:{Mappings.addresses["products"]}/api/products/order";
                var json = JsonConvert.SerializeObject(order);
                var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, stringContent);

                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                return Ok("Posted Order!");
            }
            // Get a query that gets the ordersThatMatch CustomerId
            //return Ok();
        }

        [HttpPost("cancel")]
        public async Task<IActionResult> CancelOrder(CancelOrderRequest request)
        {
            // TODO -- Make syncronous requests (Remove Await)

            // Post to Customer to Minus Results (Sales count and lifetime value
            using (var client = new HttpClient())
            {
                var url = $"https://localhost:{Mappings.addresses["customers"]}/api/customers/cancel";
                var json = JsonConvert.SerializeObject(new { customerId = request.CustomerId, orderTotal = request.OrderTotal });
                var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, stringContent);

                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                
            }

            // Post to Product to Add Quantities Which posts to Order which deletes the order
            using (var client = new HttpClient())
            {
                var url = $"https://localhost:{Mappings.addresses["orders"]}/api/orders/cancel";
                var json = JsonConvert.SerializeObject(new { orderId = request.OrderId });
                var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, stringContent);

                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
            }
            return Ok("Deleted Order!");
            // Get a query that gets the ordersThatMatch CustomerId
            //return Ok();
        }
    }
}