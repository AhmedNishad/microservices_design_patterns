using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace gateway.Orders.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderStore store;

        public OrderController(OrderStore store)
        {
            this.store = store;
        }
        
        [HttpGet("")]
        public IActionResult GetOrders()
        {
            return Ok(store.orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            return Ok(store.orders.FirstOrDefault(o => o.OrderId == id));
        }

        [HttpGet("{customerId}/customer")]
        public IActionResult GetOrdersForCustomer(int customerId)
        {
            return Ok(store.orders.Where(o => o.Customer.CustomerId==customerId));
        }

        [HttpPost("")]
        public IActionResult AddOrder(OrderPost orderPost)
        {
            try
            {
                var order = new Order();
                order.Customer = new Customer { CustomerEmail = orderPost.Customer.Email,
                    CustomerId = orderPost.Customer.CustomerId,
                    CustomerName = orderPost.Customer.Name
                };
                order.PlacedOn = DateTime.Now;
                order.OrderId = store.orders.Count + 1;
                order.Items = new List<OrderItem>();
                foreach(var item in orderPost.Products)
                {
                    var orderItem = new OrderItem() { ItemId = 1000, ProductName = item.Name, Quantity = 1, UnitPriceInRupees = item.UnitPrice };
                    order.Items.Add(orderItem);
                }
                store.orders.Add(order);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("cancel")]
        public async Task<IActionResult> PostOrder(OrderCancelRequest request)
        {
            // Prepare
            var order = store.orders.FirstOrDefault(o => o.OrderId== request.OrderId);
            if (order == null)
            {
                return BadRequest("Order Doesn't Exist");
            }
            var productNames = new List<string>();
            foreach(var product in order.Items)
            {
                productNames.Add(product.ProductName);
            }
            store.orders.Remove(order);
            // Post to Customer
            using (var client = new HttpClient())
            {
                var url = $"https://localhost:{Mappings.addresses["products"]}/api/products/cancel";
                var json = JsonConvert.SerializeObject(new { Products = productNames });
                var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, stringContent);

                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (Exception e)
                {
                    return BadRequest("There was a problem with your request");
                }


                string content = await response.Content.ReadAsStringAsync();
                return Ok("Sent to !");
            }
        }
    }
}