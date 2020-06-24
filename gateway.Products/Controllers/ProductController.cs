using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace gateway.Products.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductStore store;

        public ProductController(ProductStore store)
        {
            this.store = store;
        }
        [HttpGet("")]
        public IActionResult GetProducts()
        {
            return Ok(store.products);
        }

        [HttpPost("product")]
        public async Task<IActionResult> Post(Product product)
        {
            return Ok(product);
        }

        [HttpPost("order")]
        public async Task<IActionResult> PostOrder(OrderPost order)
        {
            // Prepare
            var orderDTO = new OrderDTO();
            orderDTO.products = new List<Product>();
            foreach (var productId in order.ProductIds)
            {
                var product = store.products.FirstOrDefault(p => p.ProductId == productId);
                if (product == null)
                {
                    return BadRequest("Product Doesn't Exist");
                }
                product.QuantityAtHand -= 1;
                product.Sales += 1;
                orderDTO.products.Add(product);
            }
            orderDTO.CustomerId = order.CustomerId;

            // Post to Customer
            using (var client = new HttpClient())
            {
                var url = $"https://localhost:{Mappings.addresses["customers"]}/api/customers/order";
                var json = JsonConvert.SerializeObject(orderDTO);
                var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, stringContent);

                try
                {
                    response.EnsureSuccessStatusCode();
                }catch(Exception e)
                {
                    return BadRequest("There was a problem with your request");
                }
                

                string content = await response.Content.ReadAsStringAsync();
                return Ok("Sent to !");
            }
        }

        [HttpPost("cancel")]
        public async Task<IActionResult> Cancel(CancelOrderRequest request)
        {
            // Prepare
            foreach(var productName in request.Products)
            {
                var product = store.products.FirstOrDefault(p => p.Name == productName);
                product.QuantityAtHand -= 1;
                product.Sales -= 1;
            }

           
           return Ok("Cancel Changes Reflected!");
        }
    }
}