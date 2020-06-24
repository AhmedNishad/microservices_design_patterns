namespace gateway.Customers.Controllers
{
    public class OrderCancelRequest
    {
        public int CustomerId { get; set; }
        public decimal OrderTotal { get; set; }
    }
}