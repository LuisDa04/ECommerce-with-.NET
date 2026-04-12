namespace ProyectoTestNET.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserID { get; set; }
        public decimal TotalAmount { get; set; }

        public User? User { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}